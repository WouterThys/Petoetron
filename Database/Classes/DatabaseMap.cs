using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Database.Classes
{
    public class DatabaseMap
    {
        private List<DbTable> tableList;
        private List<DbProcedure> procedureList;

        private string schema;
        private Func<DbConnection> getConnection;

        public DatabaseMap(string schema, Func<DbConnection> getConnection)
        {
            this.schema = schema;
            this.getConnection = getConnection;
        }

        public void UpdateData()
        {
            tableList = null;
            procedureList = null;
        }

        public List<DbTable> Tables
        {
            get
            {
                if (tableList == null)
                {
                    try
                    {
                        using (DbConnection connection = getConnection())
                        {
                            connection.Open();
                            tableList = GetTables(schema, connection);
                        }
                        foreach (DbTable table in tableList)
                        {
                            table.Procedures = FindProceduresForTable(table);
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine("Error in GetTables: " + e);
                    }
                }
                return tableList;
            }
        }

        public List<DbProcedure> Procedures
        {
            get
            {
                if (procedureList == null)
                {
                    try
                    {
                        using (DbConnection connection = getConnection())
                        {
                            connection.Open();
                            procedureList = GetProcedures(connection);
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine("Error in GetProcedures: " + e);
                    }
                }
                return procedureList;
            }
        }

        private List<DbTable> GetTables(string schema, DbConnection connection)
        {
            List<DbTable> tables = new List<DbTable>();
            string sql = "SELECT * FROM information_schema.tables where table_schema='" + schema + "';";
            using (DbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = sql;

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DbTable table = new DbTable()
                        {
                            Name = DatabaseAccess.RGetString(reader, "TABLE_NAME"),
                            Schema = DatabaseAccess.RGetString(reader, "TABLE_SCHEMA"),
                            Engine = DatabaseAccess.RGetString(reader, "ENGINE"),
                            Version = DatabaseAccess.RGetInt(reader, "VERSION")
                        };
                        tables.Add(table);
                    }
                }
            }
            foreach (DbTable table in tables)
            {
                table.Columns = GetColumnsForTable(connection, table);
                table.ForeignKeys = GetForeignKeysForTable(connection, table);
            }
            return tables;
        }

        private List<DbColumn> GetColumnsForTable(DbConnection connection, DbTable table)
        {
            List<DbColumn> columns = new List<DbColumn>();
            string sql = "SELECT * FROM `INFORMATION_SCHEMA`.`COLUMNS` WHERE `TABLE_SCHEMA`='" + table.Schema + "' AND `TABLE_NAME`='" + table.Name + "';";
            using (DbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DbColumn column = new DbColumn(table)
                        {
                            Name = DatabaseAccess.RGetString(reader, "COLUMN_NAME"),
                            Ordinal = DatabaseAccess.RGetInt(reader, "ORDINAL_POSITION"),
                            ColumnType = DatabaseAccess.RGetString(reader, "COLUMN_TYPE")
                        };
                        columns.Add(column);
                    }
                }
            }
            return columns;
        }

        private List<DbForeignKey> GetForeignKeysForTable(DbConnection connection, DbTable table)
        {
            List<DbForeignKey> keys = new List<DbForeignKey>();
            string sql = "SELECT COLUMN_NAME, CONSTRAINT_NAME, REFERENCED_TABLE_NAME, REFERENCED_COLUMN_NAME " +
                "FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE " +
                "WHERE " +
                "REFERENCED_TABLE_SCHEMA = '" + table.Schema + "' AND " +
                "TABLE_NAME = '" + table.Name + "'; ";

            using (DbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DbForeignKey key = new DbForeignKey()
                        {
                            Name = DatabaseAccess.RGetString(reader, "CONSTRAINT_NAME"),
                            FromTableName = table.Name,
                            FromColumnName = DatabaseAccess.RGetString(reader, "COLUMN_NAME"),
                            ReferenceTableName = DatabaseAccess.RGetString(reader, "REFERENCED_TABLE_NAME"),
                            ReferenceColumnName = DatabaseAccess.RGetString(reader, "REFERENCED_COLUMN_NAME"),
                        };
                        keys.Add(key);
                    }
                }
            }

            return keys;
        }

        private List<DbProcedure> GetProcedures(DbConnection connection)
        {
            List<DbProcedure> procedureList = new List<DbProcedure>();
            //string sql = "SELECT * FROM mysql.proc;";
            string sql = "SELECT ROUTINE_NAME, ROUTINE_DEFINITION FROM information_schema.routines WHERE routine_schema = 'ww';";
            using (DbCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DbProcedure procedure = new DbProcedure()
                        {
                            Name = DatabaseAccess.RGetString(reader, "ROUTINE_NAME"),
                            Body = DatabaseAccess.RGetString(reader, "ROUTINE_DEFINITION")
                        };

                        //string paramListString = DatabaseAccess.RGetString(reader, "param_list");
                        //string returnListString = DatabaseAccess.RGetString(reader, "returns");

                        //procedure.ParameterList.AddRange(CreateParametersFromString(paramListString));
                        //procedure.ReturnList.AddRange(CreateParametersFromString(returnListString));

                        procedureList.Add(procedure);
                    }
                }
            }

            return procedureList;
        }

        private List<DbProcedure> FindProceduresForTable(DbTable table)
        {
            List<DbProcedure> list = new List<DbProcedure>();
            if (table != null)
            {
                foreach (DbProcedure procedure in Procedures)
                {
                    if (!table.IsLinkTable)
                    {
                        if (procedure.Name.ToUpper().StartsWith(table.Name.ToUpper()) ||
                            procedure.Name.ToUpper().StartsWith("OBJECT"))
                        {
                            list.Add(procedure);
                        }
                    }
                    else
                    {
                        if (procedure.Name.ToUpper().StartsWith(table.Name.ToUpper()))
                        {
                            list.Add(procedure);
                        }
                    }
                }
            }
            return list;
        }

        private List<DbProcedureParameter> CreateParametersFromString(string paramListString)
        {
            List<DbProcedureParameter> parameterList = new List<DbProcedureParameter>();
            if (!string.IsNullOrEmpty(paramListString))
            {
                paramListString = paramListString.Trim();
                paramListString = Regex.Replace(paramListString, @"\t|\n|\r", "");
                string[] split = paramListString.Split(',');
                foreach (string line in split)
                {
                    if (string.IsNullOrEmpty(line)) continue;
                    parameterList.Add(new DbProcedureParameter(line.Trim()));
                }
            }
            return parameterList;
        }
    }
}
