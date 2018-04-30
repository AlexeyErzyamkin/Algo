using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.Benchmarks
{
    [TestClass]
    [ClrJob(isBaseline: true), CoreJob]
    [RPlotExporter, RankColumn]
    public class SelecingSortBenchmarks
    {
        [TestMethod]
        public void RunBenchmarks()
        {
            var summary = BenchmarkRunner.Run<SelecingSortBenchmarks>();
        }

        private int[] _values;

        [GlobalSetup]
        public void Setup()
        {
            _values = ArrayHelper.InitArray(1000, 1, 100);
        }

        [Benchmark]
        public void Benchmark()
        {
            SelectingSort.Sort(_values);
        }
    }
}