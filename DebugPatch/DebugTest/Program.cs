using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DebugTest
{
    class Program
    {
        private static string CurrentTime
        {
            get
            {
                return System.DateTime.Now.ToString("HH:mm:ss");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("[{0}] {1}",CurrentTime, "message"));
            Console.Read();
        }
    }
}
