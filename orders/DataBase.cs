using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;

namespace orders
{
    //TODO check varibles in mongoInterface
    public class DataBase : DataBaseInterface
    {
        private string connectUrl;
        private string databaseName;
        private string databaseTable;
        MongoClient client;
        IMongoDatabase db;

        public DataBase(string url, string databaseName, string databaseTable)
        {
            this.connectUrl = url;
            this.databaseName = databaseName;
            this.databaseTable = databaseTable;
            Connect();
        }

        private void Connect()
        {
            if (this.connectUrl == null || this.databaseName == null)
                return;
            
            this.client = new MongoClient(this.connectUrl);
            this.db = client.GetDatabase(this.databaseName);
        }

        public IMongoDatabase Get1()
        {
            return this.db;
        }
    }
}
