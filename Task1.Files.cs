using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Еxam
{
    class Program
    {
        static StreamWriter CreateFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("This is my file");
                writer.WriteLine("This is my file again");
                writer.WriteLine("This is my file once again");
                writer.Close();
                return writer;
            }
        }
        static void ReadFile(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line = reader.ReadLine();
                while(line!=null)
                {
                    Console.WriteLine("{0}", line);
                    line = reader.ReadLine();
                }
                reader.Close();
            }
        }
        static void WriteToFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            using( StreamWriter writer = new StreamWriter(filename))
            {
                string result = null;
                for(int i=0;i<lines.Length;i++)
                {
                    result = i + 1 + " " + lines[i];
                    writer.WriteLine(result);   
                }
                writer.Close();
            }
        }
        static void Main()
        {
            string filename1 = "D:/file.txt";
            StreamWriter writer = CreateFile(filename1);
            ReadFile(filename1);
            WriteToFile(filename1);
            ReadFile(filename1);
            
        }
    }
}
