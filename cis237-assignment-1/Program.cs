// Cayden Greer
// CIS 237 - Fall 2022
// 09-16-2022 


using System;

namespace cis237_assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage[] beverages = new Beverage[100000];

            UserInterface userInterface = new UserInterface();

            string pathToCsv = "../../../../beverage_list.csv";


            CSVProcessor csvProcessor = new CSVProcessor();

            csvProcessor.ImportCsv(pathToCsv, beverages);

            int choice = userInterface.GetUserInput();

            while (choice != 2)
            {
                if (choice == 1)
                {
                    string outputString = "";

                    foreach (Beverage beverage in beverages)
                    {
                        if (beverage != null)
                        {
                            outputString += beverage.ToString() +
                                Environment.NewLine;
                        }
                    }

                    userInterface.PrintList(outputString);
                }

                choice = userInterface.GetUserInput();


            }
        }
    }
}

