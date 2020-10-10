using System;
using System.Collections.Generic;
using System.Text;

namespace simplecalcCamua
{
    public delegate int GetAnswer(int num1, int num2);
    class Formula
    {
        public static int getSum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int getDifference(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int getProduct(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int getQuotient(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
