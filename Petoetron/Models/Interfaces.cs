using DevExpress.Mvvm;
using Petoetron.Classes;
using Petoetron.Classes.Helpers;
using Petoetron.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Models
{
    public interface IModuleType
    {
        string ViewName { get; }
        string ViewTitle { get; }
        long Id { get; }
        Guid GetGuid(long id);
        int ImageId { get; }
    }

    public interface IBaseViewModel
    {
        ClientContext Context { get; }
        IModuleType Module { get; }
        Guid Guid { get; }
        string ViewTitle { get; }

        bool IsLoading { get; set; }
        Task Load();
        
        IMessageBoxService MessageBoxService { get; }
        IDialogService DialogService { get; }
        IDispatcherService DispatcherService { get; }
        IDataChangedService DataChangedService { get; }
    }

    public interface IDocumentViewModel : IDocumentContent
    {
        IDocument ShowDocument(IModuleType moduleType);
        IDocument ShowDocument(IBaseViewModel viewModel);
    }

    public interface IBaseListViewModel<TEntity> : IBaseViewModel
        where TEntity : IObject, new()
    {
        IModuleType EditModule { get; }
        BindingList<TEntity> Entities { get; set; }
        TEntity Selected { get; set; }
        List<TEntity> Selection { get; set; }

        void OnSelectionChanged();
        void UpdateCommands();
        IBaseViewModel GetEditViewModel(TEntity baseObject);
        IEnumerable<TEntity> DataSource();

        bool CanPause(Pause pause);
        void Pause(Pause pause);

        bool CanAdd();
        void Add();

        bool CanEdit(TEntity entity);
        void Edit(TEntity entity);

        bool CanDelete(IList<TEntity> entity);
        void Delete(IList<TEntity> entities);

        bool CanCopy(TEntity entity);
        void Copy(TEntity entity);

        bool CanPrintList();
        void PrintList();

        bool CanImportList();
        void ImportList();

        bool CanExportList();
        void ExportList();
    }

    public interface IBaseEditViewModel<TEntity> : IBaseViewModel
    where TEntity : class, IObject
    {
        TEntity Original { get; }
        TEntity Editable { get; }
        bool IsSaving { get; }

        void UpdateCommands();

        bool CanPause(Pause pause);
        void Pause(Pause pause);

        bool CanEditCode();
        bool CanClose();

        bool CanSave();
        void Save();

        bool CanSaveAndDone();
        void SaveAndDone();

        bool CanReset();
        void Reset();

        bool CanDelete();
        void Delete();

        bool CanCopy();
        void Copy();
    }
}
