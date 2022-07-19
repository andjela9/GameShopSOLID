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
        private Dictionary<int, double> selectiveDiscountBase;
        public Dictionary<string, double> additionalCostsRSD;
        public Dictionary<string, double> additionalCostsPercent;

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
            selectiveDiscountBase = parseInput.ParseSelectiveBaseDiscount();
            additionalCostsRSD = parseInput.ParseAdditionalCostsRSD();
            additionalCostsPercent = parseInput.ParseAdditionalCostsPercent();
        }

        public override string ToString()
        {
            return $"Ime: {this.name}, Porez: {this.tax}, Popust: {this.discount}, UPC: {this.upc},  Selektivni popust: {this.discountBefore}, Cena: {this.price}\n";
        }

        public double Discount()
        {
            return Math.Round((discount / 100) * price, 2);
        }

        public double SelectiveDiscount()
        {
            if (this.selectiveDiscountBase.ContainsKey(this.upc))
            {
                return Math.Round((selectiveDiscountBase[upc] / 100) * this.price, 2);
            }
            else
            {
                return 0;
            }

        }

        public double TotalDiscount()
        {
            if (discountBefore)
            {
                double prviPopust = SelectiveDiscount();             //prvi popust
                //double drugiPopust = Discount(disc, price - prviPopust);        //drugi popust na novu, umanjenu cenu

                double drugiPopust = Math.Round((discount / 100) * (price-prviPopust), 2);
                return prviPopust + drugiPopust;
            }
            else
            {
                return Math.Round(this.SelectiveDiscount() + this.Discount(), 2);
            }
        }


        public double Tax()
        {
            if (discountBefore)
            {
                return Math.Round((tax / 100) * (price - SelectiveDiscount()), 2);
            }
            else
            {
                return Math.Round((tax / 100) * price, 2);
            }
        }

        public double FinalPrice()
        {
            return Math.Round(price - TotalDiscount() + Tax(), 2);
        }











    }
}
