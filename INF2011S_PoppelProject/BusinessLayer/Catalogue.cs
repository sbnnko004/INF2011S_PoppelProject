using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_PoppelProject.BusinessLayer
{
    class Catalogue
    {
        List<Product> catalogue;

        #region sorting products in catalogue
        public void sortByPrice()
        {

        }
        public void sortByName()
        {

        }
        #endregion

        #region adding prpoducts to catalogue
        public void add(Product product)
        {
            catalogue.Add(product);
        }
        public void add(List<Product> products)
        {
            foreach (Product p in products)
            {
                add(p);
            }
        }
        #endregion

        #region constructors
        public Catalogue()
        {
            catalogue = new List<Product>();
        }
        public Catalogue(Product p)
        {
            catalogue = new List<Product>();
            add(p);
        }
        public Catalogue(List<Product> p)
        {
            catalogue = new List<Product>();
            add(p);
        }
        #endregion
    }
}
