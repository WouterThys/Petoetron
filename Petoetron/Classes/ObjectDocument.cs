using Petoetron.Classes.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Classes
{
    public class ObjectDocument : AbstractBaseObject
    {
        public override string TableName { get { return "objectdocuments"; } }

        private string objectName;
        private long objectId;
        private string documentPath;

        public ObjectDocument(string code) : base(code) { }
        public ObjectDocument() : this("") { }

        #region Base Overrides
        public override IObject CreateCopy()
        {
            ObjectDocument od = new ObjectDocument();
            od.CopyFrom(this);
            return od;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy != null)
            {
                base.CopyFrom(toCopy);
                if (toCopy is ObjectDocument od)
                {
                    ObjectName = od.ObjectName;
                    ObjectId = od.ObjectId;
                    DocumentPath = od.DocumentPath;
                }
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (base.PropertiesEqual(iObject))
            {
                if (iObject is ObjectDocument od)
                {
                    return
                        ObjectName == od.ObjectName &&
                        ObjectId == od.ObjectId &&
                        DocumentPath == od.DocumentPath
                        ;
                }
            }

            return false;
        }

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
        }

        #endregion

        #region Properties

        public string ObjectName
        {
            get { return objectName ?? ""; }
            set { objectName = value; }
        }
        
        public long ObjectId
        {
            get { return objectId; }
            set { objectId = value; }
        }
        
        public string DocumentPath
        {
            get { return documentPath; }
            set
            {
                documentPath = value;
                OnPropertyChanged("DocumentPath");
            }
        }

        #endregion
    }
}
