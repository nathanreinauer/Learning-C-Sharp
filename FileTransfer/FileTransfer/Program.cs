using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These files in Customer Orders are new:");
            ModifiedFiles newFiles = new ModifiedFiles();
            foreach (var file in newFiles.modified())
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("Transfer them to Home Office? y/n");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.WriteLine("Okay, here goes nuthin'!");
            }
            else if (answer == "n")
            {
                Console.WriteLine("Sad. You make me sad.");
            }
            else
            {
                Console.WriteLine("WTF was that?");
            }
        

                
            

        }
    }
    class ModifiedFiles
    {
        public string your_dir;

        public IEnumerable<FileInfo> modified()
        {
            your_dir = @"C:\Users\Student\Desktop\Customer Orders";
            var directory = new DirectoryInfo(your_dir);
            DateTime from_date = DateTime.Now.AddDays(-1);
            DateTime to_date = DateTime.Now;
            var files = directory.GetFiles()
              .Where(file => file.LastWriteTime >= from_date && file.LastWriteTime <= to_date);
            return files.ToList();
        }
    }
}
