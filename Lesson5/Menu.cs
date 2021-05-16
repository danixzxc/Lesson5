using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson5
{
    class Menu
    {
        /// <summary>
        /// запуск проги
        /// </summary>
        public static void Start()
        {
            Regex regex = new Regex(@"^\D[a-zA-Z0-9]{1,9}\b+$");
            // ^\D в начале строки первый символ не число
            // {1,9}\b от 1 до 9 символов и не более

            // на эту регулярку ломал голову часа 2, зато решение в 3 строки :)
            string s = Console.ReadLine();
            Console.WriteLine(regex.IsMatch(s));
        }
    }
}
