using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Classes.Helpers
{
   
    /// <summary>
    /// Interface for savable objects
    /// </summary>
    public interface ISave
    {
        void Save();
        void Delete();
    }

    /// <summary>
    /// Interface for Basic object, used to save in database
    /// </summary>
    public interface IObject : IDbObject
    {
        IObject CreateCopy();
        void CopyFrom(IObject iObject);
        bool PropertiesEqual(IObject iObject);
    }

    //public interface ISaveableObject : IObject
    //{
    //    bool CanBeAdded { get; }
    //    bool CanBeEdited { get; }
    //    bool CanBeDeleted { get; }
    //    bool IsSaved { get; }
    //    DateTime LastModified { get; set; }
    //}

    /// <summary>
    /// Interface for Data object
    /// </summary>
    public interface IBaseObject : IObject
    {
        bool Enabled { get; set; }
        string Description { get; set; }
        string Info { get; set; }
        string IconPath { get; set; }
        DateTime LastModified { get; set; }
        
        // Methods
        bool IsUnknown();
        bool IsValid();
    }
}
