using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Helpers
{
    
    /// <summary>
    /// Interface for classes with and Id 
    /// </summary>
    public interface IId
    {
        long Id { get; set; }
    }

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
    public interface IObject : IId
    {
        string TableName { get; }
        string Code { get; set; }

        IObject CreateCopy();
        void CopyFrom(IObject iObject);
        bool PropertiesEqual(IObject iObject);
    }

    /// <summary>
    /// Interface for Data object
    /// </summary>
    public interface IBaseObject : IObject
    {
        bool Enabled { get; set; }
        string Description { get; set; }
        string Info { get; set; }
        string IconPath { get; set; }
        
        // Methods
        bool IsUnknown();
        bool IsValid();
    }
}
