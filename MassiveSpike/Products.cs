using Massive;

namespace MassiveSpike
{
    public class Products : DynamicModel
    {
        public Products() : base("MassiveSpike")
        {
            PrimaryKeyField = "ProductId";
            TableName = "Products";
        }
        
        public Products(string connectionStringName, string tableName, string primaryKeyField, string descriptorField) 
            : base(connectionStringName, tableName, primaryKeyField, descriptorField)
        {
        }
    }
}