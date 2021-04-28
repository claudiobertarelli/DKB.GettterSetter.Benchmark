``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|            Method |     Mean |   Error |  StdDev | Ratio | RatioSD | Completed Work Items | Lock Contentions |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |---------:|--------:|--------:|------:|--------:|---------------------:|-----------------:|-------:|------:|------:|----------:|
|     SetByProperty | 209.2 ns | 1.87 ns | 1.56 ns |  1.00 |    0.00 |               0.0000 |                - | 0.0305 |     - |     - |     144 B |
|     SetByDelegate | 242.7 ns | 1.50 ns | 1.25 ns |  1.16 |    0.01 |               0.0000 |                - | 0.0305 |     - |     - |     144 B |
| SetByPropertyInfo | 384.2 ns | 2.55 ns | 2.13 ns |  1.84 |    0.02 |               0.0000 |                - | 0.0439 |     - |     - |     208 B |
|   SetByReflection | 461.0 ns | 4.79 ns | 4.48 ns |  2.20 |    0.03 |               0.0000 |                - | 0.0558 |     - |     - |     264 B |
