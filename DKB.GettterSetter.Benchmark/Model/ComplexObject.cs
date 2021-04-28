using System;
using System.Collections.Generic;
using System.Text;

namespace DKB.GettterSetter.Benchmark
{
    public class ComplexObject
    {
        public string CorrelationId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "";
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
