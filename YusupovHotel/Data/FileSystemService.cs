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

        //public static string Save(byte[] fileBytes, Room room)
        //{
        //    room.images = fileBytes;
        //    //return 

        //}

        //public static Room GetRoom(Room room)
        //{
        //    var newRoom = room;
        //    newRoom.images = GetImages(Convert.ToBase64String(newRoom.images));
        //    newRoom.imagesUrl[0] = string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(newRoom.images));
        //    return newRoom;
        //}

        //public static byte[] GetImages(string bas)
        //{
        //    byte[] bytes = null;
        //    if(!string.IsNullOrEmpty(bas))
        //    {
        //        bytes = Convert.FromBase64String(bas);
        //    }
        //    return bytes;
        //}
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

