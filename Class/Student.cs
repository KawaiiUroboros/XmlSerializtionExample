using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Class
{
    //REALLY IMPORTANT: these [things] are called attributes, they say to your programm what to do with things(classes) under them
    //for example: XmlInclude says what  additional type program need to serialize
    // without them programm will try to serialize only Student class and when it will come over Contest or Control object
    // porgram gonna stop  then gg easy game for you
    [XmlInclude(typeof(ControlWork))]
    [XmlInclude(typeof(Contest))]
    public class Student
    {
        /// <summary>
        /// xml constructor
        /// </summary>
        public Student()
        {

        }
        /// <summary>
        /// construcot with copmosition of works-list
        /// </summary>
        public Student(string name,string surname)
        {
            Name = name;
            SurName = surname;
            for (int i = 0; i < Methods.rnd.Next(5, 11); i++)
            {
                if (Methods.rnd.Next(0, 2) == 1)
                    Works.Add(new Contest() { TasksNumber = Methods.rnd.Next(1, 11), Weight = Methods.rnd.Next(1, 81), Name = Methods.GenerateRussianName() });
                else
                    Works.Add(new ControlWork() { Value = Methods.rnd.Next(0, 54), Weight = Methods.rnd.Next(1, 81), Name = Methods.GenerateRussianName() });
            }
        }
        /// <summary>
        /// name of a student
        /// </summary>
        string name;
        public string Name
        {
            get => name;
            set
            {
                if (value == null || value.Length < 2 || value.Length > 12 || !Methods.IsStringCorrectInRussian(value))
                    throw new ArgumentException("name have to be between 2 and 12 than start from bug letter and contain only russian");
                name = value;
            }
        }
        /// <summary>
        /// surname of a student
        /// </summary>
        string surName;
        public string SurName
        {
            get => surName;
            set
            {
                if (value == null || value.Length < 2 || value.Length > 12 || !Methods.IsStringCorrectInRussian(value))
                    throw new ArgumentException("surname have to be between 2 and 1 2than start from bug letter and contain only russian");
                surName = value;
            }
        }
        /// <summary>
        /// list of works of a student
        /// </summary>
        List<ControlElement> works = new List<ControlElement>();   
        public List<ControlElement> Works { get => works; set { works = value; } }
        public override string ToString()
        {
            StringBuilder worksString = new StringBuilder();
            foreach(var work in Works)
            {
                worksString.Append(work.ToString() + "\n");
            }
            return $"{Name} {SurName} have works:\n" + worksString;
        }
    }
}
