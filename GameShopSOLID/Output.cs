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


    }
}
