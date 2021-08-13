using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<TestMetodBanchMarcet>();
            Console.ReadKey();
        }
    }
}
