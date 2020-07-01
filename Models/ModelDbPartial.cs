using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class ModelDb
    {
        public ModelDb(string nameOrConnectionString) : base(nameOrConnectionString)
        {

        }
        public static ModelDb Create()
        {
            return new ModelDb();
        }
        public static ModelDb Create(string providerConnectionString)
        {
            var entityBuilder = new EntityConnectionStringBuilder();

            // use your ADO.NET connection string
            entityBuilder.ProviderConnectionString = providerConnectionString;

            entityBuilder.Provider = "System.Data.SqlClient";

            // Set the Metadata location. metadata=res://*/ModelDb.csdl|res://*/ModelDb.ssdl|res://*/ModelDb.msl
            entityBuilder.Metadata = @"res://*/ModelDb.csdl|res://*/ModelDb.ssdl|res://*/ModelDb.msl";

            return new ModelDb(entityBuilder.ConnectionString);
        }
        public static void SetConnection(string connection,string userName,string password)
        {
           
        }
    }
}
