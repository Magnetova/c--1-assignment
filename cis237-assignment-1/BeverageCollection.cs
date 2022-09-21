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
        Beverage[] beverages = new Beverage[1000];

        CSVProcessor csvProcessor = new CSVProcessor();

        csvProcessor.ImportCsv(pathToCsv, beverages);


    }

        
}

