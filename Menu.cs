﻿using holidaymaker_group2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace holidaymaker_group2;

public class Menu(NpgsqlDataSource db)

{
    private enum Type 
    {
        Main,
        Customers,
        Bookings,
        Search,
        Exit
    }

    async public Task Main()
    {


        Type menu = Type.Main;

        while (true)
        {
            if (menu.Equals(Type.Main))
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("             The HolidayMaker               ");
                Console.WriteLine("|------------------------------------------|");
                Console.WriteLine("| 1. Customers                             |");
                Console.WriteLine("| 2. Bookings                              |");
                Console.WriteLine("| 3. Search                                |");
                Console.WriteLine("| 4. Exit                                  |");
                Console.WriteLine("|------------------------------------------|");
            }


            if (menu.Equals(Type.Main))
            {
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        menu = Type.Customers;
                        break;
                    case "2":
                        menu = Type.Bookings;
                        break;
                    case "3":
                        menu = Type.Search;
                        break;
                    case "4":
                        menu = Type.Exit;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You didn't pick a valid option.");
                        Console.WriteLine("Please press any key to continue!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

            if (menu.Equals(Type.Customers))
            {
                Console.Clear();
                Console.WriteLine("*** Customers ***");
                Console.WriteLine();
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Edit");
                Console.WriteLine("3. Display All");
                Console.WriteLine("4. Return to Main menu");
                Console.WriteLine("5. Exit HolidayMaker");

                switch (Console.ReadLine())
                {
                    case "1":
                        //Customers.Reg(); 
                        break;
                    case "2":
                        //Customers.Edit();
                        break;
                    case "3":
                        //Customers.Display();
                        break;
                    case "4":
                        menu = Type.Main;
                        continue;
                    case "5":
                        menu = Type.Exit;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You didn't pick a valid option.");
                        Console.WriteLine("Please press any key to continue!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

            if (menu.Equals(Type.Bookings))
            {

                Console.Clear();
                Console.WriteLine("*** Bookings ***");
                Console.WriteLine();
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Edit");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. Return to Main menu");
                Console.WriteLine("5. Exit HolidayMaker");

                switch (Console.ReadLine())
                {
                    case "1":
                        //Bookings.Create();
                        break;
                    case "2":
                        //Bookings.Edit();
                        break;
                    case "3":
                        //Bookings.Delete();
                        break;
                    case "4":
                        menu = Type.Main;
                        continue;
                    case "5":
                        menu = Type.Exit;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You didn't pick a valid option.");
                        Console.WriteLine("Please press any key to continue!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }


            if (menu.Equals(Type.Search))
            {
                Console.Clear();
                Console.WriteLine("*** Search ***");
                Console.WriteLine();
                Console.WriteLine("1. Rooms");
                Console.WriteLine("2. Locations");
                Console.WriteLine("3. Bookings");
                Console.WriteLine("4. Customers");

                Console.WriteLine("5. what else?");
                Console.WriteLine("6. what else?");
                Console.WriteLine("7. Return to Main menu");
                Console.WriteLine("8. Exit HolidayMaker");

                switch (Console.ReadLine())
                {
                    case "1":
                        //Search.Rooms();
                        break;
                    case "2":
                        //Search.Locations();
                        break;
                    case "3":
                        //Search.Bookings();
                        break;
                    case "4":
                        //Search.Customers();
                        break;
                    case "5":
                        //Search.?();
                        break;
                    case "6":
                        //Search.?();
                        break;
                    case "7":
                        menu = Type.Main;
                        continue;
                    case "8":
                        menu = Type.Exit;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You didn't pick a valid option.");
                        Console.WriteLine("Please press any key to continue!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }


            if (menu.Equals(Type.Exit))
            {
                Console.Clear();
                Console.WriteLine("The HolidayMaker has been shut down successfully.");
                break;
            }




        }






    }

}