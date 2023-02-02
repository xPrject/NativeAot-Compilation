using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace NativeAot
{
    public class nAotTest
    {
        
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                var sw = Stopwatch.StartNew();
                var input = int.Parse(args[0]);
                var number = FindPrimeNumber(input);

                Console.WriteLine("Searching for prime numbers...");
                Console.WriteLine($"\nFound {number} in {sw.ElapsedMilliseconds}ms");
                sw.Stop();


                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Input any number greater than 0:");

                
                Nullable<int> input = int.Parse(Console.ReadLine());
                var sw = Stopwatch.StartNew();


                if (input > 0)
                {
                    
                    var number = FindPrimeNumber(input);


                    Console.WriteLine($"\nFound {number} in {sw.ElapsedMilliseconds}ms");
                    sw.Stop();


                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("usage: NativeAot.exe <number>");
                }

            }
        }

        public static long FindPrimeNumber(int? n)
        {
            var count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                var prime = 1;
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }



    }

}

