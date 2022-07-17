using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopSOLID
{
    public class ParseInput 
    {
        private UserInput userInput = new UserInput();

        public ParseInput(UserInput ui)
        {
            userInput = ui;
        }

        public string ParseName()
        {
            string name = userInput.name;
            //string name = userInput.NameInput(s);     trazi parametar
            return name.Trim();
        }

        public int ParseUPC()
        {
            string sUpc = userInput.upc;
            return Int32.Parse(sUpc);
        }

        public double ParseTax()
        {
            string sTax = userInput.tax;
            if (sTax.EndsWith("%"))
            {
                sTax = sTax.Trim('%');
            }
            sTax.Trim();
            sTax = sTax.Replace('.', ',');
            return Double.Parse(sTax);
        }

        public double ParseDiscount()
        {
            string sDiscount = userInput.discount;
            if (sDiscount.EndsWith("%"))
            {
                sDiscount = sDiscount.Trim('%');
            }
            sDiscount.Trim();
            sDiscount = sDiscount.Replace('.', ',');
            return Double.Parse(sDiscount);
        }

        public double ParsePrice()
        {
            string sRsd = userInput.price;
            if (sRsd.EndsWith("RSD"))
            {
                sRsd = sRsd.Replace("RSD", "");
            }
            sRsd.Trim();
            sRsd = sRsd.Replace('.', ',');
            return Double.Parse(sRsd);
        }

        public bool ParseDiscountBefore()
        {
            string sDiscountBefore = userInput.discountBefore;
            if(sDiscountBefore.ToLower() == "da")
            {
                return true;
            }
            else
                return false;
        }


    }
}
