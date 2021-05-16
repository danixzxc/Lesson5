using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Menu
    {
        public static void Start()
        {
            Console.WriteLine("Введите максимум букв");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите строку");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            s = Message.LessThan(s, n);
            Console.WriteLine(s.ToString());
        }
    }
}
