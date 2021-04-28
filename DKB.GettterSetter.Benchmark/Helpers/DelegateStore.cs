using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DKB.GettterSetter.Benchmark
{
    internal static class DelegateStore<T>
    {
        internal static IDictionary<string, Func<T, object>> Getters = new ConcurrentDictionary<string, Func<T, object>>();
        internal static IDictionary<string, Delegate> Setters = new ConcurrentDictionary<string, Delegate>();
        internal static IDictionary<string, PropertyInfo> Properties = new ConcurrentDictionary<string, PropertyInfo>();
    }
}
