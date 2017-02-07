using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte1.Functions
{
    public class CompleteRange
    {
        public static int[] build(int[] collection)
        {
            List<int> list = new List<int>();
            if (collection.Min() < 0)
            {
                return null;
            }
            else
            {
                for (int i = 1; i <= collection.Max(); i++)
                {
                    list.Add(i);
                }
                return list.ToArray();
            }
        }
    }
}
