using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopSOLID
{
    public class ParseInput
    {
        private UserInput userInput = new UserInput();
        private ValidateInput validateInput = new ValidateInput();

        public ParseInput(UserInput ui, ValidateInput vi)
        {
            userInput = ui;
            validateInput = vi;
        }

        public string ParseName(string name)
        {
            if (validateInput.ValidName())
            {

            }
            //return name.Trim();
        }

        public int ParseUPC(string sUpc)
        {
            return Int32.Parse(sUpc);
        }

        public double ParseTaxOrDiscount(string sTax)
        {
            if (sTax.EndsWith("%"))
            {
                sTax = sTax.Trim('%');
            }
            sTax.Trim();
            sTax = sTax.Replace('.', ',');
            return Double.Parse(sTax);
        }

        public double ParsePrice(string sRsd)
        {
            if (sRsd.EndsWith("RSD"))
            {
                sRsd = sRsd.Replace("RSD", "");
            }
            sRsd.Trim();
            sRsd = sRsd.Replace('.', ',');
            return Double.Parse(sRsd);
        }


    }
}
