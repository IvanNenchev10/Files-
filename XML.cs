using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace Test
{
    class Program
    {
        static void Main()
        {
            string filename = "D:\\Student.xml";
            XmlTextWriter writer = new XmlTextWriter(filename,System.Text.Encoding.UTF8);
            writer.WriteStartDocument();
            writer.WriteComment("Creating XML File");
            writer.WriteStartElement("Students");
            for(int i=1;i<=10;i++)
            {
                writer.WriteStartElement("Student");

                Console.WriteLine("Enter name:");
                writer.WriteElementString("Name", Console.ReadLine());
                Console.WriteLine("Enter gender");
                writer.WriteElementString("Gender", Console.ReadLine());                Console.WriteLine("Enter age:");
                Console.WriteLine("Enter age:");
                writer.WriteElementString("Age", Console.ReadLine());
                Console.WriteLine("Enter mark:");
                writer.WriteElementString("Mark", Console.ReadLine());
                Console.WriteLine("Enter description:");
                writer.WriteElementString("Description", Console.ReadLine());
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
