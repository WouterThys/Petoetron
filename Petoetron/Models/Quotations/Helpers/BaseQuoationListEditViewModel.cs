using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using Petoetron.Models.Base;

namespace Petoetron.Models.Quotations.Helpers
{
    [POCOViewModel]
    public abstract class BaseQuoationListEditViewModel<T, QT> : BaseViewModel
        where T : IBaseObject
        where QT : AbstractQuoationItem, new()
    {
        public virtual Quotation Quotation { get; set; }

        public virtual BindingList<T> Data { get; protected set; }
        public virtual bool ValuesChanged { get; protected set; }
        public virtual BindingList<QT> QData { get; set; }
        public virtual List<QT> Selection { get; set; }

        private readonly Func<IEnumerable<T>> _getData;
        private readonly Func<Quotation, LinkList<QT>> _getQData;
        public Action DataChanged { get; set; }

        protected BaseQuoationListEditViewModel(IModuleType moduleType,
            Func<IEnumerable<T>> _getData,
            Func<Quotation, LinkList<QT>> _getQData) 
            : base(moduleType)
        {
            this._getData = _getData;
            this._getQData = _getQData;
        }

        public override Task Load()
        {
            return null;
        }

        private List<T> ts = null;
        List<QT> qTs = null;
        public void Loading()
        {
            IsLoading = true;
            ValuesChanged = false;
            ts = new List<T>(_getData());
            ts.RemoveAll(t => !t.IsValid());
            qTs = new List<QT>(_getQData(Quotation).Values);
        }

        public void Loaded()
        {
            Data = new BindingList<T>(ts);
            QData = new BindingList<QT>(qTs);
            IsLoading = false;
        }

        public void UpdateCommands()
        {
            this.RaiseCanExecuteChanged(x => x.Add());
            this.RaiseCanExecuteChanged(x => x.Delete());
            this.RaiseCanExecuteChanged(x => x.Zoom());
        }

        public void ValuesHaveChanged()
        {
            ValuesChanged = true;
            DataChanged?.Invoke(); //UpdateCommands();
        }

        public void OnSelectionChanged()
        {
            UpdateCommands();
        }

        public virtual bool CanAdd()
        {
            return !IsLoading && Quotation != null;
        }
        public virtual void Add()
        {
            var qt = new QT
            {
                Quotation = Quotation,
                QuotationId = Quotation.Id,
                Date = DateTime.Now,
                Amount = 1,
                Value = 1
            };

            _getQData(Quotation).Add(qt);
            QData.Add(qt);
            UpdateCommands();
            DataChanged?.Invoke();
        }

        public virtual bool CanDelete()
        {
            return !IsLoading && Quotation != null && Selection != null && Selection.Count > 0;
        }
        public virtual void Delete()
        {
            foreach (QT qt in Selection)
            {
                _getQData(Quotation).Remove(qt);
                QData.Remove(qt);
                UpdateCommands();
                DataChanged?.Invoke();
            }
        }

        public virtual bool CanZoom()
        {
            return !IsLoading && Quotation != null;
        }
        public abstract void Zoom();
        //{
        //    DialogService.ShowDialog(MessageButton.OK, "Muturiuul", this);
        //}
    }
}
