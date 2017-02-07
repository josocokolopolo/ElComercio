using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte1.Functions
{
    public class MoneyParts
    {
        static decimal[] change = new decimal[] { 0.05m, 0.1m, 0.2m, 0.5m, 1, 2, 5, 10, 20, 50, 100, 200 };
        public static string separate(decimal n,int pos,string result = "")
        {
            int cant = (int)(n / change[pos]);

            result += new StringBuilder((change[pos].ToString().Length + 1) * cant).Insert(0, change[pos].ToString() + ',', cant).ToString();

            n -= change[pos] * cant;

            if (n > 0)
                result = separate(n, pos - 1, result);

            return result;
        }

        public static string[] build(string input)
        {
            decimal number;
            if (decimal.TryParse(input,out number))
            {
                if (BitConverter.GetBytes(decimal.GetBits(number)[3])[2] > 2 || (number % change[0] != 0))
                {
                    return new string[] { "cantidad incorrecta" };
                }
                else
                {
                    List<string> result = new List<string>();

                    for (int i = 0; i < change.Length; i++)
                    {
                        string res = "";
                        if ((int)(number / change[i]) > 0)
                        {
                            res = separate(number, i);
                        }
                        else
                        { break; }

                        result.Add("[" + res.Remove(res.Length - 1) + "]");
                    }

                    return result.ToArray();
                }
            }
            else
            {
                return null;
            }
        }
    }
}
