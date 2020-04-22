using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    /// <summary>
    /// includes static methods usable by all types in class library
    /// </summary>
    static public class Methods
    {
        /// <summary>
        /// check if string starts from the big letter and made from russian letters
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsStringCorrectInRussian(string str)
        {
           return str.All(c => c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я') && (str[0] >= 'А' || str[0] <= 'Я');
        }
        /// <summary>
        /// a dummy random object
        /// </summary>
        public static Random rnd = new Random();
        /// <summary>
        /// generates a name between 2 an 12 in Russhian and starts from BIG letter
        /// </summary>
        /// <returns></returns>
        public static string GenerateRussianName()
        {
            int length = rnd.Next(2, 13);
            StringBuilder sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
                sb.Append((char)rnd.Next('а', 'я' + 1));
            sb[0] = char.ToUpper(sb[0]);
            return sb.ToString();
        }
    }
}
