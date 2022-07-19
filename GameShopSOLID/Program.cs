using System;

namespace GameShopSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


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


                UserInput userInput = new UserInput();                                      
                ValidateInput validateInput = new ValidateInput(userInput);
                Console.WriteLine("------------------UNOS BAZE SELEKTIVNIH POPUSTA------------------");       //pitanje exception 
                Console.WriteLine("***Za zavrsetak unesite STOP");
                userInput.SelectiveDiscountBaseInput();
                if (!validateInput.ValidateSelectiveDiscountBase())
                {
                    Console.WriteLine("Greska u unosu baze selektivnih popusta");
                }

                //value tipovi su int, bool
                //reference su klase
                //zato se pazi dokle koji zivi

                Console.WriteLine("-----------------------------UNOS PARAMETARA-----------------------------");
                Console.WriteLine("Unesite naziv proizvoda. Za izlazak unesite exit");
                string name = Console.ReadLine();
                if (userInput.NameInput(name) == null)
                {
                    Console.WriteLine("***Dovidjenja!");
                    break;
                }
                if (!validateInput.ValidName())             //zasto validateInput ima poslednju kopiju userInput a ne onu iz 30. linije; jer je klasa
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
                if (!validateInput.ValidTaxOrDiscount())
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
                if (!validateInput.ValidTaxOrDiscount())
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
                if (!validateInput.ValidUPC())
                {
                    Console.WriteLine("~Pogresan unos! UPC mora biti pozitivan ceo broj.");
                    continue;
                }
                

                Console.WriteLine("Da li zelite obracun selektivnog popusta pre poreza? da/ne");
                string discountBefore = Console.ReadLine();
                if (userInput.DiscountBeforeInput(discountBefore) == null)
                {
                    Console.WriteLine("***Dovidjenja!");
                    break;
                }
                if (!validateInput.ValidDiscountBefore())
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
                if (!validateInput.ValidPrice())
                {
                    Console.WriteLine("~Pogresan unos! Cena mora biti broj");
                    continue;
                }

                //Console.WriteLine("------------------UNOS BAZE SELEKTIVNIH POPUSTA------------------");       //pitanje exception 
                //Console.WriteLine("***Za zavrsetak unesite STOP");
                //userInput.SelectiveDiscountBaseInput(validateInput);


                ParseInput parseInput = new ParseInput(userInput);
                Product product = new Product(userInput);
                Console.WriteLine(product);

                Output output = new Output(product);
                output.DiscountOutput();
                output.TaxOutput();
                output.SelectiveDiscount();
                output.FinalPriceOutput();
                //output.SelectiveBaseDiscountOutput();

            }
        }
    }
}
