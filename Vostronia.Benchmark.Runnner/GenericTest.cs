using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vostronia.Benchmark.Runnner
{
    public class GenericTest
    {
        [Benchmark]
        public void Run()
        {
            DoStuff();
        }

        private void DoStuff()
        {
            var list = new List<int>();

            for (var i = 0; i <= 100000; i++)
            {
                list.Add(i);
            }
        }
    }
}
