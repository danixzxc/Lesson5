using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex2
{
    class Message
    {
        public static StringBuilder LessThan(StringBuilder s, int n)
        {
            var msg = s.ToString().Split(new char[] { ' ' }).Where(x => x.Length <= n).ToArray();
            StringBuilder sb = new StringBuilder();
            foreach (var word in msg)
            {
                sb.Append(word + " ");
            }
            return sb;
        }
    }
}
