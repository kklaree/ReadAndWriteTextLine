using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReadandWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            StreamReader sr = new StreamReader("C:\\Users\\PC\\Documents\\hatdog.txt");

            line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();

            StreamWriter sw = new StreamWriter("C:\\Users\\PC\\Documents\\hatdog.txt");

            sw.WriteLine("Hello World!");
            sw.WriteLine("From me");

            sw.Close();
        }
    }
}
