// Cayden Greer
// CIS 237 - Fall 2022
// 09-16-2022 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_1
{
    internal class UserInterface
    {
        public int PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Load File");
            Console.WriteLine("2. Print List");
            Console.WriteLine("3. Search List");
            Console.WriteLine("4. Add New Beverage");
            Console.WriteLine("5. Exit");
            Console.Write("Select Option: ");
            int choice = this.GetUserInput();
            Console.WriteLine();

            return choice;
        }



        public int GetUserInput()
        {

            string input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                this.PrintErrorMessage();

                this.PrintMenu();

                input = Console.ReadLine();
            }

            return Int32.Parse(input);
        }




        public void PrintList(string outputList)
        {
            Console.WriteLine("Printing the List");
            Console.WriteLine("|  ID           |  Name                                                        |  Pack                   |  Price        |  Active");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(outputList);
            return;
        }

        public Beverage NewBeverage(BeverageCollection beverageCollection)
        {
            Beverage newBeverage = new Beverage();
            string active, price = "";
            bool checker;
            do
            {
                Console.Write("Id of new beverage: ");
                newBeverage.Id = Console.ReadLine();
                checker = beverageCollection.CheckBeverageId(newBeverage.Id);
            }
            while (checker == false);
            Console.WriteLine();


            Console.Write("Name of new beverage: ");
            newBeverage.Name = Console.ReadLine();
            Console.WriteLine();


            Console.Write("Pack of new beverage: ");
            newBeverage.Pack = Console.ReadLine();
            Console.WriteLine();

            do
            {
                Console.Write("Price of new beverage:");
                try
                {
                    price = Console.ReadLine();
                    newBeverage.Price = Decimal.Parse(price);
                    checker = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("The entered price " + "'" + price + "'" + " is not a decimal value. Please enter a decimal value.");
                    checker = false;
                }
            }
            while (checker == false);
            Console.WriteLine();

            do
            {
                Console.WriteLine("Is the new beverage active?(0 for False, 1 for True): ");
                active = Console.ReadLine();

                if (active == "1")
                {
                    newBeverage.Active = true;
                    checker = true;
                }
                else if (active == "0")
                {
                    newBeverage.Active = false;
                    checker = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again. ");
                    checker = false;
                }
                
            }
            while (checker == false);
            Console.WriteLine();

            return newBeverage;


        }



        public string GetCsvPath()
        {
            Console.WriteLine("Please enter path to CSV File");
          
            string csvPath = Console.ReadLine();
            return csvPath;
        }
        

        private void PrintErrorMessage()
        {
            Console.WriteLine("This is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();

        }

        public string GetBeverageID()
        {
            Console.Write("Please enter beverage ID: ");
            string beverageid = Console.ReadLine();
            return beverageid;

        }

        public void PrintSearchBeverage(string searchBeverage)
        {
            Console.WriteLine("|  ID           |  Name                                                        |  Pack                   |  Price        |  Active");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(searchBeverage);
          
            return;

        }



    }
}
