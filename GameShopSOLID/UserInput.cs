using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopSOLID
{
    public class UserInput : ValidateInput
    {
        //private string name;
        //private string tax;
        //private string discount;
        //private string upc;
        //private string selectiveDiscount;
        //private string price;

        public string name { get; set; }
        public string tax;
        public string discount;
        public string upc;
        public string discountBefore;
        public string price;
        public Dictionary<string, string> selectiveDiscountBase = new Dictionary<string, string>();
        public Dictionary<string, string> AdditionalCostsBase = new Dictionary<string, string>();

        public string GetName()
        {
            return this.name;
        }

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

        public string DiscountBeforeInput(string s)
        {
            //Console.WriteLine("Da li zelite obracun selektivnog popusta pre poreza? da/ne");
            //selectiveDiscount = Console.ReadLine();
            if (s.ToLower() == "exit")
            {
                return null;
            }
            else
            {
                discountBefore = s;
                return discountBefore;
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

        public Dictionary<string, string> SelectiveDiscountBaseInput()      //prva verzija je bila bez parametara, na to se odnosi pitanje
        {
            while (true)
            {
                Console.WriteLine("Unesite UPC");
                upc = Console.ReadLine();
                if (upc.ToLower() == "stop") break;
                Console.WriteLine("Unesite popust");
                discount = Console.ReadLine();
                if (discount.ToLower() == "stop") break;
                try
                {
                    selectiveDiscountBase.Add(upc, discount);
                }
                catch
                {
                    Console.WriteLine("Unet je UPC koji vec postoji u bazi! Unos nece biti dodat u bazu");
                }
            }
            return selectiveDiscountBase;
        }

        public Dictionary<string, string> InputAdditionalCosts()
        {
            while (true)
            {
                Console.WriteLine("Unesite naziv troska");
                name = Console.ReadLine();
                if (name.ToLower() == "stop") break;
                Console.WriteLine("Unesite iznos RSD ili %");
                string trosak = Console.ReadLine();
                if (trosak.ToLower() == "stop") break;
                try
                {
                    AdditionalCostsBase.Add(name, trosak);
                }
                catch
                {
                    Console.WriteLine("Unet je naziv koji vec postoji u bazi! Unos nece biti dodat u bazu");
                }
            }
            return AdditionalCostsBase;
        }


    }
}
