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

        public string SearchList(string id)
        {
            string searchedBeverage = "No Beverage with id "+ "'" +id + "'" + " was found.";


            foreach (Beverage beverage in beverages)
            {
                if (beverage != null)
                {
                    if (beverage.Id == id)
                    {
                        // Concat to the outputstring
                        searchedBeverage = "|  " + beverage.Id.ToString().PadRight(13) + "|  " + beverage.Name.ToString().PadRight(60) + "|  " + beverage.Pack.ToString().PadRight(23) + "|  " + beverage.Price.ToString().PadRight(13) + "|  " + beverage.Active.ToString();

                    }
                }
            }


            return searchedBeverage;
        }


        public void AddNewBeverage(Beverage newBeverage)
        {
            
            int index = 0;

            do
            {
                index++;
            }
            while (beverages[index] != null);

            beverages[index] = newBeverage;

            return;
            
        }

        public void ProcessLine(string line, int index)
        {

            string[] parts = line.Split(',');

            string id = parts[0];
            string name = parts[1];
            string pack = parts[2];
            decimal price = decimal.Parse(parts[3]);
            bool active = bool.Parse(parts[4]);

            this.AddNewBeverage(new Beverage(id, name, pack, price, active));
            return;
        }

        public bool CheckBeverageId(string id)
        {
            foreach (Beverage beverage in beverages)
            {
                if (beverage != null)
                {
                    if (beverage.Id == id)
                    {
                        Console.WriteLine("The id "+"'"+id+"'"+" is already being used. Please enter a different id.");
                        return false;
                    }
                }
            }

            return true;
        }

        public string CollectionToString()
        {
            string outputString = "";


            foreach (Beverage beverage in beverages)
            {
                if (beverage != null)
                {
                    // Concat to the outputstring
                    outputString += "|  "+ beverage.Id.ToString().PadRight(13) + "|  " + beverage.Name.ToString().PadRight(60) + "|  " + beverage.Pack.ToString().PadRight(23) + "|  " + beverage.Price.ToString().PadRight(13) + "|  " + beverage.Active.ToString() +
                        Environment.NewLine;
                   
                }
            }

            // Use the UI calss to print out the string
            return outputString;
        }

    }

        
}

