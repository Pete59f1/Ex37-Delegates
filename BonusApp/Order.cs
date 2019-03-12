using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        private Func<double, double> bonus; //Func<double, double> Er den nye delegate i Ex59
        private List<Product> products = new List<Product>();

        public Func<double, double> Bonus
        {
            get
            {
                return bonus;
            }
            set
            {
                bonus = value;
            }
        }

        public void AddProduct(Product p)
        {
            products.Add(p);
        }
        public double GetValueOfProducts()
        {
            double price = 0.0;
            foreach (Product pro in products)
            {
                price += pro.Value;
            }
            return price;
        }
        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        //Ex59 øvelse 4.3
        public double GetBonus(Func<double, double> func)
        {
            return func(GetValueOfProducts());
        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }

        //Ex59 øvelse 4.4
        public double GetTotalPrice(Func<double, double> func)
        {
            return GetValueOfProducts() - GetBonus(func);
        }
    }
}
