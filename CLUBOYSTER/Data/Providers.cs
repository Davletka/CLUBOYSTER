using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace CLUBOYSTER.Data
{
    public class Providers
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        [BsonIgnoreIfDefault]
        [Required (ErrorMessage = "Введите имя")]
        public string? FirstName { get; set; }
        [BsonIgnoreIfDefault]

        [Required(ErrorMessage = "Введите Фамилию")]
        public string? SecondName { get; set; }
        [BsonIgnoreIfDefault]

        [Required(ErrorMessage = "Введите Отчество")]
        public string? Surname { get; set; }
        [BsonIgnoreIfDefault]

        [Required(ErrorMessage = "Введите номер телефона")]
        [Phone]
        public string? Phone { get; set; }
        [BsonIgnoreIfDefault]

        [Required(ErrorMessage = "Укажите активен ли договор")]
        public bool? Document { get; set; }
    }
}
