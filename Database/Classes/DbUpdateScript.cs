using System;
using System.Data.Common;

namespace Database.Classes
{
    public enum UpdateScriptState
    {
        Failed = -1,
        Pending = 0,
        Executing = 1,
        Executed = 2
    }

    public class DbUpdateScript : IDbInstance
    {
        public string TableName { get { return "updatescripts"; } }
        public bool LogAud { get { return false; } }
        public bool Deleted { get { return false; } }

        public long Id { get; set; }
        public int MajorVersion { get; private set; }
        public int MinorVersion { get; private set; }
        public int BuildVersion { get; private set; }
        public string Script { get; private set; }
        public string Description { get; private set; }
        public DateTime Executed { get; set; }
        public int ScriptsProcessed { get; set; }
        public UpdateScriptState State { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return "UpdateScript " + Description + " (" + Id + ")";
        }

        public string GetScript(ActionType actionType)
        {
            return TableName + actionType;
        }

        public void AddSqlParameters(DbCommand command)
        {
            DatabaseAccess.AddDbValue(command, "executed", Executed);
            DatabaseAccess.AddDbValue(command, "scriptsProcessed", ScriptsProcessed);
            DatabaseAccess.AddDbValue(command, "state", (int)State);
            DatabaseAccess.AddDbValue(command, "message", Message);
        }

        public void InitFromReader(DbDataReader reader)
        {
            Id = DatabaseAccess.RGetLong(reader, "id");
            MajorVersion = DatabaseAccess.RGetInt(reader, "majorVersion"); 
            MinorVersion = DatabaseAccess.RGetInt(reader, "minorVersion");
            BuildVersion = DatabaseAccess.RGetInt(reader, "buildVersion");
            Script = DatabaseAccess.RGetString(reader, "script");
            Description = DatabaseAccess.RGetString(reader, "description");
            Executed = DatabaseAccess.RGetDateTime(reader, "executed");
            ScriptsProcessed = DatabaseAccess.RGetInt(reader, "scriptsProcessed");
            State = (UpdateScriptState) DatabaseAccess.RGetInt(reader, "state");
            Message = DatabaseAccess.RGetString(reader, "message");
        }

        public bool Save()
        {
            //throw new NotImplementedException();
            return false;
        }

        public bool Delete()
        {
            //throw new NotImplementedException();
            return false;
        }

        public void OnChanged(ActionType queryType)
        {
            //throw new NotImplementedException();
        }

        public void OnFailed(DbException dbException)
        {
            //throw new NotImplementedException();
        }
    }
}
