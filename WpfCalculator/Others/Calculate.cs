﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculator.Others
{
    public class Calculate
    {

        public static double Pow(double fo, double so)
        {
            return (Math.Pow(fo, so));
        }


        public static string Divide(string fo, string so)
        {
            double num1 = Convert.ToDouble(fo);
            double num2 = Convert.ToDouble(so);

            if ((num2 != 0))
            {
                return Convert.ToString((num1 / num2));
            }
            else if (num2 == 0)
            {
                return "Ошибка";
            }
            return "";
        }

        public static double Multiply(double fo, double so)
        {
            return (fo * so);
        }

        public static double Minus(double fo, double so)
        {
            return (fo - so);
        }

        public static double Plus(double fo, double so)
        {
            return (fo + so);
        }
    }
}
