using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Class
{
    
    public class Contest : ControlElement
    {
        /// <summary>
        /// number of tasks in contest
        /// </summary>
        int tasksNumber;
        public int TasksNumber
        {
            get => tasksNumber;
            set {
                if (value < 1 || value > 10)
                    throw new ArgumentException("number of tasks should be from 1 to 10]");
                tasksNumber = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $":Contest with {TasksNumber} tasks";
        }
    }
}
