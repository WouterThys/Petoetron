using Database.Classes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database
{
    class UpdateManager
    {
        private readonly DatabaseAccess db;
        private List<DbUpdateScript> updateScripts;

        public DbScriptParser ScriptParser { get; } = new DbScriptParser();

        public UpdateManager(DatabaseAccess db)
        {
            this.db = db;
        }

        public void LoadUpdateScripts(params int[] states)
        {
            string sql = "updatescriptsSelectAll";
            if (states == null)
            {
                // Add all states
                List<int> values = new List<int>();
                foreach (UpdateScriptState s in Enum.GetValues(typeof(UpdateScriptState)))
                {
                    values.Add((int)s);
                }
                states = values.ToArray();
            }
            string input = string.Join(",", states);
            updateScripts = new List<DbUpdateScript>(db.Select<DbUpdateScript>(sql, (cmd) =>
            {
                DatabaseAccess.AddDbValue(cmd, "states", input);
            }));
        }

        public void ExecuteScripts(int majorVersion, int minorVersion, int buildVersion, IDatabaseUpdateCallback callback = null)
        {
            if (updateScripts == null) return;
            ExecuteScripts(updateScripts, majorVersion, minorVersion, buildVersion, callback);
        }

        public void ExecuteScripts(IEnumerable<DbUpdateScript> scripts, int majorVersion, int minorVersion, int buildVersion, IDatabaseUpdateCallback callback = null)
        {
            foreach (DbUpdateScript updateScript in scripts)
            {
                if (CheckScript(updateScript, majorVersion, minorVersion, buildVersion))
                {
                    UpdateScript(updateScript, UpdateScriptState.Executing);
                    callback?.DbUpdateCallback("" + updateScript + UpdateScriptState.Executing);
                    
                    try
                    {
                        IEnumerable<string> sqls = updateScript.Script.Split(';');
                        foreach (string sql in sqls)
                        {
                            string cleanSql = ScriptParser.ParseScript(sql);
                            if (!string.IsNullOrEmpty(cleanSql))
                            {
                                db.ExecuteScript(cleanSql);
                            }
                        }
                        UpdateScript(updateScript, UpdateScriptState.Executed);
                        callback?.DbUpdateCallback("" + updateScript + UpdateScriptState.Executed);
                    }
                    catch (Exception e)
                    {
                        UpdateScript(updateScript, e);
                        callback?.DbUpdateCallback("" + updateScript + UpdateScriptState.Failed);
                    }
                }
            }
        }

        public bool CheckScript(DbUpdateScript updateScript, int majorVersion, int minorVersion, int buildVersion)
        {
            if (updateScript == null) return false;
            if (updateScript.State == UpdateScriptState.Executed) return false;
            if (string.IsNullOrEmpty(updateScript.Script)) return false;
        
            if (updateScript.MajorVersion < majorVersion)
            {
                return true;
            }
            if (updateScript.MajorVersion == majorVersion)
            {
                if (updateScript.MinorVersion < minorVersion)
                {
                    return true;
                }
                if (updateScript.MinorVersion == minorVersion)
                {
                    return updateScript.BuildVersion <= buildVersion;
                }
            }
            return false;
        }


        private void UpdateScript(DbUpdateScript script, UpdateScriptState state)
        {
            if (state == UpdateScriptState.Executed)
            {
                script.Executed = DateTime.Now;
            }
            script.State = state;
            UpdateScript(script);
        }

        private void UpdateScript(DbUpdateScript script, Exception exception)
        {
            script.Executed = DateTime.Now;
            script.Message = exception.ToString();
            script.State = UpdateScriptState.Failed;
            UpdateScript(script);
        }

        private void UpdateScript(DbUpdateScript script)
        {
            db.UpdateTask(script);
        }
    }
}
