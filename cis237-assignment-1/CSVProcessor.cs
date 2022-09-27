// Cayden Greer
// CIS 237 - Fall 2022
// 09-27-2022 

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
        /// <summary>
        /// Creates a stream reader to read the csv file from the user given path to the csv file
        /// Passes the string created from reading a line in the csv file to beveragecolleciton.ProcessLine
        /// Throws error messages when file path returns invalid results
        /// </summary>
        /// <param name="pathToCSVFile"> User inputed string that contains the filepath for the stream reader to start reading from </param>
        /// <param name="beverageCollection"> An instance of the beverage collection class used to pass methods from CSVProcessor to BeverageCollection methods </param>
        /// <returns> A boolean that tells the program if a file has been properly loaded and read to prevent the user from being able to load another file </returns>
        public bool ImportCsv(string pathToCSVFile, BeverageCollection beverageCollection)
        {
            StreamReader streamReader = null;
            
            try
            {
                string line;

                streamReader = new StreamReader(pathToCSVFile);


                while ((line = streamReader.ReadLine()) != null)
                {
                    beverageCollection.ProcessLine(line);

                }

               

                return true;
              

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            finally
            {

                if (streamReader != null)
                {
                    streamReader.Close();
                }
                
            }


        }

    }
}
