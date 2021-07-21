using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectForAmal
{
    class ClassConvert
    {
        delegate void SwapNumber(ref int val, ref int val1);
        public int ConvertDoubleToInt(double val)
        {
            return Convert.ToInt32(val);
        }

        public int ConvertStringToInt(string val)
        {
            return int.Parse(val);
        }

        public int ConvertFloatToInt(float val)
        {
            return Convert.ToInt32(val);
        } 

        public string ConvertFloatToString(float val)
        {
            return val.ToString();
        }

        public double ConvertFloatToString(int val, int val1)
        {
            return (val+val1)/2;
        }

        public void SwapTwoNumbers(ref int val,ref int val1)
        {
            int tmp;

            tmp = val;
            val = val1;
            val1 = tmp;
        }

        public void SwapTwoNumbersMetod2(ref int val, ref int val1)
        {
            val = val + val1;
            val1 = val - val1;
            val = val - val1;
        }

        public void DelegateSwap( int val, int val1, bool metodSwap)
        {
            SwapNumber delSwap;
            if (metodSwap == true)
            {
                delSwap = SwapTwoNumbers;
            }
            else

            {
                delSwap = SwapTwoNumbersMetod2;
            }
            delSwap(ref val,ref val1);
        }
    }
}
