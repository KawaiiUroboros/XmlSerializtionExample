using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Class
{
    
    public class ControlWork : ControlElement
    {
        /// <summary>
        /// variant of a contest
        /// </summary>
        int value;
        public int Value
        {
            get => value;
            set
            {
                if (value < 0)
                    throw new ArgumentException("variant should be more than 0");
                this.value = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $":ControlWork with varient number {Value}";
        }
    }
}
