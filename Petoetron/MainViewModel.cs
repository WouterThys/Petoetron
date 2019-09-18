using Database;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using Petoetron.Dal;
using Petoetron.Models;
using Petoetron.Models.Base;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Petoetron
{
    [POCOViewModel()]
    public class MainViewModel : BaseDocumentViewModel, IDataInvoker, IDataAccessCallback
    {

        public virtual IModuleType ActiveModule { get; set; }

        // Extra
        public virtual DbState DatabaseState { get; protected set; }

        protected MainViewModel() : base(ModuleTypes.MainViewModule)
        {
            
        }

        public override Task Load()
        {
            IsLoading = true;
            return Task.Factory.StartNew((dispatcher) => 
            {
                // Settings
                Context.Initialize();

                // Database
                DataAccess.Dal.AttachDataListener(DataChangedService);
                DataAccess.Dal.AttachInvoker(this);
                DataAccess.Dal.AttachCallback(this);
                DataAccess.Dal.InitializeDatabase(
                    Context.DbProvider,
                    Context.DbServer,
                    Context.DbSchema,
                    Context.DbUser,
                    Context.DbPassword);
                
                //

                ((IDispatcherService)dispatcher).BeginInvoke(() => 
                {
                    DocumentManagerService.ActiveDocumentChanged += DocumentManagerService_ActiveDocumentChanged;
                    ShowDocument(ModuleTypes.QuotationListModule);
                    IsLoading = false;
                });
            }, DispatcherService);
        }


        private void DocumentManagerService_ActiveDocumentChanged(object sender, ActiveDocumentChangedEventArgs e)
        {
            if (e.NewDocument == null)
            {
                ActiveModule = null;
            }
            else if (e.NewDocument.Content is IBaseViewModel viewModel)
            {
                ActiveModule = viewModel.Module;
            }
        }

        public void OnActiveModuleChanged()
        {
            if (ActiveModule != null)
            {
                ShowDocument(ActiveModule);
            }
        }

        public override void OnClose(CancelEventArgs e)
        {
            base.OnClose(e);
            if (!e.Cancel)
            {
                DataAccess.Dal.Close();
            }
        }

        #region IDataInvoker Interface
        public void InvokeOnMain(Action action)
        {
            DispatcherService.BeginInvoke(action);
        }
        #endregion

        #region IDataAccessCallback Interface
        public void DbStateChanged(DbState newState)
        {
            DatabaseState = newState;
        }

        public void DbQueryFailed(DbException exception)
        {
            MessageBoxService.ShowMessage("Tgu ni guu mu du dutubuse: " + exception, "Fuck", MessageButton.OK, MessageIcon.Error);
        }
        #endregion
    }
}
