using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication2
{
    class Program
    {
        static StreamWriter CreateFirstFile(string filename)
        {
            using(StreamWriter writer=new StreamWriter(filename))
            {
                writer.WriteLine("File1");
                writer.Close();
                return writer;
            }
        }
        static StreamWriter CreateSecondFile(string filename)
        {
            using(StreamWriter writer=new StreamWriter(filename))
            {
                writer.WriteLine("File2");
                writer.Close();
                return writer;
            }
        }
        static void ReadFile(string filename)
        {
            using(StreamReader reader=new StreamReader(filename))
            {
                string line = reader.ReadToEnd();
                Console.WriteLine(line);
                reader.Close();
            }
        }
        static void Main()
        {
            string filename = "D:/test.txt";
            string filename1 = "D:/test1.txt";
            string filename2 = "D:/test2.txt";
            StreamWriter writer1 = CreateFirstFile(filename);
            StreamWriter writer2 = CreateSecondFile(filename1);
            ReadFile(filename);
            Console.WriteLine();
            ReadFile(filename1);
            string lines = File.ReadAllText(filename);
            string lines1 = File.ReadAllText(filename1);
            using(StreamWriter writer=new StreamWriter(filename2))
            {
                writer.WriteLine(lines);
                writer.WriteLine(lines1);
                writer.Close();
            }
            ReadFile(filename2);

        }
    }
}
