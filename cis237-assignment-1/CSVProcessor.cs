// Cayden Greer
// CIS 237 - Fall 2022
// 09-16-2022 


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_1
{
    internal class CSVProcessor
    {
        public void ImportCsv(string pathToCSVFile, Beverage[] beverages)
        {
            StreamReader streamReader = null;

            try
            {
                string line;

                streamReader = new StreamReader(pathToCSVFile);

                int counter = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    this.ProcessLine(line, beverages, counter++);

                }

                return;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return;
            }
            finally
            {

                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }


        }

        private void ProcessLine(string line, Beverage[] beverages, int index)
        {

            string[] parts = line.Split(',');

            string  id = parts[0];
            string name = parts[1];
            string pack = parts[2];
            decimal price = decimal.Parse(parts[3]);
            bool active = bool.Parse(parts[4]);  

            beverages[index] = new Beverage(id, name, pack, price, active);
        }
    }
}
