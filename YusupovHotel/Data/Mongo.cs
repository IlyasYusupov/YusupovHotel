using MongoDB.Driver;

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
        public static void AddTypeToDB(String tpye)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<String>("TypesName");
            collection.InsertOne(tpye);

        }

        public static void AddRoomTypeToDB(RoomType room)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<RoomType>("RoomTypes");
            collection.InsertOne(room);
        }

        public static void AddRoomToDB(Rooms room)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Rooms>("Rooms");
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
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static void ReplaceUser(string email, User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(z => z.Email == email, user);
        }


        public static List<string> FindTypes()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<string>("TypesName");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static RoomType GetRoomType(string type)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<RoomType>("RoomTypes");
            var one = collection.Find(x => x.Type == type).FirstOrDefault();
            return one;
        }

        public static List<RoomType> GetAllRoomTypes()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<RoomType>("RoomTypes");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static void ReplaceRoomType(string type, RoomType room)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<RoomType>("RoomTypes");
            collection.ReplaceOne(z => z.Type == type, room);
        }

        public static Rooms GetRoom(int Number)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Rooms>("Rooms");
            var one = collection.Find(x => x.RoomNumber == Number).FirstOrDefault();
            return one;
        }

        public static List<Rooms> GetAllRoom()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Rooms>("Rooms");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static void ReplaceRoom(int Number, Rooms room)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Rooms>("Rooms");
            collection.ReplaceOne(z => z.RoomNumber == Number, room);
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

        public static Booking FindBooking(Client currenrClient, DateOnly arrivalDate, DateOnly departureDate)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Booking>("Bookings");
            var one = collection.Find(x => x.Client == currenrClient && x.ArrivalDate == arrivalDate && x.DepartureDate == departureDate).FirstOrDefault();
            return one;
        }

        public static List<Booking> FindAllBooking()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Booking>("Bookings");
            var list = collection.Find(x => true).ToList();
            list.Reverse();
            return list;
        }

        public static void ReplaceBooking(Client currenrClient, DateOnly arrivalDate, DateOnly departureDate, Booking newBooking)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var collection = database.GetCollection<Booking>("Bookings");
            collection.ReplaceOne(x => x.Client == currenrClient && x.ArrivalDate == arrivalDate && x.DepartureDate == departureDate, newBooking);
        }
    }
}
