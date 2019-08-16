using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Models
{
    [POCOViewModel]
    public class ObjectLogModel : BaseViewModel
    {
        public static ObjectLogModel Create(IModuleType module, Func<Filter, IEnumerable<ObjectLog>> loadLogs, long objectId)
        {
            return ViewModelSource.Create(() => new ObjectLogModel(module, loadLogs, objectId));
        }

        public static ObjectLogModel Create(IModuleType module, Func<Filter, IEnumerable<ObjectLog>> loadLogs)
        {
            return ViewModelSource.Create(() => new ObjectLogModel(module, loadLogs));
        }

        private readonly Func<Filter, IEnumerable<ObjectLog>> loadLogs;
        private readonly IModuleType logModule;
        private readonly long objectId;

        public virtual BindingList<ObjectLog> ObjectLogs { get; set; }
        public virtual int Limit { get; set; }
        public virtual DateTime From { get; set; }
        public virtual DateTime Till { get; set; }

        protected ObjectLogModel(IModuleType logModule, Func<Filter, IEnumerable<ObjectLog>> loadLogs, long objectId) : base(ModuleTypes.ObjectLogModule)
        {
            this.objectId = objectId;
            this.logModule = logModule;
            this.loadLogs = loadLogs;
            IsLoading = true;
            Limit = 10;
            From = DateTime.Now.AddDays(-10).Date;
            Till = DateTime.Now.Date;
            IsLoading = false;
        }

        protected ObjectLogModel(IModuleType module, Func<Filter, IEnumerable<ObjectLog>> loadLogs) : this(module, loadLogs, -1)
        {

        }

        public override Guid Guid
        {
            get { return logModule.GetGuid(objectId); }
        }

        public override Task Load()
        {
            IsLoading = true;
            return Task.Factory.StartNew((dispatcher) =>
            {
                Filter filter;
                if (objectId > 0)
                {
                    filter = FilterPool.LimitFilter(Limit);
                    filter.AddFilter(new FilterValue("objectId", objectId));
                }
                else
                {
                    filter = FilterPool.BetweenFilter(From, Till);
                }

                List<ObjectLog> logs = new List<ObjectLog>(loadLogs(filter));

                ((IDispatcherService)dispatcher).BeginInvoke(() =>
                {
                    ObjectLogs = new BindingList<ObjectLog>(logs);
                    IsLoading = false;
                });

            }, DispatcherService);
        }

        public virtual void OnFromChanged()
        {
            if (IsLoading) return;
            Load();
        }

        public virtual void OnTillChanged()
        {
            if (IsLoading) return;
            Load();
        }

        public virtual void OnLimitChanged()
        {
            if (IsLoading) return;
            Load();
        }
    }
}
