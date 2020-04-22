using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class ControlElement
    {
        /// <summary>
        /// the weigt of Contorl Element
        /// </summary>
        int weight;
        public int Weight
        {
            get => weight;
            set
            {
                if (value <= 0 || value > 80)
                    throw new ArgumentException(" weight have to be in 0 to 80");
                weight = value;
            }
        }
        /// <summary>
        /// name of corntrol element
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
        public override string ToString()
        {
            return $"{Name} with weight {Weight} " ;
        }
    }
}
