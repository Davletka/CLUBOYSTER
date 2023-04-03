using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CLUBOYSTER.Data
{
    public class Employee : User
    {
        public string? Role { get; set; }

        public float? Salary { get; set; }

        public DateTime StartWork { get; set; }

        public DateTime EndWork { get; set; }  
    }
}
