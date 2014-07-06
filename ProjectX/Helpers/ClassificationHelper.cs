using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectX.Helpers
{
    public static class ClassificationHelper
    {
        public static int ReturnQuantidadeRoundAvg(decimal avg)
        {
            int value = 1;

            if (avg <= 20)
                value = 1;
            else if (avg > 20 && avg <= 40)
                value = 2;
            else if (avg > 40 && avg <= 60)
                value = 3;
            else if (avg > 60 && avg <= 80)
                value = 4;
            else
                value = 5;

            return value;
        }

        public static int ReturnRoundAvg(decimal avg)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(20, Math.Abs(((int)avg) - 20));
            dic.Add(40, Math.Abs(((int)avg) - 40));
            dic.Add(60, Math.Abs(((int)avg) - 60));
            dic.Add(80, Math.Abs(((int)avg) - 80));
            dic.Add(100, Math.Abs(((int)avg) - 100));

            var min = dic.Min(i => i.Value);
            //int value = 1;

            //if (avg < 20)
            //    value = 20;
            //else if (avg > 20 && avg < 40)
            //    value = ;
            //else if (avg > 40 && avg < 60)
            //    value = 3;
            //else if (avg > 60 && avg < 80)
            //    value = 4;
            //else
            //    value = 5;

            return dic.Where(i =>i.Value == min).Select(i => i.Key).First();
        }

        public static string ReturnBelezaRoundAvg(decimal avg)
        {
            string value = "";

            if (avg <= 20)
                value = "capeta";
            else if (avg > 20 && avg <= 40)
                value = "pegoBebado";
            else if (avg > 40 && avg <= 60)
                value = "pegavel";
            else if (avg > 60 && avg <= 80)
                value = "bonita";
            else
                value = "princesa";

            return value;
        }

    }
}