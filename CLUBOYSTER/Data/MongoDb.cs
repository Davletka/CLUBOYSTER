using MongoDB.Driver;

namespace CLUBOYSTER.Data
{
    public class MongoDb
    {
        public static void AddDb(User user)
        {
            var client = new MongoClient();
            var dataBase = client.GetDatabase("ClubOyzer");
            var collection = dataBase.GetCollection<User>("Users");
            collection.InsertOne(user);
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
    }
}
