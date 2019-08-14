using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    [DataContract]
    public class DbColumn
    {
        [DataMember]
        public string TableName { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Ordinal { get; set; }
        [DataMember]
        public string ColumnType { get; set; }

        private DbTable table;
        private DbForeignKey foreignKey;

        public DbColumn(DbTable table)
        {
            TableName = table.Name;
        }

        public override string ToString()
        {
            return "Column: " + Name + " (" + ColumnType + ")";
        }

        public override bool Equals(object obj)
        {
            return obj is DbColumn column &&
                   TableName == column.TableName &&
                   Name == column.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = -682732195;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TableName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        public void SetTable(DbTable table)
        {
            this.table = table;
        }

        public void SetForeignKey(DbForeignKey foreignKey)
        {
            this.foreignKey = foreignKey;
        }

        public bool IsLinkColumn
        {
            get { return foreignKey != null; }
        }
    }
}
