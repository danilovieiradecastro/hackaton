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

            if (avg < 20)
                value = 1;
            else if (avg > 20 && avg < 40)
                value = 2;
            else if (avg > 40 && avg < 60)
                value = 3;
            else if (avg > 60 && avg < 80)
                value = 4;
            else
                value = 5;

            return value;
        }

        public static string ReturnBelezaRoundAvg(decimal avg)
        {
            string value = "";

            if (avg < 20)
                value = "capeta";
            else if (avg > 20 && avg < 40)
                value = "pegoBebado";
            else if (avg > 40 && avg < 60)
                value = "pegavel";
            else if (avg > 60 && avg < 80)
                value = "bonita";
            else
                value = "princesa";

            return value;
        }

    }
}