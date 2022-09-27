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
    internal class BeverageCollection
    {
        Beverage[] beverages = new Beverage[10000];
        /// <summary>
        /// Sorts through the array 'beverages' to find the beverage that has the same id as the id parameter
        /// </summary>
        /// <param name="id"> Value of the search id given by the user </param>
        /// <returns> A string with the contents of the searched beverage </returns>
        public string SearchList(string id)
        {
            string searchedBeverage = null;


            foreach (Beverage beverage in beverages)
            {
                if (beverage != null)
                {
                    if (beverage.Id == id)
                    {
                        
                        searchedBeverage = "|  " + beverage.Id.ToString().PadRight(13) + "|  " + beverage.Name.ToString().PadRight(60) + "|  " + beverage.Pack.ToString().PadRight(23) + "|  " + beverage.Price.ToString().PadRight(13) + "|  " + beverage.Active.ToString();

                    }
                }
            }
            // Checks to see if the user inputed id matched any beverage id
            // If not, then message is displayed
            if (searchedBeverage == null)
            {
                Console.WriteLine("No Beverage with id "+ "'" +id + "'" + " was found.");
            }


            return searchedBeverage;
        }

        /// <summary>
        /// Sorts through the array to find the next available 'null' location to add a Beverage to the end of the beverage array
        /// </summary>
        /// <param name="newBeverage"> A Beverage type object that contains the inputed values (form csv or user) for the new beverage </param>
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
        /// <summary>
        /// Breaks a string of information read from the csv processor and to add to a new Beverage object
        /// </summary>
        /// <param name="line"> string read from the streamreader and inputed from the csv processor </param>
        public void ProcessLine(string line)
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
        /// <summary>
        /// Sorts through the beverages array to make sure that the user inputed id is not already being used by another Beverage object
        /// </summary>
        /// <param name="id"> Value of the search id given by the user </param>
        /// <returns> A boolean that determines if the id is already in use or not </returns>
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
        /// <summary>
        /// For every beverage object in the beverages array, the id, name, pack, price, and active are converted into a string which is then concatenated into one string.
        /// Extra padding included to make the formatting better when the list is printed.
        /// </summary>
        /// <returns> A large string that contains all of the beverages from the beverages array </returns>
        public string CollectionToString()
        {
            string outputString = null;


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

