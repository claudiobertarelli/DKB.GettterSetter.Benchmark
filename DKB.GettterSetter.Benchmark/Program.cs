using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Linq.Expressions;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;

namespace DKB.GettterSetter.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<GetterBenchmark>();
            BenchmarkRunner.Run<SetterBenchmark>();
        }
    }
}
