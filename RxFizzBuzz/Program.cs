using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reactive.Linq;

namespace RxFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Observable.Interval(TimeSpan.FromSeconds(1))
                .Skip(1) //skips zero
                .Subscribe(i => Console.WriteLine(i % 3 == 0 && i % 5 == 0 ? "FizzBuzz"
                                                              : i % 3 == 0 ? "Fizz"
                                                              : i % 5 == 0 ? "Buzz"
                                                              : i.ToString()));

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }
    }
}
