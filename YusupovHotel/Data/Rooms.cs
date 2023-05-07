using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace YusupovHotel.Data
{
    public class Rooms
    {
        public Rooms(int roomNumber, string roomType)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
        }

        public Rooms() { }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        [Required(ErrorMessage = "Укажите номер комнаты")]
        [InputNumberValidation(ErrorMessage = "Такой номер уже зарегистрирован")]
        public int? RoomNumber { get; set; }

        [Required(ErrorMessage = "Выберите тип номера")]
        public string RoomType { get; set; }
    }
}
