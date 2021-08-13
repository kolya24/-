using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;
using CoursWork;
using Newtonsoft.Json;

namespace ConsoleApp1
{   
    
    [HtmlExporter]
    [SimpleJob(RunStrategy.Monitoring, targetCount: 10, id: "MonitoringJob")]
    public  class TestMetodBanchMarcet 
    {
        public List<int> Matrix { get; set; }
        public FloydWarshallAlgoithms FloydAlgorithm { get; set; }

        public TestMetodBanchMarcet()
        {
            this.Matrix = new MatrixGenerator().Matrix;
            this.FloydAlgorithm = new FloydWarshallAlgoithms();
        }
        [Benchmark]
        public void floydwarshall_300_0()
        {
            FloydAlgorithm.FloydWarshall_01(Matrix.ToArray(), 300);
        }

        [Benchmark]
        public void floydwarshall_300_1()
        {
            FloydAlgorithm.FloydWarshall_01(Matrix.ToArray(), 300);
        }

        [Benchmark]
        public void floydwarshall_300_2()
        {
            FloydAlgorithm.FloydWarshall_02(Matrix.ToArray(), 300);
        }

        [Benchmark]
        public void floydwarshall_300_3()
        {
            FloydAlgorithm.FloydWarshall_03(Matrix.ToArray(), 300);
        }
        ///////////////
        [Benchmark]
        public void floydwarshall_600_0()
        {
            FloydAlgorithm.FloydWarshall_01(Matrix.ToArray(), 600);
        }

        [Benchmark]
        public void floydwarshall_600_1()
        {
            FloydAlgorithm.FloydWarshall_01(Matrix.ToArray(), 600);
        }

        [Benchmark]
        public void floydwarshall_600_2()
        {
            FloydAlgorithm.FloydWarshall_02(Matrix.ToArray(), 600);
        }

        [Benchmark]
        public void floydwarshall_600_3()
        {
            FloydAlgorithm.FloydWarshall_03(Matrix.ToArray(), 600);
        }
        ///////////////////
        [Benchmark]
        public void floydwarshall_1200_0()
        {
            FloydAlgorithm.FloydWarshall_01(Matrix.ToArray(), 1200);
        }

        [Benchmark]
        public void floydwarshall_1200_1()
        {
            FloydAlgorithm.FloydWarshall_01(Matrix.ToArray(), 1200);
        }

        [Benchmark]
        public void floydwarshall_1200_2()
        {
            FloydAlgorithm.FloydWarshall_02(Matrix.ToArray(), 1200);
        }

        [Benchmark]
        public void floydwarshall_1200_3()
        {
            FloydAlgorithm.FloydWarshall_03(Matrix.ToArray(), 1200);
        }
        /////////////////////////
        [Benchmark]
        public void floydwarshall_2400_0()
        {
            FloydAlgorithm.FloydWarshall_01(Matrix.ToArray(), 2400);
        }

        [Benchmark]
        public void floydwarshall_2400_1()
        {
            FloydAlgorithm.FloydWarshall_01(Matrix.ToArray(), 2400);
        }

        [Benchmark]
        public void floydwarshall_2400_2()
        {
            FloydAlgorithm.FloydWarshall_02(Matrix.ToArray(), 2400);
        }

        [Benchmark]
        public void floydwarshall_2400_3()
        {
            FloydAlgorithm.FloydWarshall_03(Matrix.ToArray(), 2400);
        }
    }
}
