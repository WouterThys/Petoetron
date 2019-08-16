using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Petoetron.Models.Base
{
    [POCOViewModel]
    public abstract class BaseDocumentViewModel : BaseViewModel, IDocumentViewModel
    {
        protected BaseDocumentViewModel(IModuleType module) : base(module)
        {
        }

        protected virtual IDocumentManagerService DocumentManagerService { get { throw new NotImplementedException(); } }

        [ServiceProperty(Key = "FloatingDocumentService")]
        protected virtual IDocumentManagerService FloatingDocumentManagerService { get { throw new NotImplementedException(); } }

        protected IDocument CreateDocument(IBaseViewModel viewModel, IDocumentManagerService service)
        {
            IDocument document = service.CreateDocument(viewModel.Module.ViewName, viewModel);
            string title = viewModel.Module.ViewTitle;
            if (!string.IsNullOrEmpty(viewModel.ViewTitle))
            {
                title += " " + viewModel.ViewTitle;
            }
            document.Title = title;
            document.DestroyOnClose = false;
            return document;
        }

        protected virtual IDocument CreateDocument(IModuleType module, IDocumentManagerService service)
        {
            IDocument document = service.CreateDocument(
                module.ViewName,
                module.GetGuid(-1),
                this);
            document.Title = module.ViewTitle;
            document.DestroyOnClose = false;
            return document;
        }


        #region DOCUMENTS
        public IDocument ShowDocument(IBaseViewModel viewModel)
        {
            IDocument document = DocumentManagerService.FindDocumentByIdOrCreate(viewModel.Guid, x => CreateDocument(viewModel, DocumentManagerService));
            document.Show();
            return document;
        }

        public virtual IDocument ShowDocument(IModuleType moduleType)
        {
            IDocument document = DocumentManagerService.FindDocumentByIdOrCreate(moduleType.GetGuid(-1), x => CreateDocument(moduleType, DocumentManagerService));
            document.Show();
            return document;
        }

        public IDocument ShowFloatingDocument(IBaseViewModel viewModel)
        {
            IDocument document = FloatingDocumentManagerService.FindDocumentByIdOrCreate(viewModel.Guid, x => CreateDocument(viewModel, FloatingDocumentManagerService));
            document.Show();
            return document;
        }

        public virtual IDocument ShowFloatingDocument(IModuleType moduleType)
        {
            IDocument document = FloatingDocumentManagerService.FindDocumentByIdOrCreate(moduleType.GetGuid(-1), x => CreateDocument(moduleType, FloatingDocumentManagerService));
            document.Show();
            return document;
        }

        public void CloseDocument(IDocument document)
        {
            if (document != null)
            {
                document.Close(true);
            }
        }

        public void CloseAllDocumnets()
        {
            List<IDocument> openDocs = new List<IDocument>(DocumentManagerService.Documents);
            foreach (IDocument doc in openDocs)
            {
                CloseDocument(doc);
            }
        }

        public void CloseAllFloatingDocumnets()
        {
            List<IDocument> openDocs = new List<IDocument>(FloatingDocumentManagerService.Documents);
            foreach (IDocument doc in openDocs)
            {
                CloseDocument(doc);
            }
        }

        #endregion

        #region DIALOGS
        public void ShowDialog(IBaseViewModel viewModel)
        {
            DialogService.ShowDialog(MessageButton.OKCancel, viewModel.ViewTitle, viewModel.Module.ViewName, viewModel);
        }

        //public virtual IDocument ShowDialog(IModuleType moduleType)
        //{
        //    IDocument document = DocumentManagerService.FindDocumentByIdOrCreate(moduleType.GetGuid(-1), x => CreateDocument(moduleType));
        //    document.Show();
        //    return document;
        //}
        #endregion

        #region DOCUMENT INTERFACE
        public virtual void OnClose(CancelEventArgs e)
        {

        }

        public virtual void OnDestroy()
        {

        }

        public virtual IDocumentOwner DocumentOwner { get; set; }
        public virtual object Title { get { return Module.ViewTitle; } }

        #endregion
    }
}
