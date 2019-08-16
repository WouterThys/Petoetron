using Database;
using Petoetron.Classes.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Dal
{
    public interface IDataList
    {
        string Name { get; }
        bool IsFetched { get; }
        long FetchTime { get; }
        DateTime FetchDate { get; }
        int Count { get; }
        void Clear();
    }

    public interface IDataInvoker
    {
        void InvokeOnMain(Action action);
    }

    public interface INotifyDataChanged
    {
        void NotifyInsert<T>(T item) where T : IObject;
        void NotifyUpdate<T>(T item) where T : IObject;
        void NotifyDelete<T>(T item) where T : IObject;
    }

    public interface IDataChanged<T> where T : IObject
    {
        void OnInserted(T inserted);
        void OnUpdated(T updated);
        void OnDeleted(T deleted);
    }

    public interface IDataAccessCallback
    {
        void DbStateChanged(DbState newState);
        void DbQueryFailed(DbException exception);
    }
}
