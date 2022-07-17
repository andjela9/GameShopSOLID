using System;

namespace GameShopSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                UserInput userInput = new UserInput();
                ValidateInput validateInput = new ValidateInput();
                ////userInput.NameInput();
                //if (userInput.NameInput() == null || userInput.TaxInput() == null || userInput.DiscountInput() == null || userInput.UpcInput() == null || 
                //    userInput.PriceInput() == null || userInput.SelectiveDiscountInput() == null)
                //{
                //    Console.WriteLine("***Dovidjenja!");
                //    break;
                //}
                //Console.WriteLine($"ISPIS IMENA {userInput.name}");
                //userInput.TaxInput();
                //userInput.DiscountInput();
                //userInput.UpcInput();
                //userInput.PriceInput();
                //userInput.SelectiveDiscountInput();
                //ValidateInput validateInput = new ValidateInput(userInput);
                //validateInput.ValidName(userInput.NameInput());
                //Console.WriteLine($"Valid Name {validateInput.ValidName(userInput.NameInput())}");


                Console.WriteLine("Unesite naziv proizvoda. Za izlazak unesite exit");
                string name = Console.ReadLine();
                if (userInput.NameInput(name) == null)
                {
                    Console.WriteLine("***Dovidjenja!");
                    break;
                }
                if (!validateInput.ValidName(userInput.NameInput(name)))
                {
                    Console.WriteLine("~Pogresan unos! Naziv ne sme biti prazan ili veci od 64 karaktera.");
                    continue;
                }
                

                Console.WriteLine("Unesite zeljeni procenat poreza: Za izlazak unesite exit");
                string tax = Console.ReadLine();
                if (userInput.TaxInput(tax) == null)
                {
                    Console.WriteLine("***Dovidjenja!");
                    break;
                }
                if (!validateInput.ValidTaxOrDiscount(userInput.TaxInput(tax)))
                {
                    Console.WriteLine("~Pogresan unos! Primeri ispravnog unosa: 14.4%; 14,4%; 14.4; 14,4");
                    continue;
                }
                

                Console.WriteLine("Unesite zeljeni procenat popusta: Za izlazak unesite exit");
                string discount = Console.ReadLine();
                if (userInput.DiscountInput(discount) == null)
                {
                    Console.WriteLine("***Dovidjenja!");
                    break;
                }
                if (!validateInput.ValidTaxOrDiscount(userInput.TaxInput(discount)))
                {
                    Console.WriteLine("~Pogresan unos! Primeri ispravnog unosa: 14.4%; 14,4%; 14.4; 14,4");
                    continue;
                }
                

                Console.WriteLine("Unesite upc: Za izlazak unesite exit");
                string upc = Console.ReadLine();
                if (userInput.UpcInput(upc) == null)
                {
                    Console.WriteLine("***Dovidjenja!");
                    break;
                }
                if (!validateInput.ValidUPC(userInput.UpcInput(upc)))
                {
                    Console.WriteLine("~Pogresan unos! UPC mora biti pozitivan ceo broj.");
                    continue;
                }
                

                Console.WriteLine("Da li zelite obracun selektivnog popusta pre poreza? da/ne");
                string selectiveDiscount = Console.ReadLine();
                if (userInput.SelectiveDiscountInput(selectiveDiscount) == null)
                {
                    Console.WriteLine("***Dovidjenja!");
                    break;
                }
                if (!validateInput.ValidSelectiveDiscount(userInput.SelectiveDiscountInput(selectiveDiscount)))
                {
                    Console.WriteLine("~Pogresan unos! Unesite da ili ne");
                    continue;
                }
                

                Console.WriteLine("Unesite cenu: Za izlazak unesite exit");
                string price = Console.ReadLine();
                if (userInput.PriceInput(price) == null) {
                    Console.WriteLine("***Dovidjenja!");
                    break;
                }
                if (!validateInput.ValidPrice(userInput.PriceInput(price)))
                {
                    Console.WriteLine("~Pogresan unos! Cena mora biti broj");
                    continue;
                }

                ParseInput parseInput = new ParseInput(userInput, validateInput);
            }
        }
    }
}
