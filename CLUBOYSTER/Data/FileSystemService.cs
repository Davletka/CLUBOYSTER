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
        public void UploadToDb(string text)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream(@"C:\Users\kizaq\Desktop\Reports\report.txt", FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                fs.Write(buffer, 0, buffer.Length);
            }

            using (FileStream fs = new FileStream(@"C:\Users\kizaq\OneDrive\Desktop\Reports\report.txt", FileMode.Open))
            {
                gridFS.UploadFromStream("newReport.txt", fs);
            }
        }

        public void Download(string name, FileStream stream)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var gridFS = new GridFSBucket(database);
            gridFS.DownloadToStreamByName("Report_1", stream);
        }
    }
}
