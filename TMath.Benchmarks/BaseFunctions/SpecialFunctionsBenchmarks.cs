﻿using BenchmarkDotNet.Attributes;

namespace TMath.Benchmarks.BaseFunctions
{
    public class SpecialFunctionsBenchmarks
    {
        [Benchmark]
        public long TFactorial() => TFunctions.Factorial(10);

        [Benchmark]
        public double TSum() => TFunctions.Sum<double>(x => x, 10);

        [Benchmark]
        public double TRemainder() => TFunctions.Remainder(10, 3);

        [Benchmark]
        public double TTruncate() => TFunctions.Truncate<double>(10.123456789);

        [Benchmark]
        public double TClamp() => TFunctions.Clamp<double>(10, 5, 15);

        [Benchmark]
        public double TCopySign() => TFunctions.CopySign<double>(10, -1);
    }
}
