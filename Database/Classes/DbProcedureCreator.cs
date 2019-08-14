using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    public static class DbProcedureCreator
    {

        private static readonly string DELIMITER = "$$";

        public static string CreateProcedureScript(DbTable table, ActionType type, bool bodyOnly)
        {
            return CreateProcedureScript(table, CreateProcedure(table, type), bodyOnly);
        }

        public static DbProcedure CreateProcedure(DbTable table, ActionType type)
        {
            DbProcedure procedure = new DbProcedure();

            List<DbProcedureParameter> paramterList = new List<DbProcedureParameter>();
            switch (type)
            {
                case ActionType.Insert:
                    procedure.Name = table.Name + type.ToString();
                    foreach (DbColumn column in table.Columns)
                    {
                        if (column.Name == "id") continue;
                        paramterList.Add(new DbProcedureParameter(column.Name, column.ColumnType, ParameterDirection.Input));
                    }
                    paramterList.Add(new DbProcedureParameter("lid", "int", ParameterDirection.Output));
                    break;
                case ActionType.Update:
                    procedure.Name = table.Name + type.ToString();
                    foreach (DbColumn column in table.Columns)
                    {
                        if (column.Name == "id") continue;
                        paramterList.Add(new DbProcedureParameter(column.Name, column.ColumnType, ParameterDirection.Input));
                    }
                    paramterList.Add(new DbProcedureParameter("updateId", "int", ParameterDirection.Input));
                    break;
                case ActionType.Delete:
                    if (!table.IsLinkTable)
                    {
                        procedure.Name = "object" + type.ToString();
                        paramterList.Add(new DbProcedureParameter("tableName", "varchar(128)", ParameterDirection.Input));
                        paramterList.Add(new DbProcedureParameter("deleteId", "int", ParameterDirection.Input));
                    }
                    else
                    {
                        procedure.Name = table.Name + type.ToString();
                        foreach (DbForeignKey key in table.ForeignKeys)
                        {
                            paramterList.Add(new DbProcedureParameter(key.FromColumnName, "int", ParameterDirection.Input));
                        }
                    }
                    break;
                case ActionType.SelectAll:
                    procedure.Name = "object" + type.ToString();
                    paramterList.Add(new DbProcedureParameter("tableName", "varchar(128)", ParameterDirection.Input));
                    break;
                case ActionType.SelectById:
                    procedure.Name = "object" + type.ToString();
                    paramterList.Add(new DbProcedureParameter("tableName", "varchar(128)", ParameterDirection.Input));
                    paramterList.Add(new DbProcedureParameter("selectId", "int", ParameterDirection.Input));
                    break;
            }
            procedure.ParameterList = paramterList;
            return procedure;
        }

        public static string CreateProcedureScript(DbTable table, DbProcedure procedure, bool bodyOnly)
        {
            StringBuilder sb = new StringBuilder();
            if (!bodyOnly)
            {
                sb.Append(GetDropIfExistsString(table.Schema, procedure));
                sb.Append(GetDelimiterString(DELIMITER));
                sb.Append(GetProcedureDefinitionString(table.Schema, procedure));
            }
            switch (procedure.ActionType)
            {
                case ActionType.Insert:
                    sb.Append(GetBodyInsertAsString(table));
                    if (!bodyOnly) sb.Append(DELIMITER).Append(Environment.NewLine);
                    break;
                case ActionType.Update:
                    sb.Append(GetBodyUpdateAsString(table));
                    if (!bodyOnly) sb.Append(DELIMITER).Append(Environment.NewLine);
                    break;
                case ActionType.Delete:
                    sb.Append(GetBodyDeleteAsString(table));
                    if (!bodyOnly) sb.Append(DELIMITER).Append(Environment.NewLine);
                    break;
                case ActionType.SelectAll:
                    sb.Append(GetBodySelectAllAsString(table));
                    if (!bodyOnly) sb.Append(DELIMITER).Append(Environment.NewLine);
                    break;
                case ActionType.SelectById:
                    sb.Append(GetBodySelectByIdAsString(table));
                    if (!bodyOnly) sb.Append(DELIMITER).Append(Environment.NewLine);
                    break;
            }
            if (!bodyOnly)
            {
                sb.Append(GetDelimiterString(";"));
            }
            return sb.ToString();
        }


        /*
        DELIMITER $$
        */
        public static string GetDelimiterString(string delimiter)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("DELIMITER ").Append(delimiter).Append(Environment.NewLine);
            return sb.ToString();
        }


        /*
        USE `ww`;
        DROP procedure IF EXISTS `machinesInsert`;
        */
        public static string GetDropIfExistsString(string schema, DbProcedure procedure)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("USE ").Append(schema).Append(";").Append(Environment.NewLine);
            sb.Append("DROP procedure IF EXISTS ").Append(procedure.Name).Append(";").Append(Environment.NewLine);
            return sb.ToString();
        }

        /*
        USE `ww`$$
        CREATE PROCEDURE `machinesInsert`(
            code varchar(45),
            enabled tinyint,
            description varchar(255),
            costPricePerHour decimal,
            sellPricePerHour decimal,
            isStationary tinyint,
            machineTypeId int,
            out lid int
        )
        */
        public static string GetProcedureDefinitionString(string schema, DbProcedure procedure)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("USE ").Append(schema).Append(DELIMITER).Append(Environment.NewLine);
            sb.Append("CREATE PROCEDURE ").Append(procedure.Name).Append(" (").Append(Environment.NewLine);

            int cnt = procedure.ParameterList.Count;
            for (int i = 0; i < cnt; i++)
            {
                DbProcedureParameter p = procedure.ParameterList[i];
                sb.Append("\t").Append(GetDirectionAsStrint(p.Direction));
                sb.Append(p.Name).Append(" ").Append(p.Type);
                if (i < (cnt - 1)) sb.Append(",");
                sb.Append(Environment.NewLine);
            }

            sb.Append(")").Append(Environment.NewLine); ;

            return sb.ToString();
        }

        /*
        BEGIN
	        INSERT INTO machines (
		        code,
		        enabled,
		        description,
		        costPricePerHour,
		        sellPricePerHour,
		        isStationary,
		        machineTypeId)
	         VALUES (
		        code,
		        enabled,
		        description,
		        costPricePerHour,
		        sellPricePerHour,
		        isStationary,
		        machineTypeId);
        
	         SET lid = last_insert_id();
        END$$
        */
        public static string GetBodyInsertAsString(DbTable table)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("BEGIN").Append(Environment.NewLine);

            sb.Append("\t").Append("INSERT INTO ").Append(table.Name).Append("(").Append(Environment.NewLine);
            int cnt = table.Columns.Count;
            for (int i = 0; i < cnt; i++)
            {
                DbColumn c = table.Columns[i];
                if (c.Name.Equals("id")) continue;

                sb.Append("\t\t").Append(c.Name);
                if (i < (cnt - 1)) sb.Append(",");
                else sb.Append(")");
                sb.Append(Environment.NewLine);
            }

            sb.Append("\t").Append("VALUES (").Append(Environment.NewLine);
            for (int i = 0; i < cnt; i++)
            {
                DbColumn c = table.Columns[i];
                if (c.Name.Equals("id")) continue;

                sb.Append("\t\t").Append(c.Name);
                if (i < (cnt - 1)) sb.Append(",");
                else sb.Append(");");
                sb.Append(Environment.NewLine);
            }

            sb.Append("\t").Append("SET lid = last_insert_id();").Append(Environment.NewLine);

            sb.Append("END");

            return sb.ToString();
        }


        /*
            UPDATE 
		        machines
	        SET
		        code = 				code,
		        enabled =			enabled,
		        description = 		description,
		        costPricePerHour = 	costPricePerHour,
		        sellPricePerHour = 	sellPricePerHour,
		        isStationary = 		isStationary,
		        machineTypeId	=	machineTypeId
	        WHERE 
		        id = updateId;
             */
        public static string GetBodyUpdateAsString(DbTable table)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("BEGIN").Append(Environment.NewLine); ;

            sb.Append("\t").Append("UPDATE ").Append(Environment.NewLine);
            sb.Append("\t\t").Append(table.Name).Append(Environment.NewLine);
            sb.Append("\t").Append("SET").Append(Environment.NewLine);
            int cnt = table.Columns.Count;
            for (int i = 0; i < cnt; i++)
            {
                DbColumn c = table.Columns[i];
                if (c.Name.Equals("id")) continue;

                sb.Append("\t\t").Append(c.Name);
                sb.Append(" = ").Append(c.Name);
                if (i < (cnt - 1)) sb.Append(",");
                sb.Append(Environment.NewLine);
            }
            sb.Append("\t").Append("WHERE").Append(Environment.NewLine);
            sb.Append("\t\t").Append("id = updateId;").Append(Environment.NewLine);

            sb.Append("END");

            return sb.ToString();
        }

        public static string GetBodyDeleteAsString(DbTable table)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("BEGIN").Append(Environment.NewLine); ;

            if (!table.IsLinkTable)
            {
                sb.Append("\t").Append("SET @script = concat('DELETE FROM ', tableName, ' WHERE id = ', deleteId);").Append(Environment.NewLine);
                sb.Append("\t").Append("PREPARE stmt FROM @script;").Append(Environment.NewLine);
                sb.Append("\t").Append("EXECUTE stmt;").Append(Environment.NewLine);
                sb.Append("\t").Append("DEALLOCATE PREPARE stmt;").Append(Environment.NewLine);
            }
            else
            {
                sb.Append("\t").Append("DELETE FROM " + table.Name + " WHERE ");

                int cnt = table.ForeignKeys.Count;
                for (int i = 0; i < cnt; i++)
                {
                    DbForeignKey key = table.ForeignKeys[i];

                    if (i > 0) sb.Append(" AND ");
                    sb.Append(Environment.NewLine).Append("\t\t");
                    sb.Append(key.FromColumnName).Append(" = ").Append(key.FromColumnName);
                }
                sb.Append(";").Append(Environment.NewLine);
            }


            sb.Append("END");

            return sb.ToString();
        }

        public static string GetBodySelectAllAsString(DbTable table)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("BEGIN").Append(Environment.NewLine); ;

            sb.Append("\t").Append("SET @script = concat('SELECT * FROM ', tableName);").Append(Environment.NewLine);
            sb.Append("\t").Append("PREPARE stmt FROM @script;").Append(Environment.NewLine);
            sb.Append("\t").Append("EXECUTE stmt;").Append(Environment.NewLine);
            sb.Append("\t").Append("DEALLOCATE PREPARE stmt;").Append(Environment.NewLine);

            sb.Append("END");

            return sb.ToString();
        }

        public static string GetBodySelectByIdAsString(DbTable table)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("BEGIN").Append(Environment.NewLine); ;

            sb.Append("\t").Append("SET @script = concat('SELECT * FROM ', tableName, ' WHERE id = ', selectId);").Append(Environment.NewLine);
            sb.Append("\t").Append("PREPARE stmt FROM @script;").Append(Environment.NewLine);
            sb.Append("\t").Append("EXECUTE stmt;").Append(Environment.NewLine);
            sb.Append("\t").Append("DEALLOCATE PREPARE stmt;").Append(Environment.NewLine);

            sb.Append("END");

            return sb.ToString();
        }

        public static string GetDirectionAsStrint(ParameterDirection direction)
        {
            switch (direction)
            {
                default:
                case ParameterDirection.Input: return "";
                case ParameterDirection.Output: return "OUT ";
                case ParameterDirection.InputOutput: return "INOUT ";
            }
        }



    }
}
