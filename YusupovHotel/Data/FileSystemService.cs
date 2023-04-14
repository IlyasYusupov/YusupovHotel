using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace YusupovHotel.Data
{
    static public class FileSystemService
    {
        static public async Task UploadFileToDb(string path, string fileName)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("HotelBase");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                gridFS.UploadFromStream(fileName, fs);
            }
            //File.Delete(path);
        }

        public static void SaveRoomPhotos(List<byte[]> fileBytes, Room room)
        {
            room.photos = fileBytes;
            Mongo.AddRoomToDB(room);
        }

        public static Room GetRoomPhotos(Room room)
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
        //static public async Task DownloadToLocal(string webRootPath, Room room)
        //{
        //    //var client = new MongoClient();
        //    //var database = client.GetDatabase("HotelBase");
        //    //var gridFS = new GridFSBucket(database);

        //    //foreach (var img in room.images)
        //    //{
        //    //    using (Stream fs = new FileStream($"{webRootPath}\\{img}", FileMode.Create))
        //    //    {
        //    //        try
        //    //        {
        //    //            await gridFS.DownloadToStreamByName(img.Split("\\")[1], fs);
        //    //        }
        //    //        catch { }
        //    //    }
        //    //}
        //}
    }
}

