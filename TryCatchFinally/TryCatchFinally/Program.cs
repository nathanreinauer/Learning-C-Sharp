using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\Student\Desktop\text.txt";
                File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                string path = @"C:\Users\Student\Desktop\logfile.txt";
                File.WriteAllText(path, e.Message);
                Console.WriteLine("Error written to logfile.");
            }
            finally
            {
                Console.WriteLine("Finished.");
            }

        }
    }
}
