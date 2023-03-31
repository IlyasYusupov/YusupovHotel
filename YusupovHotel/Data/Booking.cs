using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace YusupovHotel.Data
{
    public class Booking
    {
        public Booking(int bookingId, Room room, Client client, DateTime arrivalDate, DateTime departureDate, double totalPrice)
        {
            BookingId = bookingId;
            Room = room;
            Client = client;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
            TotalPrice = totalPrice;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        public int BookingId { get; set; }

        public Room Room { get; set; }

        public Client Client { get; set; }

        public DateTime ArrivalDate { get; set; }

        public DateTime DepartureDate { get; set; }

        public double TotalPrice { get; set; }
    }

}
