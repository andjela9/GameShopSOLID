using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopSOLID
{
    public class Product
    {
        private string name;
        private string tax;
        private string discount;
        private string upc;
        private string selectiveDiscount;
        private string price;
        private ParseInput parseInput = new ParseInput();

        public Product(ParseInput pi)
        {
            parseInput = pi;
        }

        public void SetName()
        {
            name = parseInput.ParseName();
        }

    }
}
