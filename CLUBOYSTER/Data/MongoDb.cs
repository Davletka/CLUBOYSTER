using Amazon.Util;
using MongoDB.Bson;
using MongoDB.Driver.GridFS;
using MongoDB.Driver;

namespace CLUBOYSTER.Data
{
    public class MongoDb
    {
        public static void Reports()
        {
            var client = new MongoClient();
            var dataBase = client.GetDatabase("ClubOyzer");
            GridFSBucket bucket = new GridFSBucket(dataBase);
        }
        public static void AddDb(User user)
        {
            var client = new MongoClient();
            var dataBase = client.GetDatabase("ClubOyzer");
            var collection = dataBase.GetCollection<User>("Users");
            collection.InsertOne(user);
        }

        public static void AddTransaction(Transactions transaction)
        {
            var client = new MongoClient();
            var dataBase = client.GetDatabase("ClubOyzer");
            var collection = dataBase.GetCollection<Transactions>("Transactions");
            collection.InsertOne(transaction);
        }

        public static List<User> FindUsers()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();

            return list;
        }

        public static void ReplaceByName(User member, string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Login == member.Login, member);
        }

        public static void AddProvider(Providers provider)
        {
            var client = new MongoClient();
            var dataBase = client.GetDatabase("ClubOyzer");
            var collection = dataBase.GetCollection<Providers>("Providers");
            collection.InsertOne(provider);
        }

        public static List<Providers> FindProviders()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var collection = database.GetCollection<Providers>("Providers");
            var list = collection.Find(x => true).ToList();

            return list;
        }

        public static List<Transactions> FindOperations()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var collection = database.GetCollection<Transactions>("Transactions");
            var list = collection.Find(x => true).ToList();

            return list;
        }

        public static User FindOwner()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => x.Login == "Davletka").FirstOrDefault();

            return list;
        }


        public static void ReplaceOwner(User member)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Login == "Davletka", member);
        }

        public static List<string> FindReports()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var collection = database.GetCollection<string>("fs.files");
            var list = collection.Find(x => true).ToList();

            return list;
        }
    }
}
