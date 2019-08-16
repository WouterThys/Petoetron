using System.Collections.Generic;

namespace Petoetron.Classes.Helpers
{
    public abstract class LinkList<T> where T : IBaseObject
    {
        public long ObjectId { get; set; }

        protected HashSet<long> ids;
        protected HashSet<T> values;

        public LinkList(long objectId)
        {
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
            return "Linked list " + typeof(T) + "ids=" + ids;
        }

        public override bool Equals(object obj)
        {
            return obj is LinkList<T> list &&
                   ObjectId == list.ObjectId &&
                   Ids.SetEquals(list.Ids);
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

        public void UpdateValues()
        {
            values = null;
        }

        public void Add(T item)
        {
            if (item != null && item.IsValid() && Values != null)
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