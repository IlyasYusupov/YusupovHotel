using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace YusupovHotel.Data
{
    public class Booking
    {
        public Booking(Room room, Client client, int adaltCount, int childCount, DateOnly arrivalDate, DateOnly departureDate, double totalPrice)
        {
            Room = room;
            Client = client;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
            TotalPrice = totalPrice;
            AdaltCount = adaltCount;
            ChildCount = childCount;
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
        public int AdaltCount { get; set; }
        [Required]
        public int ChildCount { get; set; }

        [Required]
        public DateOnly ArrivalDate { get; set; }
        [Required]
        public DateOnly DepartureDate { get; set; }
        [Required]
        public double? TotalPrice { get; set; }
    }

}
