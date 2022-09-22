﻿// Cayden Greer
// CIS 237 - Fall 2022
// 09-16-2022 


using System;

namespace cis237_assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageCollection beverageCollection = new BeverageCollection();
            UserInterface userInterface = new UserInterface();
            CSVProcessor csvProcessor = new CSVProcessor();
            int choice = userInterface.PrintMenu();

            while (choice != 5)
            {


                if (choice == 1)
                {
                    //load file
                    //go to user interface to collect string for csv path
                    //store csvpath
                    //go to csv processor to load csv file into beverage array

                    csvProcessor.ImportCsv(userInterface.GetCsvPath());
                }
                else if (choice == 2)
                {
                    //print the list
                    //go to user interface to print the list

                    userInterface.PrintList(beverageCollection.CollectionToString());
                }
                else if (choice == 3)
                {
                    //search list
                    //go to user interface to collect beverage id string
                    //go to beverage collection to find beverage with id
                    //go to user interface to print beverage


                    userInterface.PrintSearchBeverage(beverageCollection.SearchList(userInterface.GetBeverageID()));
                }
                else if (choice == 4)
                {
                    //add new beverage
                    //go to user interface to collect id, name, pack, price, and active
                    //go to beverage collection to load the new beverage into the array
                    beverageCollection.AddNewBeverage(userInterface.NewBeverage());
                }

                Console.WriteLine();
                choice = userInterface.PrintMenu();
            }


            return;
         
            

            
        }
    }
}

