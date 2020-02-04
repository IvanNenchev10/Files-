using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            Animal animal = new Animal("Tara", 5, 1.70);
            Stream stream = File.Open("D:/Animal.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, animal);
            stream.Close();
            animal = null;
            stream = File.Open("AnimalData.dat", FileMode.Open);
            bf = new BinaryFormatter();
            animal = (Animal)bf.Deserialize(stream);
            stream.Close();
            Console.WriteLine(animal);
        }
    }
}
