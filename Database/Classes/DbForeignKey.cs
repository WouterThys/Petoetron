using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    [DataContract]
    public class DbForeignKey
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string FromTableName { get; set; }
        [DataMember]
        public string FromColumnName { get; set; }

        [DataMember]
        public string ReferenceTableName { get; set; }
        [DataMember]
        public string ReferenceColumnName { get; set; }
        
        public override bool Equals(object obj)
        {
            var key = obj as DbForeignKey;
            return key != null &&
                   Name == key.Name &&
                   FromTableName == key.FromTableName &&
                   FromColumnName == key.FromColumnName &&
                   ReferenceTableName == key.ReferenceTableName &&
                   ReferenceColumnName == key.ReferenceColumnName;
        }

        public override int GetHashCode()
        {
            var hashCode = -497458394;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FromTableName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FromColumnName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReferenceTableName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReferenceColumnName);
            return hashCode;
        }
        
    }
}
