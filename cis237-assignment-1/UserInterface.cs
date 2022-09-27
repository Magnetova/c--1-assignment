// Cayden Greer
// CIS 237 - Fall 2022
// 09-27-2022 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_1
{
    internal class UserInterface
    {
        /// <summary>
        /// Prints a menu on the console for the user to view their available options to choose from
        /// </summary>
        /// <returns> An integer that the user typed in to make their choice based on the provided menu </returns>
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


        /// <summary>
        /// Collects the user's input via the console line for their menu choice
        /// </summary>
        /// <returns> An integer converted from a string that represents the users choice </returns>
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



        /// <summary>
        /// Prints the list of all the beverages so that the view can view all the information about every beverage in the array beverages
        /// Extra formating printed in the console to make the heading of the list so the user can easily identify what value corresponds to for each beverage
        /// </summary>
        /// <param name="outputList"> A single string that contains the entire array of beverages that has been converted into a string </param>
        public void PrintList(string outputList)
        {
            // If there is nothing in the list, then the message will be displayed
            if (outputList == null)
            {
                Console.WriteLine("There is nothing in the list. Please create list and try again.");
            }
            else
            {
                Console.WriteLine("Printing the List");
                Console.WriteLine("|  ID           |  Name                                                        |  Pack                   |  Price        |  Active");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(outputList);
                Console.WriteLine("\n\nList has been printed!");
            }
            return;
        }


        /// <summary>
        /// Collects the user given information about a new beverage the user wants to add into a new beverage object
        /// Separately promts the user to enter id, name, price, pack, and active, taking the user input and setting the corresponding beverage field equal to the response
        /// </summary>
        /// <param name="beverageCollection"> An instance of the BeverageCollection class to be able to pass the new beverage object into BeverageCollection methods </param>
        /// <returns> A Beverage type object that contains the information of the user inputed beverage </returns>
        public Beverage NewBeverage(BeverageCollection beverageCollection)
        {
            Beverage newBeverage = new Beverage();
            string active, price = "";
            bool checker;


            // this do statement is making sure the user entered an id that is not already in use by a different beverage
            // it will repeat until the user enters a unique id
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


            // this do statement is making sure the user entered a decimal value which is the only accepted entry
            // it will repeat until the user enters a valid entry
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


            // this do statement is making sure the user entered a '0' or a '1' which are the only valid entries
            // it will repeat until the user enters a valid entry
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


        /// <summary>
        /// Asks the user to enter a path to the csv file they wish to use and stores the user input into a string
        /// </summary>
        /// <returns> A string that contains the path to the csv file </returns>
        public string GetCsvPath()
        {
            Console.WriteLine("Please enter path to CSV File");
          
            string csvPath = Console.ReadLine();
            return csvPath;
        }

        
        /// <summary>
        /// Prints error message on the console if the user failed to select an available option from the menu
        /// </summary>
        private void PrintErrorMessage()
        {
            Console.WriteLine("This is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();

        }


        /// <summary>
        /// Asks the user to enter the id they would like to use when adding in a new beverage from the console
        /// </summary>
        /// <returns> A string of the id entered by the user </returns>
        public string GetBeverageID()
        {
            Console.Write("Please enter beverage ID: ");
            string beverageid = Console.ReadLine();
            Console.WriteLine();
            return beverageid;

        }


        /// <summary>
        /// Prints the beverage that was searched for by the user
        /// Extra formating printed in the console to make the heading of the searched beverage so that the user can identify each beverage field
        /// </summary>
        /// <param name="searchBeverage"> A Beverage type object that has been converted to a string from the beverages array </param>
        public void PrintSearchBeverage(string searchBeverage)
        {
            // The beverage will not be printed if there was no match
            if (searchBeverage != null)
            {
                Console.WriteLine("|  ID           |  Name                                                        |  Pack                   |  Price        |  Active");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(searchBeverage);

            }
            
            return;

        }



    }
}
