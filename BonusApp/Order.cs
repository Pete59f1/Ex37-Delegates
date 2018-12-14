using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        private BonusProvider bonus;
        private List<Product> products = new List<Product>();

        public BonusProvider Bonus
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
        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }
    }
}
