using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWork
{
    public class MatrixGenerator
    {
        public List<int> Matrix { get; set; }

        public MatrixGenerator()
        {
            this.Matrix = MatrixImplementation();
        }

        private  List<int> Shuffle(List<int> list)
        {
            Random rng = new Random();

            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }

        private List<int> MatrixImplementation()
        {

            Random random = new Random();
            List<int> matrix = new List<int>();

            for (int i = 0; i < 6000000 ; i++)
            {
                matrix.Add(random.Next(1, 40));
            }

            for (int i = 0; i < 700000; i++)
            {
                matrix.Add(99999);
            }
            matrix = matrix.OrderBy(x => random.Next()).ToList();
            matrix = Shuffle(matrix);
            return matrix;

        }

    }
}
