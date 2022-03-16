using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheBestDeal
{
    public class Program
    {
        static int[] dealArr = { 122, 2, 8, 7, 6, 4, 10, 9, 1 };        
        static List<int[]> list = new List<int[]>();
                
        static void Main(string[] args)
        {
            Deals deals = new Deals();

            int[] bestDeal = deals.GetBestDeal(dealArr);

            foreach (int d in dealArr )
            {
                Console.Write(d + " ");               
            }

            Console.WriteLine();

            Console.WriteLine($"Best deal: {bestDeal[1]} - {bestDeal[0]} = {bestDeal[2]} ");
            Console.ReadKey();
        }
    }
}
