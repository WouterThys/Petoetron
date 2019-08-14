using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    [DataContract]
    public class DbProcedure
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Body { get; set; }
        [DataMember]
        public List<DbProcedureParameter> ParameterList { get; set; }
        [DataMember]
        public List<DbProcedureParameter> ReturnList { get; set; }

        public DbProcedure()
        {
            ParameterList = new List<DbProcedureParameter>();
            ReturnList = new List<DbProcedureParameter>();
        }

        public override string ToString()
        {
            return "Procedure: " + Name;
        }
        
        public ActionType GetActionType()
        {
            foreach (ActionType type in Enum.GetValues(typeof(ActionType)))
            {
                if (Name.ToUpper().EndsWith(type.ToString().ToUpper()))
                {
                    return type;
                }
            }
            return ActionType.Unknown;
        }

        public string PrettyBody
        {
            get
            {
                if (!string.IsNullOrEmpty(Body))
                {
                    return Body.Replace("\n", Environment.NewLine);
                }
                return "";
            }
        }

        public string ObjectName
        {
            get
            {
                if (!string.IsNullOrEmpty(Name))
                {
                    return Name.Replace(ActionType.ToString(), "");
                }
                return "";
            }
        }

        public ActionType ActionType
        {
            get
            {
                if (!string.IsNullOrEmpty(Name))
                {
                    foreach (ActionType type in Enum.GetValues(typeof(ActionType)))
                    {
                        if (Name.ToUpper().Contains(type.ToString().ToUpper()))
                        {
                            return type;
                        }
                    }
                }
                return ActionType.Unknown;
            }
        }

    }
}
