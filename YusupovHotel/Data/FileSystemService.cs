using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace YusupovHotel.Data
{
    static public class FileSystemService
    {
        public static RoomType SaveRoomWithPhotos(List<byte[]> fileBytes, RoomType room)
        {
            room.photos = fileBytes;
            Mongo.AddRoomTypeToDB(room);
            GetRoomWithPhotos(room);
            return room;
        }

        public static RoomType GetRoomWithPhotos(RoomType room)
        {
            var newRoom = room;
            newRoom.photosUrl = new();
            for (int i = 0; i < newRoom.photos.Count; i++)
            {
                newRoom.photos[i] = GetImage(Convert.ToBase64String(newRoom.photos[i]));
                newRoom.photosUrl.Add(string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(newRoom.photos[i])));
            }
            return newRoom;
        }

        public static User SaveUserWithPhoto(byte[] fileBytes, User user)
        {
            user.Photo = fileBytes;
            Mongo.ReplaceUser(user.Email, user);
            GetUserWithPhoto(user);
            return user;
        }

        public static User GetUserWithPhoto(User user)
        {
            var newUser = Mongo.FindUser(user.Email);
            newUser.PhotoUrl = null;
            newUser.Photo = GetImage(Convert.ToBase64String(newUser.Photo));
            newUser.PhotoUrl = string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(newUser.Photo));
            return newUser;
        }

        public static byte[] GetImage(string bas)
        {
            byte[] bytes = null;
            if (!string.IsNullOrEmpty(bas))
            {
                bytes = Convert.FromBase64String(bas);
            }
            return bytes;
        }
    }
}

