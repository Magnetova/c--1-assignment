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
        public bool ImportCsv(string pathToCSVFile, BeverageCollection beverageCollection)
        {
            StreamReader streamReader = null;
            
            try
            {
                string line;

                streamReader = new StreamReader(pathToCSVFile);

                int counter = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    beverageCollection.ProcessLine(line, counter++);

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
