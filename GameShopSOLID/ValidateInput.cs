using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopSOLID
{
    public class ValidateInput : UserInput
    {
        private UserInput userInput;
        
        public ValidateInput(UserInput user)
        {
            userInput = user;
        }
        public ValidateInput() { }

        public bool ValidName()
        {
            string name = userInput.name;
            if (name.Length > 0 && name.Length <= 64 && name != " " && name!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidTaxOrDiscount()
        {
            string sTax = userInput.tax;
            if (sTax.EndsWith("%"))
            {
                sTax = sTax.Trim('%');
            }
            sTax.Trim();
            sTax = sTax.Replace('.', ',');
            if (Double.TryParse(sTax, out double tax) && tax >= 0 && sTax.Length <= 64)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidUPC()
        {
            string sUpc = userInput.name;
            if (Int32.TryParse(sUpc, out int upc) && sUpc.Length <= 64 && upc > 0 && sUpc!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidSelectiveDiscount()
        {
            string selectiveDiscount = userInput.selectiveDiscount;
            if (selectiveDiscount.ToLower() == "da" || selectiveDiscount.ToLower() == "ne")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidPrice()
        {
            string sRsd = userInput.price;
            if (sRsd.EndsWith("RSD"))
            {
                sRsd = sRsd.Replace("RSD", "");
            }
            sRsd.Trim();
            sRsd = sRsd.Replace('.', ',');
            if (Double.TryParse(sRsd, out double rsd) && rsd >= 0 && sRsd.Length <= 64)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
