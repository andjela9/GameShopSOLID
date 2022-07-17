using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopSOLID
{
    public class Product 
    {
        private string name;
        private double tax;
        private double discount;
        private int upc;
        private bool discountBefore;
        private double price;
        private UserInput ui;
        private ParseInput parseInput;

        //public Product(ParseInput pi)
        //{
        //    //parseInput = pi;
        //}

        public Product(UserInput ui)
        {
            parseInput = new ParseInput(ui);
            name = parseInput.ParseName();
            tax = parseInput.ParseTax();
            discount = parseInput.ParseDiscount();
            upc = parseInput.ParseUPC();
            discountBefore = parseInput.ParseDiscountBefore();
            price = parseInput.ParsePrice();
        }

        public override string ToString()
        {
            return $"Ime: {this.name}, Porez: {this.tax}, Popust: {this.discount}, UPC: {this.upc},  Selektivni popust: {this.discountBefore}, Cena: {this.price}\n";
        }

        public double Discount()
        {
            return Math.Round((discount / 100) * price, 2);
        }

        public double Tax()
        {
           // if (discountBefore)
           // {
           //     return Math.Round((tax / 100) * (price - selectiveDiscount()), 2);

           // }
          //  else
          //  {
                return Math.Round((tax / 100) * price, 2);
          //  }
        }

        public double FinalPrice()
        {
            return Math.Round(price - Discount() + Tax(), 2);
        }











    }
}
