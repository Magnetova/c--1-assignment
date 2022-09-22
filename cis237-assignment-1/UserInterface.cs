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

            int choice = this.GetUserInput();

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
            Console.WriteLine("ID \t Name \t Pack \t Price \t Active");
            Console.WriteLine(outputList);
            return;
        }

        public Beverage NewBeverage()
        {
            Beverage newBeverage = new Beverage();

            Console.WriteLine("Id of new beverage: ");
            newBeverage.Id = Console.ReadLine();
       

            Console.WriteLine("Name of new beverage: ");
            newBeverage.Name = Console.ReadLine();


            Console.WriteLine("Pack of new beverage: ");
            newBeverage.Pack = Console.ReadLine();


            Console.WriteLine("Price of new beverage:");
            newBeverage.Price = Decimal.Parse(Console.ReadLine());


            Console.WriteLine("Is the new beverage active?(0 for no, 1 for yes): ");
            if(Console.ReadLine() != "1")
            {
                newBeverage.Active = true;
                
            }
            else if(Console.ReadLine() != "0")
            {
                newBeverage.Active = false;
            }

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
            Console.WriteLine("Please enter beverage ID: ");
            string beverageid = Console.ReadLine();
            return beverageid;

        }

        public void PrintSearchBeverage(string searchBeverage)
        {
            Console.WriteLine(searchBeverage);
            Console.WriteLine();
            return;

        }



    }
}
