using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    public class DbScriptParser
    {
        private IDictionary<string, object> replacements = new Dictionary<string, object>();

        public DbScriptParser()
        {

        }

        public void Clear()
        {
            replacements.Clear();
        }

        public void AddParseValue(string replace, object with)
        {
            if (!string.IsNullOrEmpty(replace) && with != null)
            {
                replacements.Add(replace, with);
            }
        }

        public void RemoveParseValue(string replace)
        {
            if (!string.IsNullOrEmpty(replace))
            {
                replacements.Remove(replace);
            }
        }

        public string ParseScript(string script)
        {
            string parsed = script;
            foreach (string val in replacements.Keys)
            {
                string with = replacements[val].ToString();
                parsed = parsed.Replace(val, with);
            }
            return parsed.Trim();
        }
    }
}
