using Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace varDO22052020
{
    class Program
    {
        /// <summary>
        /// Here what you see is an example of xml de\serialization
        /// The structure consist of
        /// class STUDENT who have list of works type ControlElement , he can have Contest work or Control work
        /// thats all, feel free to see the real example of work if you are newbie
        /// my runglish is cool, i know ,thnx fro patiance)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            do
            {
                //Making an object to serialize
                Student student = new Student(Methods.GenerateRussianName(), Methods.GenerateRussianName());
                // let's see what student has in it
                Console.WriteLine(student);
                Console.WriteLine("Serialiaztion");
                Console.WriteLine("--------------------------------------------------------------");
                //Xml serialization try
                try
                {
                    //let's make a xml serializtion object!
                    XmlSerializer ser = new XmlSerializer(typeof(Student));
                    //serializing by itself)
                    using (FileStream fs = new FileStream("Student.xml", FileMode.Create))
                    {
                        ser.Serialize(fs, student);
                    }
                }
                catch
                {
                    // maybe smth will go wrong
                    Console.WriteLine("sorry Serialiaztion failed, it was working on my machine(");
                    return;
                }
                Console.WriteLine("Serialized!!!");
                Console.WriteLine("Deserialize");
                Console.WriteLine("--------------------------------------------------------------");
                //Xml DeSerialization try
                try
                {
                    //let's make a xml DeSerializtion object!
                    XmlSerializer deSer = new XmlSerializer(typeof(Student));
                    //Making an object to DeSerialize
                    Student DeStudent;
                    using (FileStream file = new FileStream("Student.xml", FileMode.Open))
                    {
                        DeStudent = (Student)deSer.Deserialize(file);
                        Console.WriteLine("Desiarilezed!!!");
                    }
                    Console.WriteLine("-------------------------------------------------------------");
                    //let's see what we have deserialized
                    Console.WriteLine(DeStudent);
                }
                catch
                {
                    // maybe smth will go wrong
                    Console.WriteLine("sorry DeSerialiaztion failed, it was working on my machine(");
                    return;
                }
                Console.WriteLine("\n-----------------\n");
                Console.WriteLine(@"made with love by
__         __
/  \.-''' -./  \
\    - -    /
   | o   o |
 \  .-'''-.  /
  '-\__Y__/-'
     `---`");
                Console.WriteLine("To exit press Esc");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
