using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Read
    {
        public static string ReadStr()
        {
            string strValue = Console.ReadLine();
            return strValue;
        }
        public static int Readint()
        {
            string strValue = Console.ReadLine();
            int value;
            Int32.TryParse(strValue, out value);
            return value;
        }
        public static double ReadDouble()
        {
            string strValue = Console.ReadLine();
            double value;
            Double.TryParse(strValue, out value);
            return value;
        }
    }
}
