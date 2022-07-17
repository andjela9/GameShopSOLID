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
        private bool selectiveDiscount;
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
            selectiveDiscount = parseInput.ParseSelectiveDiscount();
            price = parseInput.ParsePrice();
        }

        public override string ToString()
        {
            return $"Ime: {this.name}, Porez: {this.tax}, Popust: {this.discount}, UPC: {this.upc},  Selektivni popust: {this.selectiveDiscount}, Cena: {this.price}\n";
        }







    }
}
