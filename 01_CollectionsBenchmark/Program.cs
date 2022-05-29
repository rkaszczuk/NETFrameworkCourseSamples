using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CollectionsBenchmark
{
    [SimpleJob(runStrategy: RunStrategy.ColdStart,launchCount: 3, warmupCount: 5, targetCount: 5)]
    [MemoryDiagnoser]
    public class CollectionsInsertBenchmark
    {
        [Params(1000, 10000, 100000, 1000000)]
        public int ElementsCount { get; set; }

        [Benchmark]
        public void ArrayListInsertTest()
        {
            var arrayList = new ArrayList();
            for (int i = 0; i < ElementsCount; i++)
            {
                arrayList.Add(i);
            }
        }

        [Benchmark]
        public void ListObjectInsertTest()
        {
            var listObj = new List<object>();
            for (int i = 0; i < ElementsCount; i++)
            {
                listObj.Add(i);
            }
        }

        [Benchmark]
        public void ListIntInsertTest()
        {
            var listString = new List<int>();
            for (int i = 0; i < ElementsCount; i++)
            {
                listString.Add(i);
            }
        }
        [Benchmark]
        public void ListIntInsertWithoutResizeTest()
        {
            var listString = new List<int>(ElementsCount);
            for (int i = 0; i < ElementsCount; i++)
            {
                listString.Add(i);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run(typeof(Program).Assembly);
            Console.ReadKey();
        }
    }
}
