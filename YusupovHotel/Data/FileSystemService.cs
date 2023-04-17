using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace YusupovHotel.Data
{
    static public class FileSystemService
    {
        public static Room SaveRoomWithPhotos(List<byte[]> fileBytes, Room room)
        {
            room.photos = fileBytes;
            Mongo.AddRoomToDB(room);
            GetRoomWithPhotos(room);
            return room;
        }

        public static Room GetRoomWithPhotos(Room room)
        {
            var newRoom = room;
            newRoom.photosUrl = new();
            for (int i = 0; i < newRoom.photos.Count; i++)
            {
                newRoom.photos[i] = GetImages(Convert.ToBase64String(newRoom.photos[i]));
                newRoom.photosUrl.Add(string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(newRoom.photos[i])));
            }
            return newRoom;
        }

        public static byte[] GetImages(string bas)
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

