using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheBestDeal
{
    public class Deals
    {
        List<int[]> profitList = new List<int[]>();
        int[] bestDeal = new int[3];
        
        public int[] GetBestDeal(int[] dealArr)
        {
            int dim = dealArr.Length;

            for (int i = 0; i <= dim; i++)
            {
                for (int j = i + 1; j < dim; j++)
                {
                    if (dealArr[j] > dealArr[i])
                    {
                        profitList.Add(new int[] { dealArr[i], dealArr[j], dealArr[j] - dealArr[i] });
                    }
                }
            }

            int maxProfit = profitList.Max(x => x[2]);
            profitList.Find(x => x[2] == maxProfit).CopyTo(bestDeal, 0);

            return bestDeal;
        }
    }
}
