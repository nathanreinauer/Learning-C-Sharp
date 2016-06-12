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

        private static string targetPath;
        public static bool running;


        static void Main(string[] args)
        {
            var function = new Functions();
            running = true;
            while (running)
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
                    targetPath = @"C:\Users\Student\Desktop\Home Office";
                    int num = 0;

                    foreach (var file in newFiles.modified())
                    {
                        File.Copy(file.FullName, Path.Combine(targetPath, file.Name), true);
                        num++;
                    }

                    Console.WriteLine("{0} files transfered.", num);
                    break;

                }
                else if (answer == "n")
                {
                    Console.WriteLine("Would you like to exit the program? y/n");
                    string answerExit = Console.ReadLine();
                    if (answerExit == "y")
                    {
                        Console.WriteLine("See yah!");
                        break;
                    }
                    else if (answerExit == "n")
                    {
                        // Loop back to beginning
                    }
                    else
                    {
                        function.wrong();
                    }
                }
                else
                {
                    function.wrong();
                }
            }
        }
    }   
    class ModifiedFiles
    {
        public string your_dir;

        public IEnumerable<FileInfo> modified()
        {
            your_dir = @"C:\Users\Student\Desktop\Customer Orders\";
            var directory = new DirectoryInfo(your_dir);
            DateTime from_date = DateTime.Now.AddDays(-1);
            DateTime to_date = DateTime.Now;
            var files = directory.GetFiles()
              .Where(file => file.LastWriteTime >= from_date && file.LastWriteTime <= to_date);
            return files.ToList();


            // Copy the files and overwrite destination files if they already exist.

        }

    }
    class Functions
    {
        public void wrong() { Console.WriteLine("---Input must be 'y' or 'n'."); }
    }
}

