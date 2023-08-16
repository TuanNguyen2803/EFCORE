using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork.Helper
{
    internal class InputHelper
    {
        public static string InputStr(string input, string err, int min = 0, int max = int.MaxValue)
        {
            string a;
            bool ok = true;
            do
            {
                Console.WriteLine(input);
                a = Console.ReadLine();
                ok = a.Length >= min && a.Length <= max;
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return a;
        }
        public static DateTime InputDT(string input, string err)
        {
            DateTime a;
            bool ok = true;
            do
            {
                Console.WriteLine(input);
                ok = DateTime.TryParse(Console.ReadLine(), out a);
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return a;
        }
    }
}
