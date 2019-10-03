using Database;
using Petoetron.Dal;
using System.Data.Common;

namespace Petoetron.Classes.Helpers
{
    public class PriceMaterialLink : IDbObject
    {
        public string TableName { get { return "linkpricematerials"; } }

        public long QuotationId { get; set; }
        public long QuotationPriceId { get; set; }
        public long QuotationMaterialId { get; set; }

        public string Code { get; set; }
        public long Id { get { return QuotationPriceId; } set { QuotationPriceId = value; } }
        
        public PriceMaterialLink(long quotationId, long quotationPriceId, long quotationMaterialId)
        {
            QuotationId = quotationId;
            QuotationPriceId = quotationPriceId;
            QuotationMaterialId = quotationMaterialId;
        }

        public string GetScript(ActionType actionType)
        {
            switch(actionType)
            {
                case ActionType.Insert:
                case ActionType.Delete:
                    return TableName + actionType.ToString();
                default:
                    return null;
            }
        }

        public void AddSqlParameters(DbCommand command)
        {
            DatabaseAccess.AddDbValue(command, "quotationId", QuotationId);
            DatabaseAccess.AddDbValue(command, "quotationPriceId", QuotationPriceId);
            DatabaseAccess.AddDbValue(command, "quotationMaterialId", QuotationMaterialId);
        }

        public void InitFromReader(DbDataReader reader)
        {
            QuotationId = DatabaseAccess.RGetLong(reader, "quotationId");
            QuotationPriceId = DatabaseAccess.RGetLong(reader, "quotationPriceId");
            QuotationMaterialId = DatabaseAccess.RGetLong(reader, "quotationMaterialId");
        }

        public bool Save()
        {
            DataAccess.Dal.Insert(this);
            return true;
        }

        public bool Delete()
        {
            return false;
        }

        public void OnChanged(ActionType queryType)
        {
            
        }

        public void OnFailed(Database.DbException dbException)
        {
            
        }
    }
}
