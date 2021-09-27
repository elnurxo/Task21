using System;
using Task21.Enums;
using Task21.Models;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Kassa da movcud mebleg:");
                double totalamount = double.Parse(Console.ReadLine());

                string[] types = Enum.GetNames(typeof(Currency));

                int i = 0;
                foreach (var item in types)
                {
                    Console.WriteLine($"{i + 1} {item}");
                    i++;
                }

                Console.WriteLine("Kassa valyutasi:");
                Currency currency = (Currency)int.Parse(Console.ReadLine());
                CashRegister cashRegister = new CashRegister(totalamount, currency);


                do
                {
                    Console.WriteLine("1 - Satis elave et.");
                    Console.WriteLine("2 - Satis Sil.");
                    Console.WriteLine("3 - Sistemden cixis.");

                    string button = Console.ReadLine();
                    switch (button)
                    {
                        case "1":
                            AddSale(ref cashRegister);
                            break;
                        case "2":
                            RemoveSale(ref cashRegister);
                            break;
                        case "3":
                            Console.WriteLine("sistemden cixildi");
                            return;
                        default:
                            Console.WriteLine("Yalnis secim.");
                            break;


                            static void AddSale(ref CashRegister cashRegister)
                            {
                                Console.WriteLine("Mebleg:");
                                double amount = double.Parse(Console.ReadLine());

                                string[] types = Enum.GetNames(typeof(Currency));

                                int i = 0;
                                foreach (var item in types)
                                {
                                    Console.WriteLine($"{i + 1} {item}");
                                    i++;
                                }

                                Console.WriteLine("Sececeyiniz valyuta:");
                                Currency currency = (Currency)int.Parse(Console.ReadLine());

                                cashRegister.AddNewSale(amount, currency);
                            }

                            static void RemoveSale(ref CashRegister cashRegister)
                            {
                                Console.WriteLine("Silinecek mebleg:");
                                double amount = double.Parse(Console.ReadLine());

                                string[] types = Enum.GetNames(typeof(Currency));

                                int i = 0;
                                foreach (var item in types)
                                {
                                    Console.WriteLine($"{i + 1} {item}");
                                    i++;
                                }

                                Console.WriteLine("Valyuta:");
                                Currency currency = (Currency)int.Parse(Console.ReadLine());

                                cashRegister.RemoveSale(amount, currency);
                            }
                    }

                } while (true);
            }
        }
    }
}
