using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopSOLID
{
    public class UserInput
    {
        private string name;
        private string tax;
        private string discount;
        private string upc;
        private string selectiveDiscount;
        private string price;


        public string NameInput(string n)
        {
            //Console.WriteLine("Unesite naziv proizvoda. Za izlazak unesite exit");
            //name = Console.ReadLine();
            if(n.ToLower() == "exit")
            {
                return null;
            }
            else
            {
                name = n;
                return name;
            }
        }

        public string TaxInput(string t)
        {
            //Console.WriteLine("Unesite zeljeni procenat poreza: Za izlazak unesite exit");
            //tax = Console.ReadLine();
            if (t.ToLower() == "exit")
            {
                return null;
            }
            else
            {
                tax = t;
                return tax;
            }
        }

        public string DiscountInput(string d)
        {
            //Console.WriteLine("Unesite zeljeni procenat popusta: Za izlazak unesite exit");
            //discount = Console.ReadLine();
            if (d.ToLower() == "exit")
            {
                return null;
            }
            else
            {
                discount = d;
                return discount;
            }
        }

        public string UpcInput(string u)
        {
            //Console.WriteLine("Unesite upc: Za izlazak unesite exit");
            //upc = Console.ReadLine();
            if (u.ToLower() == "exit")
            {
                return null;
            }
            else
            {
                upc = u;
                return upc;
            }
        }

        public string SelectiveDiscountInput(string s)
        {
            //Console.WriteLine("Da li zelite obracun selektivnog popusta pre poreza? da/ne");
            //selectiveDiscount = Console.ReadLine();
            if (s.ToLower() == "exit")
            {
                return null;
            }
            else
            {
                selectiveDiscount = s;
                return selectiveDiscount;
            }
        }

        public string PriceInput(string p)
        {
            //Console.WriteLine("Unesite cenu: Za izlazak unesite exit");
            //price = Console.ReadLine();
            if (p.ToLower() == "exit")
            {
                return null;
            }
            else
            {
                price = p;
                return price;
            }
        }

        public string GetName()
        {
            return name;
        }


    }
}
