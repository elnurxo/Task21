using System;
using System.Collections.Generic;
using System.Text;
using Task21.Enums;

namespace Task21.Models
{
    class CashRegister
    {
        private static int _count = 0;
        public double TotalAmount { get; set; }
        public int TotalSalesCount;
        public Currency _Currency;


        public CashRegister(double totalamount, Currency currency)
        {
            TotalAmount = totalamount;
            _Currency = currency;
        }

        public void AddNewSale(double amount, Currency currency)
        {
            TotalSalesCount = ++_count;
            if (_Currency != currency)
            {
                if (Currency.azn == _Currency)
                {
                    if (Currency.rubl == currency)
                    {
                        TotalAmount += amount * 0.023;
                    }
                    if (Currency.euro == currency)
                    {
                        TotalAmount += amount * 1.99;
                    }
                    if (Currency.dollar == currency)
                    {
                        TotalAmount += amount * 1.7;
                    }
                }
                if (Currency.dollar == _Currency)
                {
                    if (Currency.azn == currency)
                    {
                        TotalAmount += amount * 0.59;
                    }
                    else if (Currency.euro == currency)
                    {
                        TotalAmount += amount * 1.17;
                    }
                    else if (Currency.rubl == currency)
                    {
                        TotalAmount += amount * 0.014;
                    }
                }
                if (Currency.euro == _Currency)
                {
                    if (Currency.azn == currency)
                    {
                        TotalAmount += amount * 0.50;
                    }
                    else if (Currency.dollar == currency)
                    {
                        TotalAmount += amount * 0.85;
                    }
                    else if (Currency.rubl == currency)
                    {
                        TotalAmount += amount * 0.012;
                    }
                }
                if (Currency.rubl == _Currency)
                {
                    if (Currency.azn == currency)
                    {
                        TotalAmount += amount * 42.69;
                    }
                    else if (Currency.dollar == _Currency)
                    {
                        TotalAmount += amount * 72.58;
                    }
                    else if (Currency.euro == currency)
                    {
                        TotalAmount += amount * 84.89;
                    }
                }
            }
            else
            {
                TotalAmount += amount;
            }
            Console.WriteLine($"Satis Sayi:{TotalSalesCount}");
            Console.WriteLine($"TotalAmount:{TotalAmount}");
        }
        public void RemoveSale(double amount, Currency currency)
        {
            if (TotalSalesCount > 0)
            {
                if (TotalAmount >= amount)
                {
                    if (_Currency != currency)
                    {
                        if (Currency.azn == _Currency)
                        {
                            if (Currency.rubl == currency)
                            {
                                TotalAmount -= amount * 0.023;
                            }
                            if (Currency.euro == currency)
                            {
                                TotalAmount -= amount * 1.99;
                            }
                            if (Currency.dollar == currency)
                            {
                                TotalAmount -= amount * 1.7;
                            }
                        }
                        if (Currency.dollar == _Currency)
                        {
                            if (Currency.azn == currency)
                            {
                                TotalAmount -= amount * 0.59;
                            }
                            else if (Currency.euro == currency)
                            {
                                TotalAmount -= amount * 1.17;
                            }
                            else if (Currency.rubl == currency)
                            {
                                TotalAmount -= amount * 0.014;
                            }
                        }
                        if (Currency.euro == _Currency)
                        {
                            if (Currency.azn == currency)
                            {
                                TotalAmount -= amount * 0.50;
                            }
                            else if (Currency.dollar == currency)
                            {
                                TotalAmount -= amount * 0.85;
                            }
                            else if (Currency.rubl == currency)
                            {
                                TotalAmount -= amount * 0.012;
                            }
                        }
                        if (Currency.rubl == _Currency)
                        {
                            if (Currency.azn == currency)
                            {
                                TotalAmount -= amount * 42.69;
                            }
                            else if (Currency.dollar == _Currency)
                            {
                                TotalAmount -= amount * 72.58;
                            }
                            else if (Currency.euro == currency)
                            {
                                TotalAmount -= amount * 84.89;
                            }
                        }
                    }
                    else
                    {
                        TotalAmount -= amount;
                    }

                    TotalSalesCount--;
                }
                else
                    Console.WriteLine($"Satışda {amount} məbləg yoxdur.");

                Console.WriteLine($"TotalAmount:{TotalAmount}");
                Console.WriteLine($"Satis sayi:{TotalSalesCount}");
            }
            else
                Console.WriteLine($"Satis yoxdur \n TotalAmount:{TotalAmount} \n Satis sayi:{TotalSalesCount}");

        }
    }
}
