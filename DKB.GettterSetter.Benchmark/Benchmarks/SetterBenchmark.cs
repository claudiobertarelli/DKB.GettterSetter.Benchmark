using BenchmarkDotNet.Attributes;

namespace DKB.GettterSetter.Benchmark
{
    [MemoryDiagnoser, ThreadingDiagnoser]
    public class SetterBenchmark
    {
        [Benchmark(Baseline = true)]
        public void SetByProperty()
        {
            var source = new ComplexObject { Name = "NAME-TESTING-01" };
            source.Name = "NAME-TESTING-02";
        }

        [Benchmark]
        public void SetByDelegate()
        {
            var source = new ComplexObject { Name = "NAME-TESTING-01" };
            var setMember = Dynamic.Setter<ComplexObject, string>("Name");
            setMember(source, "NAME-TESTING-02");
        }


        [Benchmark]
        public void SetByPropertyInfo()
        {
            var source = new ComplexObject { Name = "NAME-TESTING-01" };
            source.SetterInfo<ComplexObject, string>("Name", "NAME-TESTING-03");
        }

        [Benchmark]
        public void SetByReflection()
        {
            var source = new ComplexObject { Name = "NAME-TESTING-01" };
            source.SetterReflection<ComplexObject, string>("Name", "NAME-TESTING-03");
        }
    }
}
