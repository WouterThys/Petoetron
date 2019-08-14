using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Database.Classes
{
    public enum TableCheckType
    {
        Ok = 1,
        NotChecked = 0,
        Warning = -1,
        Error = -2
    }

    public class TableCheck
    {
        public TableCheckType CheckType { get; set; }
        public string Message { get; set; }
        public TableCheck(TableCheckType checkType, string message)
        {
            CheckType = checkType;
            Message = message;
        }

        public int CheckTypeAsInt
        {
            get { return (int)CheckType; }
        }
    }

    [DataContract]
    public class DbTable
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Schema { get; set; }
        [DataMember]
        public string Engine { get; set; }
        [DataMember]
        public int Version { get; set; }
        [DataMember]
        public List<DbColumn> Columns { get; set; }
        [DataMember]
        public List<DbProcedure> Procedures { get; set; }
        [DataMember]
        public List<DbForeignKey> ForeignKeys { get; set; }

        private List<TableCheck> columnChecks;
        private List<TableCheck> procedureChecks;
        private List<TableCheck> procedureContentChecks;

        private TableCheckType columnCheck;
        private TableCheckType procedureCheck;
        private TableCheckType procedureContentCheck;

        // TODO: to setting?
        private List<ActionType> objectCheckActions;
        private List<ActionType> linkCheckActions;

        private bool createdReferences = false; // Helper

        public DbTable()
        {
            Columns = new List<DbColumn>();
            Procedures = new List<DbProcedure>();
        }

        public override string ToString()
        {
            return "Table: " + Name;
        }

        public override bool Equals(object obj)
        {
            return obj is DbTable table &&
                   Name == table.Name &&
                   Schema == table.Schema;
        }

        public override int GetHashCode()
        {
            var hashCode = -1196300468;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Schema);
            return hashCode;
        }

        public List<ActionType> ObjectCheckActions
        {
            get
            {
                if (objectCheckActions == null)
                {
                    objectCheckActions = new List<ActionType>()
                    {
                        ActionType.Insert,
                        ActionType.Update,
                        ActionType.Delete,
                        ActionType.SelectAll,
                        ActionType.SelectById
                    };
                }
                return objectCheckActions;
            }
        }

        public List<ActionType> LinkCheckActions
        {
            get
            {
                if (linkCheckActions == null)
                {
                    linkCheckActions = new List<ActionType>()
                    {
                        ActionType.Insert,
                        ActionType.Delete
                    };
                }
                return linkCheckActions;
            }
        }

        public bool IsLinkTable
        {
            get { return Name.ToUpper().StartsWith("LINK"); }
        }

        public void CreateReferences()
        {
            if (!createdReferences)
            {
                if (Columns != null)
                {
                    foreach (DbColumn column in Columns)
                    {
                        column.SetTable(this);
                        column.SetForeignKey(FindForeignKeyForColumn(column));
                    }
                }

                createdReferences = true;
            }
        }

        public void UpdateChecks()
        {
            columnChecks = null;
            columnCheck = TableCheckType.NotChecked;
            procedureChecks = null;
            procedureCheck = TableCheckType.NotChecked;
            procedureContentChecks = null;
            procedureCheck = TableCheckType.NotChecked;
        }

        public List<TableCheck> ColumnChecks
        {
            get
            {
                if (columnChecks == null)
                {
                    columnChecks = new List<TableCheck>();
                    columnCheck = CheckColumns();
                }
                return columnChecks;
            }
        }

        public List<TableCheck> ProcedureChecks
        {
            get
            {
                if (procedureChecks == null)
                {
                    procedureChecks = new List<TableCheck>();
                    procedureCheck = CheckProcedures();
                }
                return procedureChecks;
            }
        }

        public List<TableCheck> ProcedureContentChecks
        {
            get
            {
                if (procedureContentChecks == null)
                {
                    procedureContentChecks = new List<TableCheck>();
                    procedureContentCheck = CheckProcedureContents();
                }
                return procedureContentChecks;
            }
        }

        public TableCheckType ColumnCheckState
        {
            get
            {
                if (columnCheck == TableCheckType.NotChecked)
                {
                    columnChecks = new List<TableCheck>();
                    columnCheck = CheckColumns();
                }
                return columnCheck;
            }
        }

        public TableCheckType ProcedureCheckState
        {
            get
            {
                if (procedureCheck == TableCheckType.NotChecked)
                {
                    procedureChecks = new List<TableCheck>();
                    procedureCheck = CheckProcedures();
                }
                return procedureCheck;
            }
        }

        public TableCheckType ProcedureContentCheckState
        {
            get
            {
                if (procedureContentCheck == TableCheckType.NotChecked)
                {
                    procedureContentChecks = new List<TableCheck>();
                    procedureContentCheck = CheckProcedureContents();
                }
                return procedureContentCheck;
            }
        }

        private DbForeignKey FindForeignKeyForColumn(DbColumn column)
        {
            DbForeignKey foundKey = null;
            if (ForeignKeys != null)
            {
                foundKey = ForeignKeys.FirstOrDefault(k => k.FromColumnName.Equals(column.Name));
            }
            return foundKey;
        }

        private TableCheckType CheckColumns()
        {
            TableCheckType state = TableCheckType.Ok;
            if (Columns != null && Columns.Count > 0)
            {
                // Object table
                if (!IsLinkTable)
                {
                    CheckColumn("id", ColumnChecks);
                    CheckColumn("code", ColumnChecks);
                    state = ColumnChecks.Count > 0 ? TableCheckType.Warning : TableCheckType.Ok;
                }
                else
                {
                    CheckColumn("id", ColumnChecks);
                    if (ForeignKeys == null || ForeignKeys.Count < 2)
                    {
                        ColumnChecks.Add(new TableCheck(TableCheckType.Error, "Link table should have at least 2 foreign key columns"));
                    }
                    state = ColumnChecks.Count > 0 ? TableCheckType.Warning : TableCheckType.Ok;
                }
            }
            else
            {
                ColumnChecks.Add(new TableCheck(TableCheckType.Error, "No columns found.."));
                state = TableCheckType.Error;
            }

            return state;
        }
        
        private TableCheckType CheckProcedures()
        {
            TableCheckType state = TableCheckType.Ok;
            if (Procedures != null && Procedures.Count > 0)
            {
                // Object table
                if (!IsLinkTable)
                {
                    foreach (ActionType type in ObjectCheckActions)
                    {
                        CheckProcedure(type, ProcedureChecks);
                    }
                    state = ProcedureChecks.Count > 0 ? TableCheckType.Warning : TableCheckType.Ok;
                }
                else
                {
                    foreach (ActionType type in LinkCheckActions)
                    {
                        CheckProcedure(type, ProcedureChecks);
                    }


                    state = ((ProcedureChecks.Count > 0) ? TableCheckType.Warning : TableCheckType.Ok);
                }
            }
            else
            {
                ProcedureChecks.Add(new TableCheck(TableCheckType.Error, "No procedures found.."));
                state = TableCheckType.Error;
            }
            
            return state;
        }

        public List<ActionType> MissingScriptTypes()
        {
            List<ActionType> missing = new List<ActionType>();
            List<ActionType> checks = !IsLinkTable ? ObjectCheckActions : LinkCheckActions;
            
            foreach (ActionType type in checks)
            {
                if (FindProcedureByType(type) == null)
                {
                    missing.Add(type);
                }
            }
            return missing;
        }

        public TableCheckType CheckProcedureContents()
        {
            TableCheckType state = TableCheckType.Ok;
            if (Procedures != null)
            {
                foreach (DbProcedure procedure in Procedures)
                {
                    CheckProcedureContent(procedure, ProcedureContentChecks);
                }
                state = ((ProcedureContentChecks.Count > 0) ? TableCheckType.Warning : TableCheckType.Ok);
            }
            return state;
        }

        public void CheckProcedureContent(DbProcedure procedure, List<TableCheck> checkList)
        {
            if (procedure != null)
            {
                foreach (ActionType type in ObjectCheckActions)
                {
                    if (type == procedure.ActionType)
                    {
                        string check = DbProcedureCreator.CreateProcedureScript(this, type, true);
                        string cleanCheck = CleanUpBody(check);
                        string cleanBody = CleanUpBody(procedure.Body);
                        if (CleanUpBody(check) != CleanUpBody(procedure.Body))
                        {
                            checkList.Add(new TableCheck(TableCheckType.Warning, "Mismatch between procedure and check script for " + procedure.Name));
                        }
                    }
                }
            }
        }

        private static string CleanUpBody(string inputString)
        {
            string output = "";
            if (!string.IsNullOrEmpty(inputString))
            {
                output = inputString.Replace(Environment.NewLine, string.Empty);
                output = output.Replace("\n", string.Empty);
                output = output.Replace("\r", string.Empty);
                output = output.Replace("\t", string.Empty);
                output = output.Trim();
                output = output.ToUpper();
            }
            return output;
        }


        public void CheckProcedure(ActionType action, List<TableCheck> checkList)
        {
            if (FindProcedureByType(action) == null)
            {
                checkList.Add(new TableCheck(TableCheckType.Warning, "No " + action.ToString().ToLower() + " procedure.."));
            }
        }

        public void CheckColumn(string name, List<TableCheck> checkList)
        {
            if (FindColumnByName(name) == null)
            {
                checkList.Add(new TableCheck(TableCheckType.Warning, "No column with name " + name));
            }
        }

        public DbProcedure FindProcedureByType(ActionType action)
        {
            DbProcedure foundProcedure = null;
            if (Procedures != null)
            {
                foundProcedure = Procedures.FirstOrDefault(p => p.ActionType == action);
            }
            return foundProcedure;
        }

        public DbColumn FindColumnByName(string name)
        {
            DbColumn foundColumn = null;
            if (Columns != null)
            {
                foundColumn = Columns.FirstOrDefault(c => c.Name.ToUpper().Equals(name.ToUpper()));
            }
            return foundColumn;
        }
    }
}
