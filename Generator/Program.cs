using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generator
{
    public class Program
    {
        
        public static void Main(string[] args)
        {

            Random random = new Random();
            List<int> matrix = new List<int>();

            for (int i = 0; i < 6000000; i++)
            {
                matrix.Add(random.Next(1, 40));
            }

            for (int i = 0; i < 70000; i++)
            {
                matrix.Add(99999);
            }
            Console.WriteLine(matrix.Count());
            Random rnd = new Random();
            matrix = matrix.OrderBy(x => rnd.Next()).ToList();
            matrix = Shuffle(matrix);
            string json = JsonConvert.SerializeObject(matrix);

            //System.IO.File.WriteAllText("~file.json", json);
            StreamWriter fille = new StreamWriter("6070000.json", append: true);
            fille.WriteLine(json);
            fille.Close();

        }



        public static List<int> Shuffle(List<int> list)
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

    }

}
