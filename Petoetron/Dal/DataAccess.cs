using Database;
using Petoetron.Classes;
using Petoetron.Classes.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Petoetron.Dal
{
    public class DataAccess : IDatabaseAccess
    {
        // Singleton
        private static readonly DataAccess INSTANCE = new DataAccess();
        public static DataAccess Dal { get { return INSTANCE; } }

        // Callback
        private IDataAccessCallback callback;

        // Databases
        public DatabaseAccess Db { get; private set; }

        // Cache
        private readonly IDictionary<Type, IDataList> cache;
        private INotifyDataChanged dataListener;
        private IDataInvoker dataInvoker;

        private DataAccess()
        {
            cache = new Dictionary<Type, IDataList>()
            {
                { typeof(Quotation), new DataList<Quotation>(new Quotation().TableName) },
                { typeof(QuotationMaterial), new DataList<QuotationMaterial>(new QuotationMaterial().TableName) },
                { typeof(QuotationPrice), new DataList<QuotationPrice>(new QuotationPrice().TableName) },

                { typeof(Customer), new DataList<Customer>(new Customer().TableName) },
                { typeof(Material), new DataList<Material>(new Material().TableName) },
                { typeof(MaterialType), new DataList<MaterialType>(new MaterialType().TableName) },
                { typeof(PriceType), new DataList<PriceType>(new PriceType().TableName) },
                
                { typeof(Pause), new DataList<Pause>(new Pause().TableName) },
            };
        }
        
        public void AttachDataListener(INotifyDataChanged dataListener)
        {
            this.dataListener = dataListener;
        }

        public void AttachInvoker(IDataInvoker dataInvoker)
        {
            this.dataInvoker = dataInvoker;
        }

        public void AttachCallback(IDataAccessCallback callback)
        {
            this.callback = callback;
        }

        public void InitializeDatabase(
            string provider,
            string server,
            string schema,
            string user,
            string password)
        {
            Db = DatabaseAccess.CreateInstance("DataDb");

            string connectionString = string.Format(DatabaseAccess.ConnectionString_MySQL,
                server,
                schema,
                user,
                password);

            Db.Initialize(this,
                connectionString,
                provider,
                schema);

            Db.Start();
        }

        public void Close()
        {
            if (Db != null)
            {
                Db.CloseDown();
            }
        }

        private DataList<T> GetList<T>(DataList<T> dataList) where T : IObject, new()
        {
            if (!dataList.IsFetched)
            {
                long start = Stopwatch.GetTimestamp();
                IEnumerable<T> values = FetchAll<T>();
                long stop = Stopwatch.GetTimestamp();

                dataList.Set(values, stop - start);
            }
            return dataList;
        }

        #region Database methods
        protected IEnumerable<T> FetchAll<T>() where T : IObject, new()
        {
            return Db.SelectAll<T>();
        }

        public void Insert<T>(T instance) where T : IDbInstance
        {
            Db.Insert(instance);
        }

        public void Update<T>(T instance) where T : IDbInstance
        {
            Db.Update(instance);
        }

        public void Delete<T>(T instance) where T : IDbInstance
        {
            Db.Delete(instance);
        }

        #endregion

        #region Cache methods


        protected DataList<T> GetCachedList<T>() where T : IObject
        {
            cache.TryGetValue(typeof(T), out IDataList list);
            return list as DataList<T>;
        }

        public bool CodeExists<T>(string code) where T : IObject
        {
            DataList<T> dataList = GetCachedList<T>();
            return dataList != null && dataList.ByCode(code) != null;
        }

        public void OnInserted<T>(T obj) where T : IObject
        {
            if (dataInvoker != null)
            {
                dataInvoker.InvokeOnMain(() => DoInsert(obj));
            }
            else
            {
                DoInsert(obj);
            }
        }

        protected void DoInsert<T>(T obj) where T : IObject
        {
            DataList<T> list = GetCachedList<T>();
            if (list != null)
            {
                if (list.Add(obj))
                {
                    dataListener?.NotifyInsert(obj);
                }
            }
            else
            {
                dataListener?.NotifyInsert(obj);
            }
        }

        public void OnUpdated<T>(T obj) where T : IObject
        {
            if (dataInvoker != null)
            {
                dataInvoker.InvokeOnMain(() => DoUpdate(obj));
            }
            else
            {
                DoUpdate(obj);
            }
        }

        protected void DoUpdate<T>(T obj) where T : IObject
        {
            DataList<T> list = GetCachedList<T>();
            if (list != null)
            {
                if (list.Update(obj))
                {
                    dataListener?.NotifyUpdate(obj);
                }
            }
            else
            {
                dataListener?.NotifyUpdate(obj);
            }
        }

        public void OnDeleted<T>(T obj) where T : IObject
        {
            if (dataInvoker != null)
            {
                dataInvoker.InvokeOnMain(() => DoDelete(obj));
            }
            else
            {
                DoDelete(obj);
            }
        }

        protected void DoDelete<T>(T obj) where T : IObject
        {
            DataList<T> list = GetCachedList<T>();
            if (list != null)
            {
                if (list.Remove(obj))
                {
                    dataListener?.NotifyDelete(obj);
                }
            }
            else
            {
                dataListener?.NotifyDelete(obj);
            }
        }

        #endregion

        #region IDatabaseAccess Interface
        public void DbLogBackState(DbState dbState)
        {
            callback?.DbStateChanged(dbState);
        }

        public void DbQueryFailed(DbException dbException)
        {
            callback?.DbQueryFailed(dbException);
        }

        public void DbLogInfo(string message)
        {
        }
        #endregion

        public DataList<Quotation> Quotations { get { return GetList(GetCachedList<Quotation>()); } }
        public DataList<QuotationMaterial> QuotationMaterials { get { return GetList(GetCachedList<QuotationMaterial>()); } }
        public DataList<QuotationPrice> QuotationPrices { get { return GetList(GetCachedList<QuotationPrice>()); } }

        public DataList<Customer> Customers { get { return GetList(GetCachedList<Customer>()); } }
        public DataList<Material> Materials { get { return GetList(GetCachedList<Material>()); } }
        public DataList<MaterialType> MaterialTypes { get { return GetList(GetCachedList<MaterialType>()); } }
        public DataList<PriceType> PriceTypes { get { return GetList(GetCachedList<PriceType>()); } }
        
        public DataList<Pause> Pauses { get { return GetList(GetCachedList<Pause>()); } }


        public IEnumerable<ObjectLog> GetObjectLogs<T>(Filter filter) where T : class, IBaseObject, new()
        {
            return new List<ObjectLog>();//throw new NotImplementedException(); // Fetch from db
        }

        public IEnumerable<long> FindMaterialsIdsForQuotation(long id)
        {
            string sql = "quotationsFindMaterials";
            IEnumerable<long> ids = Db.FindIds(sql, (cmd) => DatabaseAccess.AddDbValue(cmd, "qId", id));
            return ids;
        }

        public IEnumerable<long> FindPricesIdsForQuotation(long id)
        {
            string sql = "quotationsFindPrices";
            IEnumerable<long> ids = Db.FindIds(sql, (cmd) => DatabaseAccess.AddDbValue(cmd, "qId", id));
            return ids;
        }
    }
}
