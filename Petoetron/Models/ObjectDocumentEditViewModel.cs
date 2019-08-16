using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Classes.Helpers;
using Petoetron.Models.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Models
{
    [POCOViewModel]
    public class ObjectDocumentEditViewModel : BaseEditViewModel<ObjectDocument>
    {
        public static ObjectDocumentEditViewModel Create(ObjectDocument original, IBaseObject obj)
        {
            return ViewModelSource.Create(() => new ObjectDocumentEditViewModel(original, obj));
        }

        public virtual IBaseObject DocumentsObject { get; set; }
        public virtual string DocumentPath { get; set; }

        protected ObjectDocumentEditViewModel(ObjectDocument original, IBaseObject obj) : base(ModuleTypes.ObjectDocumentEditModule, original)
        {
            DocumentsObject = obj;
            Load();
        }

        public override string ViewTitle
        {
            get { return ""; }
        }

        public override void OnLoaded()
        {
            base.OnLoaded();
            if (Editable != null)
            {
                DocumentPath = Editable.DocumentPath;
            }
        }

        public void OnDocumentPathChanged()
        {
            UpdateCommands();
        }

        public override bool CanSave()
        {
            bool res = base.CanSave();
            if (res)
            {
                string path = DocumentPath;
                res = !string.IsNullOrEmpty(path) && File.Exists(path);
            }
            return res;
        }

        protected override void BeforeSave(ObjectDocument editable)
        {
            base.BeforeSave(editable);
            if (!string.IsNullOrEmpty(DocumentPath))
            {
                if (!DocumentPath.Equals(editable.DocumentPath))
                {
                    string dir = Path.Combine(DocumentsObject.TableName, "Documents");
                    string name = Guid.NewGuid().ToString() + Path.GetExtension(DocumentPath);
                    string fileName = Path.Combine(dir, name);
                    editable.DocumentPath = fileName;

                    Tuple<string, string> saveData = new Tuple<string, string>(DocumentPath, fileName);

                    Task.Factory.StartNew((d) =>
                    {
                        Tuple<string, string> data = (Tuple<string, string>)d;
                        string file = data.Item1;
                        string path = data.Item2;

                        // TODO: save file

                    }, saveData);
                }
            }
            else
            {
                editable.DocumentPath = ""; // This should never happen?
            }
        }
}
}
