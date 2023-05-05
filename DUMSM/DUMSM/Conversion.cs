using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMSM
{
    internal static class Conversion
    {
        public static string BnNumber2EnNumber(string s)
        {
            string result = "";
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i]>='০' && s[i] <= '৯')
                {
                    int num = (int)s[i] - (int)'০';
                    result+=num.ToString();
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    int num = (int)s[i] - (int)'0';
                    result += num.ToString();
                }
                else
                {
                    result = "false";
                    break;
                }
            }
            return result;
        }

    }
}
