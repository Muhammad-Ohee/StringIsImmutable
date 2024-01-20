//Console.WriteLine("Hello, OS");

using System.Diagnostics;
using System.Text;

namespace StringIsImmutable
{
    class Program
    {
        static void Main(string[] args)
        {
            // ******** string ********
            /*
            string str = "";
            Console.WriteLine("Loop started:");
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 30000000; i++)
            {
                str = Guid.NewGuid().ToString();
            }

            stopWatch.Stop();

            Console.WriteLine("Loop ended");
            Console.WriteLine("Loop executed time in ms:" + stopWatch.ElapsedMilliseconds);
            */


            // Integer
            /*
            int ctr = 0;
            Console.WriteLine("Loop started:");
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 30000000; i++)
            {
                ctr = ctr + 1;
            }

            stopWatch.Stop();

            Console.WriteLine("Loop ended");
            Console.WriteLine("Loop executed time in ms:" + stopWatch.ElapsedMilliseconds);
            */


            // String Intern in C#
            /*
            string str = "";
            Console.WriteLine("Loop started:");
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 30000000; i++)
            {
                str = "OS";
            }

            stopWatch.Stop();

            Console.WriteLine("Loop ended");
            Console.WriteLine("Loop executed time in ms:" + stopWatch.ElapsedMilliseconds);
            */


            // StringBuilder in C#
            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine("Loop started:");
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < 30000000; i++)
            {
                stringBuilder.Append("OS");
            }

            stopWatch.Stop();

            Console.WriteLine("Loop ended");
            Console.WriteLine("Loop executed time in ms:" + stopWatch.ElapsedMilliseconds);
        }
    }
}