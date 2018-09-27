using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_PoppelProject.BusinessLayer
{
    class Price
    {
        decimal price;
        decimal discountPercentage;

        #region constructor
        public Price(decimal p)
        {
            price = p;
            discountPercentage = 0;
        }
        #endregion
        #region
        public decimal Discount
        {
            set
            {
                if (value>=0&&value<=100)
                {
                    discountPercentage = value;
                }
            }
            get
            {
                return discountPercentage;
            }
        }
        public decimal priceValue
        {
            set
            {
                price = value;
            }
            get
            {
                return price*(100-discountPercentage);
            }

        }
        public decimal getPriceBeforeDiscount()
        {
            return price;
        }
        #endregion
    }
}
