using BenchmarkDotNet.Attributes;
using System;
using System.Reflection;

namespace DKB.GettterSetter.Benchmark
{
    public static class Dynamic
    {
        public static Func<T, object> Getter<T>(string propertyName)
        {
            var type = typeof(T);
            if (DelegateStore<T>.Getters.TryGetValue(propertyName, out Func<T, object> getter)) return getter;
            getter = (Func<T, object>)Delegate.CreateDelegate(typeof(Func<T, object>), type.GetProperty(propertyName).GetGetMethod());
            DelegateStore<T>.Getters[propertyName] = getter;
            return getter;
        }

        public static Action<T, P> Setter<T, P>(string propertyName)
        {
            var type = typeof(T);
            if (DelegateStore<T>.Setters.TryGetValue(propertyName, out Delegate result)) return (Action<T, P>)result;
            var setter = Delegate.CreateDelegate(typeof(Action<T, P>), type.GetProperty(propertyName).GetSetMethod());
            DelegateStore<T>.Setters[propertyName] = setter;
            return (Action<T, P>)setter;
        }

        public static P GetterInfo<T, P>(this T source, string propertyName)
        {
            var type = typeof(T);
            if (DelegateStore<T>.Properties.TryGetValue(propertyName, out PropertyInfo property)) return (P)property.GetValue(source);
            property = type.GetProperty(propertyName);
            DelegateStore<T>.Properties[propertyName] = property;
            return (P)property.GetValue(source);
        }

        public static void SetterInfo<T, P>(this T source, string propertyName, object value)
        {
            var type = typeof(T);
            if (DelegateStore<T>.Properties.TryGetValue(propertyName, out PropertyInfo property))
            {
                property.SetValue(source, value);
                return;
            }
            property = type.GetProperty(propertyName);
            DelegateStore<T>.Properties[propertyName] = property;
            property.SetValue(source, value);
        }

        public static P GetterReflection<T, P>(this T source, string propertyName)
        {
            var type = typeof(T);
            foreach(var property in type.GetProperties())
            {
                if(property.Name == propertyName)
                    return (P)property.GetValue(source);
            }

            return default;
        }

        public static void SetterReflection<T, P>(this T source, string propertyName, object value)
        {
            var type = typeof(T);
            foreach (var property in type.GetProperties())
            {
                if (property.Name == propertyName)
                    property.SetValue(source, value);
            }            
        }
    }
}
