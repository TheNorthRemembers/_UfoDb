using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;
namespace UfoDB
{
    public static class Mongo
    {
        private static string _server = "server";
        private static string _username = "Username";
        private static int _port = 53597;
        private static string _password = "password";
        private static string _database = "databasename";


        private static MongoCredential _credential
        {
            get
            {
                return MongoCredential.CreateMongoCRCredential(_database, _username, _password);
            }
        }
        public static MongoClientSettings settings
        {
            get
            {
                return new MongoClientSettings
                {
                    Credentials = new[] { _credential },
                    Server = new MongoServerAddress(_server, _port)
                };
            }
        }
    }

}
