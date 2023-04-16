using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver.Core.Operations;

namespace CLUBOYSTER.Data
{
    public class Products
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        [BsonIgnoreIfDefault]
        public string? Name { get; set; }
        [BsonIgnoreIfDefault]

        public float? Sum { get; set; }
    }
}
