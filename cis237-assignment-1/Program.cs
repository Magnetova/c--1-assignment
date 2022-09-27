// Cayden Greer
// CIS 237 - Fall 2022
// 09-27-2022 


using System;

namespace cis237_assignment_1
{
    class Program
    {
        /// <summary>
        /// Main body of program. No methods here, just points the program to which methods it needs to follow in the other sln classes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BeverageCollection beverageCollection = new BeverageCollection();
            UserInterface userInterface = new UserInterface();
            CSVProcessor csvProcessor = new CSVProcessor();
            int choice = userInterface.PrintMenu();
            bool load_complete = false;


            
            while (choice != 5)
            {


                if (choice == 1)
                {
                    //load file
                    //go to user interface to collect string for csv path
                    //store csvpath
                    //go to csv processor to load csv file into beverage array


                    if (load_complete == true)
                    {
                        Console.WriteLine("A file has already been loaded into the program. Please exit program if you wish to load in a different file.");
                    }
                    if (load_complete == false)
                    {
                        load_complete = csvProcessor.ImportCsv(userInterface.GetCsvPath(), beverageCollection);
                        Console.WriteLine("\n\nFile succesfully loaded!");
                    }
                        
                    


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
                    beverageCollection.AddNewBeverage(userInterface.NewBeverage(beverageCollection));
                    Console.WriteLine("\n\nNew beverage has been added!");
                }

                Console.WriteLine("\n\n\n");
                choice = userInterface.PrintMenu();
            }


            return;
         
            

            
        }
    }
}

