using MongoDB.Driver;
using System.Collections.Generic;

namespace YusupovHotel.Data
{
    public class Mongo
    {
        public static void AddUserToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);
        }

        public static void AddRoomToDB(Room room)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Room>("Rooms");
            collection.InsertOne(room);
        }

        public static void AddClientToDB(Client newClient)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Client>("Clients");
            collection.InsertOne(newClient);
        }

        public static void AddBookingToDB(Booking newBooking)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Booking>("Bookings");
            collection.InsertOne(newBooking);
        }

        public static User FindUser(string email)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Email == email).FirstOrDefault();
            return one;
        }

        public static List<User> FindAllUser()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<User>("User");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static void ReplaceUser(string email, User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<User>("User");
            collection.ReplaceOne(z => z.Email == email, user);
        }

        public static Room GetRoom(int number)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Room>("Rooms");
            var one = collection.Find(x => x.Number == number).FirstOrDefault();
            return one;
        }

        public static List<Room> GetAllRooms()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Room>("Rooms");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static void ReplaceRoom(int number, Room room)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Room>("Rooms");
            collection.ReplaceOne(z => z.Number == number, room);
        }

        public static Client FindClient(string email)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Client>("Clients");
            var one = collection.Find(x => x.Email == email).FirstOrDefault();
            return one;
        }

        public static List<Client> FindAllClient()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Client>("Clients");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static void ReplaceClient(string email, Client newClient)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Client>("Clients");
            collection.ReplaceOne(z => z.Email == email, newClient);
        }

        public static Booking FindBooking(int bookingId)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Booking>("Bookings");
            var one = collection.Find(x => x.BookingId == bookingId).FirstOrDefault();
            return one;
        }

        public static List<Booking> FindAllBooking()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Booking>("Bookings");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static void ReplaceBooking(int bookingId, Booking newBooking)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Booking>("Bookings");
            collection.ReplaceOne(z => z.BookingId == bookingId, newBooking);
        }
    }
}
