using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    [DataContract]
    public class DbProcedureParameter
    {
        [DataMember]
        public string Name { get; set; }
        
        public ParameterDirection Direction { get; set; }

        [DataMember]
        public string Type { get; set; }

        public DbProcedureParameter()
        {

        }

        public DbProcedureParameter(string name, string type, ParameterDirection direction)
        {
            Name = name;
            Type = type;
            Direction = direction;
        }

        public DbProcedureParameter(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                input = input.Trim();
                string[] split = input.Split(' ');
                if (split.Length == 2)
                {
                    Direction = ParameterDirection.Input;
                    Name = split[0];
                    Type = split[1];
                }
                else if (split.Length == 3)
                {
                    switch (split[0].ToUpper())
                    {
                        default:
                        case "IN": Direction = ParameterDirection.Input; break;
                        case "OUT": Direction = ParameterDirection.Output; break;
                        case "INOUT": Direction = ParameterDirection.InputOutput; break;
                    }
                    Name = split[1];
                    Type = split[2];
                }
            }
        }

        public override string ToString()
        {
            return "Parameter: " + Name + " (" + Direction.ToString() + ", " + Type + ")";
        }

        [DataMember]
        public int DirectionAsInt
        {
            get { return (int)Direction; }
            set { Direction = (ParameterDirection)value; }
        }

    }
}
