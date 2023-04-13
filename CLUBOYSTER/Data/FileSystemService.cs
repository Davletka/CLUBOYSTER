using Microsoft.AspNetCore.Components.Forms;
using MongoDB.Driver.GridFS;
using MongoDB.Driver;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace CLUBOYSTER.Data
{
    public class FileSystemService
    {
        public void UploadToDb(string text, string NameReport)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Reports/")}{NameReport}.txt", FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                fs.Write(buffer, 0, buffer.Length);
            }

            using (FileStream fs = new FileStream($"Reports/{NameReport}.txt", FileMode.Open))
            {
                gridFS.UploadFromStream($"{NameReport}.txt", fs);
            }
        }

        public void Download(string path, string nameFile)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                gridFS.DownloadToStreamByName(nameFile, fs);
            }
            
        }

        public List<GridFSFileInfo> FindFiles()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var gridFS = new GridFSBucket(database);

            var filesList = gridFS.Find("{}").ToList();

            return filesList;
        }
    }
}
