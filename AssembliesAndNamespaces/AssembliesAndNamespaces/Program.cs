using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://sunsettheatre.com");

            Console.WriteLine(reply);

            File.WriteAllText(@"C:\Users\Student\Desktop\WriteText.txt", reply);
            Console.ReadLine();
        }
    }
}
