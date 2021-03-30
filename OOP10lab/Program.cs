using System;

namespace OOP10lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Valuta Converter-----" +
                              "\n-----Author: Rizat Orazalina-----\n");
            Dollar dollar = new Dollar();
            Ruble ruble = new Ruble();
            while (true)
            {
                line();
                try
                {
                    Console.WriteLine("Select:\n1-Convert To(from dollars/ruble to tenge)" +
                                      "\n2-Convert From(from tenge to dollars/ruble)" +
                                      "\n0-Exit the program");
                    line();
                    int selected = Int32.Parse(Console.ReadLine());
                    line();
                    if (selected == 1)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("----Convert to(from dollars/ruble to tenge)-----" +
                                                  "\nSelect:\n1-From Dollars\n2-From Ruble\n0-Back");
                                line();
                                int selectedConvertTo = Int32.Parse(Console.ReadLine());
                                line();


                                if (selectedConvertTo == 1)
                                {
                                    Console.WriteLine("You selected *Convert to(from *dollars* to tenge)*" +
                                                      "\nEnter the amount(sum):");
                                    double amount = double.Parse(Console.ReadLine());
                                    line();
                                    dollar.convertToTenge(amount);
                                    dollar.displayPrint();
                                    line();
                                }

                                if (selectedConvertTo == 2)
                                {

                                    Console.WriteLine("You selected *Convert to(from *ruble* to tenge)*" +
                                                      "\nEnter the amount(sum):");
                                    double amount = double.Parse(Console.ReadLine());
                                    line();
                                    ruble.convertToTenge(amount);
                                    ruble.displayPrint();
                                    line();
                                }

                                if (selectedConvertTo == 0)
                                {
                                    Console.WriteLine("...coming back\n");
                                    break;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Ooops ... "+e.Message);
                                line();
                            }
                        }
                    }

                    if (selected == 0)
                    {
                        Console.WriteLine("...exit the program");
                        Environment.Exit(0);
                    }
                    
                    if (selected == 2)
                    {
                        while (true)
                        {
                            
                            try{
                                Console.WriteLine("----Convert From(from tenge to dollars/ruble-----" +
                                                  "\nSelect:\n1-To Dollars\n2-To Ruble\n0-Back");
                                line();
                                int selectedConvertFrom = Int32.Parse(Console.ReadLine());
                                line();


                                if (selectedConvertFrom == 1)
                                {
                                    Console.WriteLine("You selected *Convert from(from tenge to *dollars*)*" +
                                                      "\nEnter the amount(sum):");
                                    double amount = double.Parse(Console.ReadLine());
                                    line();
                                    dollar.convertFromTenge(amount);
                                    dollar.displayPrint();
                                    line();
                                }

                                if (selectedConvertFrom == 2)
                                {

                                    Console.WriteLine("You selected *Convert to(from *ruble* to tenge)*" +
                                                      "\nEnter the amount(sum):");
                                    double amount = double.Parse(Console.ReadLine());
                                    line();
                                    ruble.convertFromTenge(amount);
                                    ruble.displayPrint();
                                    line();
                                }

                                if (selectedConvertFrom == 0)
                                {
                                    Console.WriteLine("...coming back\n");
                                    break;
                                }
                            }catch (Exception e)
                            {
                                Console.WriteLine("Ooops ...  "+e.Message);
                                line();
                            }
                        }
                        
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ooops... error!  "+e.Message);
                    line();
                }
            }
        }

        static void line()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }
}