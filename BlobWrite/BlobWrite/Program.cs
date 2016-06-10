using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BlobWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Turn an image into a byte array
            string path = @"C:\Users\Student\Desktop\image.jpg";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fs);
            byte[] BlobValue = reader.ReadBytes((int)fs.Length);
            fs.Close();
            reader.Close();

            // Write the byte array to a text file
            FileStream fs2 = new FileStream(@"C:\Users\Student\Desktop\Blob.txt", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fs2, BlobValue);
            fs2.Close();
            
            // Deserialize back into byte array
            byte[] serializedData = null;
            fs = new FileStream(@"C:\Users\Student\Desktop\Blob.txt", FileMode.Open);
            serializedData = (byte[])serializer.Deserialize(fs);
            fs.Close();

            Console.WriteLine("Done.");
        }
    }
}
