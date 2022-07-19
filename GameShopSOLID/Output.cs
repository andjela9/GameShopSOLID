using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopSOLID
{
    public class Output //:  Product    //pitanje: greska u 14. liniji 
    {
        //private UserInput userInput;
        private Product product;
        //private Product product = new Product(userInput);         //pitanje greska za userInput  (ovo + 9. linija)
        

        //public Output(UserInput ui):base(ui)
        //{
        //   product = new Product(ui);
        //}

        public Output(Product p)
        {
            product = p;
        }


        public void TaxOutput()
        {
            Console.WriteLine($"Porez = {product.Tax()}");
        }

        public void DiscountOutput()
        {
            Console.WriteLine($"Ukupni popust = {product.TotalDiscount()}");
        }

        public void SelectiveDiscount()
        {
            Console.WriteLine($"Selektivni popust = {product.SelectiveDiscount()}");
        }

        public void FinalPriceOutput()
        {
            Console.WriteLine($"Konacna cena = {product.FinalPrice()}");
        }
        //public void SelectiveBaseDiscountOutput()
        //{
        //    foreach(KeyValuePair<int, double> kvp in product.selectiveDiscountBase)
        //    {
        //        Console.WriteLine($"UPC {kvp.Key}, Popust {kvp.Value}");
        //    }
        //}

        public string AdditionalCostsOutput()
        {
            //Console.WriteLine("Dinarski troskovi: \n");
            string s = "";
            foreach (KeyValuePair<string, double> kvp in product.additionalCostsRSD)
            {
                //Console.WriteLine($"{kvp.Key} = {kvp.Value} RSD");
                //s += $"{kvp.Key} = {kvp.Value} RSD\n";
                s = string.Concat(s, $"{kvp.Key} = {kvp.Value} RSD\n");
                //string builder; string format izguglati
            }
            //Console.WriteLine("Troskovi u procentima: \n");
            foreach (KeyValuePair<string, double> kvp in product.additionalCostsPercent)
            {
                //Console.WriteLine($"{kvp.Key} = {(kvp.Value/100) * price} RSD");
                //s += $"{kvp.Key} = {(kvp.Value / 100) * price} RSD\n";
                //s = string.Concat(s, $"{kvp.Key} = {Math.Round((kvp.Value / 100) * price, 2)} RSD\n");
                s = string.Concat(s, $"{kvp.Key} = {kvp.Value} %\n");
            }
            return s;
        }


    }
}
