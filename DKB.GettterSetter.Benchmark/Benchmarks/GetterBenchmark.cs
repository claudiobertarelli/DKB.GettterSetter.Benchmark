using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DKB.GettterSetter.Benchmark
{
    [MemoryDiagnoser, ThreadingDiagnoser]
    public class GetterBenchmark
    {
        [Benchmark(Baseline = true)]
        public void GetByProperty()
        {
            var source = new ComplexObject { Name = "NAME-TESTING-01" };
            var x = source.Name;
        }

        [Benchmark]
        public void GetByDelegate()
        {
            var source = new ComplexObject { Name = "NAME-TESTING-01" };
            var getMember = Dynamic.Getter<ComplexObject>("Name");
            getMember(source);
        }

        [Benchmark]
        public void GetByPropertyInfo()
        {
            var source = new ComplexObject { Name = "NAME-TESTING-01" };
            source.GetterInfo<ComplexObject, string>("Name");
        }

        [Benchmark]
        public void GetByReflection()
        {
            var source = new ComplexObject { Name = "NAME-TESTING-01" };
            source.GetterReflection<ComplexObject, string>("Name");
        }
    }
}
