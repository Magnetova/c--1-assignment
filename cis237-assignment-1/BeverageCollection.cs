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
    internal class BeverageCollection
    {
        Beverage[] beverages = new Beverage[10000];
        CSVProcessor csvProcessor = new CSVProcessor();

        public string SearchList(string id)
        {
            string searchedBeverage = "";


            foreach (Beverage beverage in beverages)
            {
                if (beverage.Id == id)
                {
                    // Concat to the outputstring
                    searchedBeverage += beverage.ToString() +
                        Environment.NewLine;

                }
            }


            return searchedBeverage;
        }


        public void AddNewBeverage(Beverage newBeverage)
        {
            beverages = beverages.Append(newBeverage).ToArray();
            return;
            
        }

        public void LoadFile (string CSVpath)
        {
            csvProcessor.ImportCsv(CSVpath, beverages);
            return;
        }

        public string ToString()
        {
            string outputString = "";


            foreach (Beverage beverage in beverages)
            {
                if (beverage != null)
                {
                    // Concat to the outputstring
                    outputString += beverage.ToString() +
                        Environment.NewLine;
                   
                }
            }

            // Use the UI calss to print out the string
            return outputString;
        }

    }

        
}

