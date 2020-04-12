using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Buyer
    {
        public List<Products> _productList = new List<Products>();
        public int _cash;
        public Buyer(List<Products> productList, int cash)
        {
            this._productList = productList;
            this._cash = cash;

        }
    }
}
