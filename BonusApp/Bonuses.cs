using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public delegate double BonusProvider(double amount); Original delegate
namespace BonusApp
{
    public class Bonuses
    {
        //Original
        //public static double TenPercent(double amount)
        //{
        //    return amount * 0.10;
        //}

        //Lambda
        public static Func<double, double> TenPercent = x => x * 0.10;

        //Original
        //public static double FlatTwoIfAmountMoreThanFive(double amount)
        //{
        //    if (amount > 5)
        //    {
        //        return 2.0;
        //    }
        //    else
        //    {
        //        return 0.0;
        //    }
        //}

        //Lambda
        public static Func<double, double> FlatTwoIfAmountMoreThanFive = x =>
        {
            if (x > 5)
            {
                return 2.0;
            }
            else
            {
                return 0.0;
            }
        };

        //Ex59 Lambda Øvelse 3
        //BonusProvider f = (x,y) => x + y;
        //BonusProvider fo = x =>
        //{
        //    int inte = 0;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        inte += x;
        //    }
        //    return inte;
        //};
        //BonusProvider foo = x => x * x;
    }
}
