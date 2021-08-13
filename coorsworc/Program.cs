using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coorsworc
{
   public class Program
    {
        public static int NO_EDGE = 99999;
        static void Main(string[] args)
        {
            List<int> matrix300 = new List<int>();
            List<int> matrix600 = new List<int>();
            List<int> matrix1200 = new List<int>();
            List<int> matrix2400 = new List<int>();
            List<int> matrix2800 = new List<int>();
            List<int> matrix4800 = new List<int>();

            using (StreamReader r = new StreamReader($@"../../../Generator/bin/Debug/4800.json"))
            {
                string json = r.ReadToEnd();
                matrix4800 = JsonConvert.DeserializeObject<List<int>>(json);
            }
            FloydWarshall_02(matrix4800.ToArray(), 50);
            FloydWarshall_01(matrix4800.ToArray(), 50);

            {
                //using (StreamReader r = new StreamReader($@"../../../Generator/bin/Debug/600.json"))
                //{
                //    string json = r.ReadToEnd();
                //    matrix600 = JsonConvert.DeserializeObject<List<int>>(json);
                //}

                //using (StreamReader r = new StreamReader($@"../../../Generator/bin/Debug/1200.json"))
                //{
                //    string json = r.ReadToEnd();
                //    matrix1200 = JsonConvert.DeserializeObject<List<int>>(json);
                //}

                //using (StreamReader r = new StreamReader($@"../../../Generator/bin/Debug/2400.json"))
                //{
                //    string json = r.ReadToEnd();
                //    matrix2400 = JsonConvert.DeserializeObject<List<int>>(json);
                //}

                //using (StreamReader r = new StreamReader($@"../../../Generator/bin/Debug/2800.json"))
                //{
                //    string json = r.ReadToEnd();
                //    matrix2800 = JsonConvert.DeserializeObject<List<int>>(json);
                //}
            }


        }

        public static void FloydWarshall_02(int[] matrix, int sz)
        {
            for (var k = 0; k < sz; ++k)
            {
                Parallel.For(0, sz, i =>
                {
                    if (matrix[i * sz + k] == NO_EDGE)
                    {
                        return;
                    }
                    for (var j = 0; j < sz; ++j)
                    {
                        var distance = matrix[i * sz + k] + matrix[k * sz + j];
                        if (matrix[i * sz + j] > distance)
                        {
                            matrix[i * sz + j] = distance;
                        }
                    }
                });
            }
        }

        public static void FloydWarshallGeneral(int[] matrix, int sz)
        {
            for (var k = 0; k < sz; ++k)
            {
                for (var i = 0; i < sz; ++i)
                {
                    if (matrix[i * sz + k] == NO_EDGE)
                    {
                        continue;
                    }
                    for (var j = 0; j < sz; ++j)
                    {
                        var distance = matrix[i * sz + k] + matrix[k * sz + j];
                        if (matrix[i * sz + j] > distance)
                        {
                            matrix[i * sz + j] = distance;
                        }
                    }
                }
            }
 
        }
  
    }
}
