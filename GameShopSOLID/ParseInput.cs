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
            return Int32.Parse(sUpc);           //TryParse
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

        public Dictionary<int, double> ParseSelectiveBaseDiscount()
        {
            Dictionary<int, double> selectiveDict = new Dictionary<int, double>();
            foreach(KeyValuePair<string, string> kvp in userInput.selectiveDiscountBase)
            {
                int upc = Int32.Parse(kvp.Key);
                double discount = Double.Parse(kvp.Value);
                selectiveDict.Add(upc, discount);
            }
            return selectiveDict;
        }
        public bool IsRSDCost(string s)
        {
            s.Trim();
            return s.ToUpper().EndsWith("RSD");
        }

        public bool IsPercentCost(string s)
        {
            s.Trim();
            return s.EndsWith("%");

        }

        public Dictionary<string, double> ParseAdditionalCostsRSD()
        {
            Dictionary<string, double> additionalDictRSD = new Dictionary<string, double>();
            foreach(KeyValuePair<string, string> kvp in userInput.AdditionalCostsBase)
            {
                if(this.IsRSDCost(kvp.Value) && !this.IsPercentCost(kvp.Value))         //jeste dinarski, nije %
                {
                    string sRsd = kvp.Value.ToUpper();
                    sRsd = sRsd.Replace('.', ',');
                    if (sRsd.EndsWith("RSD"))
                    {
                        sRsd = sRsd.Replace("RSD", "");
                    }
                    sRsd.Trim();
                    double rsd = Double.Parse(sRsd);
                    additionalDictRSD.Add(kvp.Key, rsd);
                }
            }
            return additionalDictRSD;
        }

        public Dictionary<string, double> ParseAdditionalCostsPercent()
        {
            Dictionary<string, double> additionalDictPercent = new Dictionary<string, double>();
            foreach (KeyValuePair<string, string> kvp in userInput.AdditionalCostsBase)
            {
                if (!this.IsRSDCost(kvp.Value) && this.IsPercentCost(kvp.Value))         //nije dinarski, jeste %
                {
                    string sPercent = kvp.Value.ToUpper();
                    sPercent = sPercent.Replace('.', ',');
                    if (sPercent.EndsWith('%'))
                    {
                        sPercent = sPercent.Trim('%');
                    }
                    sPercent.Trim();
                    double percent = Double.Parse(sPercent);
                    additionalDictPercent.Add(kvp.Key, percent);
                }
            }
            return additionalDictPercent;
        }

    }
}
