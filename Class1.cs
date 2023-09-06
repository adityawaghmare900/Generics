using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Class1
    {
        public int MaximumInterger(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 ||
               num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 ||
               num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }

            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 ||
                num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 ||
                num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }

            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 ||
                num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 ||
                num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0)
            {
                return num3;
            }
            throw new Exception("Num1,Num2,Num3 are same");
        }
    }
    internal class class2
    {
        public float MaximumFloat(float num4, float num5, float num6)
        {
            if (num4.CompareTo(num5) > 0 && num4.CompareTo(num6) > 0 ||
               num4.CompareTo(num5) > 0 && num4.CompareTo(num6) > 0 ||
               num4.CompareTo(num5) > 0 && num4.CompareTo(num6) >= 0)
            {
                return num4;
            }

            if (num5.CompareTo(num4) > 0 && num5.CompareTo(num6) > 0 ||
                num5.CompareTo(num4) >= 0 && num5.CompareTo(num6) > 0 ||
                num5.CompareTo(num4) > 0 && num5.CompareTo(num6) >= 0)
            {
                return num4;
            }

            if (num6.CompareTo(num4) > 0 && num6.CompareTo(num5) > 0 ||
                num6.CompareTo(num4) >= 0 && num6.CompareTo(num5) > 0 ||
                num6.CompareTo(num4) > 0 && num6.CompareTo(num5) >= 0)
            {
                return num6;
            }
            throw new Exception("Num1,Num2,Num3 are same");
        }

    }
    internal class class3
    {
        public string MaximumString(string str1, string str2, string str3)
        {
            if ((str1.Length).CompareTo(str2.Length) > 0 && str2.Length.CompareTo(str3.Length) > 0 ||
               str1.Length.CompareTo(str2.Length) > 0 && str2.Length.CompareTo(str3.Length) > 0 ||
               str1.Length.CompareTo(str2.Length) > 0 && str2.Length.CompareTo(str3.Length) >= 0)
            {
                return str1;
            }

            if (str2.Length.CompareTo(str1.Length) > 0 && str2.Length.CompareTo(str3.Length) > 0 ||
                str2.Length.CompareTo(str1.Length) >= 0 && str2.Length.CompareTo(str3.Length) > 0 ||
                str2.Length.CompareTo(str1.Length) > 0 && str2.Length.CompareTo(str3.Length) >= 0)
            {
                return str2;
            }
  
            if (str3.Length.CompareTo(str1.Length) > 0 && str3.Length.CompareTo(str2.Length) > 0 ||
                str3.Length.CompareTo(str1.Length) >= 0 && str3.Length.CompareTo(str2.Length) > 0 ||
                str3.Length.CompareTo(str1.Length) > 0 && str3.Length.CompareTo(str2.Length) >= 0)
            {
                return str3;
            }
            throw new Exception("Num1,Num2,Num3 are same");
        }

    }
}