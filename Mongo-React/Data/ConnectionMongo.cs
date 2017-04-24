using Data.Properties;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ConnectionMongo
    {
        public MongoClient conn;
        public MongoServer server;
        public MongoDatabase mongodb;
        public ConnectionMongo()
        {

            conn = new MongoClient(Settings.Default.ConnectionMongo);
            server = conn.GetServer();
            mongodb = server.GetDatabase(Settings.Default.DbMongoName);
        }

        
    }
}
