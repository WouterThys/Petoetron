using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System;
using System.Collections.Generic;

namespace Petoetron.Services
{
    public interface IDataChangedService : INotifyDataChanged
    {
        void AddListener<T>(IDataChanged<T> dataChanged) where T : IObject;
        void RemoveListener<T>(IDataChanged<T> dataChanged) where T : IObject;
        IEnumerable<IDataChanged<T>> GetListeners<T>() where T : IObject;
    }

    public class DataChangedService : IDataChangedService
    {
        private readonly IDictionary<Type, List<object>> listeners = new Dictionary<Type, List<object>>();

        public void AddListener<T>(IDataChanged<T> dataChanged) where T : IObject
        {
            if (dataChanged != null)
            {
                Type t = typeof(T);
                if (!listeners.ContainsKey(t))
                {
                    listeners.Add(t, new List<object>());
                }
                if (!listeners[t].Contains(dataChanged))
                {
                    listeners[t].Add(dataChanged);
                }
            }
        }

        public void RemoveListener<T>(IDataChanged<T> dataChanged) where T : IObject
        {
            if (dataChanged != null)
            {
                Type t = typeof(T);
                if (listeners.ContainsKey(t))
                {
                    listeners[t].Remove(dataChanged);
                }
            }
        }

        private IEnumerable<IDataChanged<T>> GetListeners<T>() where T : IObject
        {
            Type t = typeof(T);
            return listeners.ContainsKey(t) ?
                listeners[t].ConvertAll((x) => (IDataChanged<T>)x) :
                new List<IDataChanged<T>>();
        }

        public void NotifyInsert<T>(T item) where T : IObject
        {
            foreach (IDataChanged<T> listener in GetListeners<T>())
            {
                listener.OnInserted(item);
            }
        }

        public void NotifyUpdate<T>(T item) where T : IObject
        {
            foreach (IDataChanged<T> listener in GetListeners<T>())
            {
                listener.OnUpdated(item);
            }
        }

        public void NotifyDelete<T>(T item) where T : IObject
        {
            foreach (IDataChanged<T> listener in GetListeners<T>())
            {
                listener.OnDeleted(item);
            }
        }

        IEnumerable<IDataChanged<T>> IDataChangedService.GetListeners<T>()
        {
            return new List<IDataChanged<T>>(GetListeners<T>());
        }
    }
}
