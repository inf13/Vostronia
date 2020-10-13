using BenchmarkDotNet.Running;
using System;

namespace Vostronia.Benchmark.Runnner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<GenericTest>();
        }
    }
}
