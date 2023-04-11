using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CLUBOYSTER.Data
{
    public class Transactions
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        [BsonIgnoreIfDefault]
        public string? Type { get; set; }
        [BsonIgnoreIfDefault]
        public DateTime? Time { get; set; }
        [BsonIgnoreIfDefault]

        public  User? User { get; set; }
        [BsonIgnoreIfDefault]

        public float? Sum { get; set; }
    }
}
