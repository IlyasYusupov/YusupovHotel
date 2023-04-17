using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace YusupovHotel.Data
{
    public class Booking
    {
        public Booking(Room room, Client client, DateTime arrivalDate, DateTime departureDate, double totalPrice)
        {
            Room = room;
            Client = client;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
            TotalPrice = totalPrice;
        }
        public Booking( )
        { }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        [Required]
        public Room Room { get; set; }
        [Required]
        public Client Client { get; set; }
        [Required]
        public DateTime ArrivalDate { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        [Required]
        public double? TotalPrice { get; set; }
    }

}
