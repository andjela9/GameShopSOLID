using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopSOLID
{
    public class ValidateInput 
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
            string sUpc = userInput.upc;                //ovde se javlja exception 
            if (Int32.TryParse(sUpc, out int upc) && sUpc.Length <= 64 && upc > 0 && sUpc!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidDiscountBefore()
        {
            string discountBefore = userInput.discountBefore;
            if (discountBefore.ToLower() == "da" || discountBefore.ToLower() == "ne")
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

        public bool ValidateSelectiveDiscountBase()
        {
            //bool valid = true;
            Dictionary<string, string> sSelectiveDiscountBase = userInput.selectiveDiscountBase;
            foreach(KeyValuePair<string, string> kvp in sSelectiveDiscountBase)
            {
                
                if(!(Int32.TryParse(kvp.Key, out int upc) && upc >=0))
                {
                    //valid = false;
                    return false;
                }
                if(!(Double.TryParse(kvp.Value, out double discount) && discount >= 0))
                {
                    //valid = false;
                    return false;
                }
            }
            //return valid;
            return true;
        }

        public bool ValidateAdditionalCostsInput()
        {
            Dictionary<string, string> sAdditional = userInput.AdditionalCostsBase;
            foreach(KeyValuePair<string, string> kvp in sAdditional)
            {
                if (String.IsNullOrWhiteSpace(kvp.Key))
                {
                    return false;
                }
                if(!(kvp.Value.ToUpper().EndsWith("RSD") || kvp.Value.EndsWith("%")))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
