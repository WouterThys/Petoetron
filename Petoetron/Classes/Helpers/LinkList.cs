﻿using System.Collections.Generic;
using System.Linq;

namespace Petoetron.Classes.Helpers
{
    public abstract class LinkList<T> where T : IObject
    {
        private static int listCnt = 0;
        private int ListId { get; set; }
        public long ObjectId { get; set; }

        protected HashSet<long> ids;
        protected HashSet<T> values;

        public LinkList(long objectId)
        {
            ListId = ++listCnt;
            ObjectId = objectId;
        }

        protected abstract IEnumerable<long> GetIds(long id);
        protected abstract T GetById(long id);
        public abstract LinkList<T> CreateCopy();

        public void CopyFrom(LinkList<T> linkList)
        {
            ObjectId = linkList.ObjectId;
            Ids = new HashSet<long>(linkList.Ids);
        }

        public override string ToString()
        {
            return "Linked list " + ListId + " ids=" + string.Join(",", ids);
        }

        public override bool Equals(object obj)
        {
            bool equal = obj is LinkList<T> list &&
                   ObjectId == list.ObjectId &&
                   Ids.SetEquals(list.Ids);
            if (equal && Values != null && obj is LinkList<T> l)
            {
                equal = values.SetEquals(l.Values);
                if (equal)
                {
                    foreach(T t in values)
                    {
                        T found = l.values.FirstOrDefault(v => v.Id == t.Id);
                        if (found == null) return false;
                        if (!found.PropertiesEqual(t))
                        {
                            return false;
                        }
                    }
                }
            }
            return equal;
        }

        public override int GetHashCode()
        {
            var hashCode = -2099011464;
            hashCode = hashCode * -1521134295 + ObjectId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<HashSet<long>>.Default.GetHashCode(ids);
            return hashCode;
        }

        public virtual IEnumerable<T> Values
        {
            get
            {
                if (values == null && Ids != null)
                {
                    values = new HashSet<T>();
                    foreach (long id in ids)
                    {
                        T t = GetById(id);
                        if (t != null) values.Add(t);
                    }
                }
                return values;
            }
            protected set
            {
                values = new HashSet<T>(value);
            }
        }

        public HashSet<long> Ids
        {
            get
            {
                if (ids == null)
                {
                    ids = new HashSet<long>();
                    if (ObjectId > AbstractObject.UNKNOWN_ID)
                    {
                        ids.UnionWith(GetIds(ObjectId));
                    }
                    values = null;
                }
                return ids;
            }
            set
            {
                ids = value;
                values = null;
            }
        }

        public void Set(IEnumerable<T> items)
        {
            if (items != null)
            {
                values = new HashSet<T>(items);
                ids = new HashSet<long>(items.Select(i => i.Id));
            }
            else
            {
                Ids = new HashSet<long>();
            }
        }

        public void UpdateValues()
        {
            values = null;
        }

        public void Add(T item)
        {
            if (item != null && Values != null)
            {
                ids.Add(item.Id);
                values.Add(item);
            }
        }

        public void Remove(T item)
        {
            if (item != null && Values != null)
            {
                ids.Remove(item.Id);
                values.Remove(item);
            }
        }

        public bool Contains(long id)
        {
            return Ids.Contains(id);
        }

        public bool Contains(T item)
        {
            return item != null && Contains(item.Id);
        }

        public int Count
        {
            get { return Ids.Count; }
        }

        public void UpdateValues(IEnumerable<T> newValues)
        {
            Ids.Clear();
            if (newValues != null)
            {
                foreach (T t in newValues)
                {
                    Ids.Add(t.Id);
                }
            }
            UpdateValues();
        }
    }
}