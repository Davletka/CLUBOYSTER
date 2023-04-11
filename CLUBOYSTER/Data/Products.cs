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

        public string? Name { get; set; }
        
        public int? Count { get; set; }

        public float? Sum { get; set; }

        public Providers? provider { get; set; }
    }
}
