``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|            Method |     Mean |   Error |  StdDev | Ratio | RatioSD | Completed Work Items | Lock Contentions |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |---------:|--------:|--------:|------:|--------:|---------------------:|-----------------:|-------:|------:|------:|----------:|
|     GetByProperty | 208.3 ns | 2.04 ns | 1.81 ns |  1.00 |    0.00 |               0.0000 |                - | 0.0305 |     - |     - |     144 B |
|     GetByDelegate | 239.8 ns | 1.71 ns | 1.60 ns |  1.15 |    0.01 |               0.0000 |                - | 0.0305 |     - |     - |     144 B |
| GetByPropertyInfo | 330.2 ns | 2.05 ns | 1.92 ns |  1.58 |    0.02 |               0.0000 |                - | 0.0305 |     - |     - |     144 B |
|   GetByReflection | 402.4 ns | 2.61 ns | 2.31 ns |  1.93 |    0.02 |               0.0000 |                - | 0.0424 |     - |     - |     200 B |
