using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopSOLID
{
    public class Output //: Product    //pitanje: greska u 14. liniji 
    {
        //private UserInput userInput;
        private Product product;
        //private Product product = new Product(userInput);         //pitanje greska za userInput  (ovo + 9. linija)
        

        //public Output(UserInput ui)
        //{
        //    product = new Product(ui);
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
            Console.WriteLine($"Popust = {product.Discount()}");
        }

        public void FinalPriceOutput()
        {
            Console.WriteLine($"Konacna cena = {product.FinalPrice()}");
        }


    }
}
