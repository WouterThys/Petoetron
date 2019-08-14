using Petoetron.Classes.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Dal
{
    public class DataList<T> : IDataList, IEnumerable<T> where T : IObject
    {
        public static readonly string TAG = "DataList";

        private readonly object locker = new object();
        private readonly Dictionary<long, T> dictionary = new Dictionary<long, T>();

        public string Name { get; protected set; }
        public bool IsFetched { get; protected set; }
        public bool NeedsFetch { get; protected set; }
        public long FetchTime { get; protected set; }
        public DateTime FetchDate { get; protected set; }
        public int Count { get; protected set; }

        // Enumerable
        public IEnumerator<T> GetEnumerator() { return dictionary.Values.GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

        //public DataList(string name)
        //{
        //    Name = name;
        //    NeedsFetch = true;
        //}

        public DataList(string name)
        {
            Name = name;
            NeedsFetch = true;
        }

        public override string ToString()
        {
            string result = Name + " ";
            if (IsFetched)
            {
                result += "\tFetched " + dictionary.Count + " \t{" + FetchDate + " - " + new TimeSpan(FetchTime) + "ns}";
            }
            else
            {
                result += "Not fetched";
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !(obj is DataList<T>)) return false;
            DataList<T> dl = (DataList<T>)obj;
            return dl.GetIds().SetEquals(GetIds());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public DataList<T> CreateCopy()
        {
            DataList<T> copy = new DataList<T>(Name);
            lock (locker)
            {
                copy.Set(dictionary.Values, FetchTime);
                copy.FetchDate = FetchDate;
            }
            return copy;
        }

        internal void Set(IEnumerable<T> items)
        {
            Set(items, 0);
        }

        internal void Set(IEnumerable<T> items, long timeInNanos)
        {
            lock (locker)
            {
                Clear();

                if (items != null)
                {
                    foreach (T t in items)
                    {
                        dictionary.Add(t.Id, t);
                    }

                    IsFetched = true;
                    FetchDate = DateTime.Now;
                    FetchTime = timeInNanos;
                    Count = dictionary.Count;

                    //double us = (double)FetchTime / 1000;
                    //Logger.Log.Information(TAG, "" + Count + " " + Name + " loaded  in " + string.Format("{0:0.00}", us) + "us");
                }
            }
        }

        public HashSet<long> GetIds()
        {
            lock (locker)
            {
                return new HashSet<long>(dictionary.Keys);
            }
        }

        public T ById(long id)
        {
            lock (locker)
            {
                dictionary.TryGetValue(id, out T t);
                return t;
            }
        }

        public List<T> ByIds(IEnumerable<long> ids)
        {
            List<T> ts = new List<T>();
            lock (locker)
            {
                foreach (long id in ids)
                {
                    ts.Add(ById(id));
                }
            }
            return ts;
        }

        public T ByCode(string code)
        {
            lock (locker)
            {
                return dictionary.Values.FirstOrDefault(t => t.Code.Equals(code));
            }
        }

        public IEnumerable<T> GetAll()
        {
            return dictionary.Values;
        }

        public void Clear()
        {
            dictionary.Clear();
            Count = 0;
            IsFetched = false;
        }

        public bool Add(T item)
        {
            if (NeedsFetch && !IsFetched) return false;
            if (item == null) return false;

            lock (locker)
            {
                if (dictionary.ContainsKey(item.Id)) return false;

                dictionary.Add(item.Id, item);
                Count = dictionary.Count;
            }
            return true;
        }

        internal bool AddAll(IEnumerable<T> items)
        {
            if (NeedsFetch && !IsFetched) return false;
            if (items == null) return false;

            lock (locker)
            {
                foreach (T t in items)
                {
                    Add(t);
                }
            }

            return true;
        }

        public bool Update(T item)
        {
            if (NeedsFetch && !IsFetched) return false;
            if (item == null) return false;

            lock (locker)
            {
                if (!dictionary.ContainsKey(item.Id)) return false;

                dictionary[item.Id].CopyFrom(item);
                Count = dictionary.Count;
            }
            return true;
        }

        public bool Remove(T item)
        {
            if (NeedsFetch && !IsFetched) return false;
            if (item == null) return false;
            lock (locker)
            {
                if (dictionary.Remove(item.Id))
                {
                    Count = dictionary.Count;
                    return true;
                }
            }
            return false;
        }

        internal bool Remove(long id)
        {
            return Remove(ById(id));
        }
    }
}
