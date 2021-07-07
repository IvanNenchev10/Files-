using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
       
        static StreamWriter CreateFirstFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Line1");
                writer.WriteLine("Line2");
                writer.WriteLine("Line3");
                writer.Close();
                return writer;
            }
        }
        static StreamWriter CreateSecondFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Line1");
                writer.WriteLine("Line4");
                writer.WriteLine("Line5");
                writer.Close();
                return writer;
            }
        }
        static void ReadFile(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line = reader.ReadToEnd();
                Console.WriteLine(line);
                reader.Close();
            }
        }
        static void CompareFiles(string filename1,string filename2)
        {
            int equal = 0, different = 0;
            string[] lines1 = File.ReadAllLines(filename1);
            string[] lines2 = File.ReadAllLines(filename2);
            for(int i=0;i<lines1.Length;i++)
            {
               if(lines1[i].Equals(lines2[i]))
                {
                    equal++;
                }
               else
                {
                    different++;
                }
            }
            Console.WriteLine("Number of equal lines is:{0}", equal);
            Console.WriteLine("Number of different lines is:{0}", different);
        }
        static void Main()
        {
            string filename1 = "D:/myfirstfile.txt";
            string filename2 = "D:/mysecondfile.txt";
            StreamWriter writer1 = CreateFirstFile(filename1);
            StreamWriter writer2 = CreateSecondFile(filename2);
            ReadFile(filename1);
            Console.WriteLine();
            ReadFile(filename2);
            Console.WriteLine();
            CompareFiles(filename1, filename2);
           

        }
    }
}
