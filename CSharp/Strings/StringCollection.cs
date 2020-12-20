/*
 * Reads input from the console -
 *  - Each line consists of comma seperated strings in the following format -
 *      - Customer Name
 *      - Store Location
 *      - Purchase Month
 *      - Product Name
 *      - Cost Price
 * 
 * Returns the list of customer names that have bought every product on discount
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharp.Strings
{
    public class StringCollection
    {
        public static void DisplayResult()
        {
            try
            {
                String line;
                var inputLines = new List<String>();
                while ((line = Console.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (line != "")
                        inputLines.Add(line);
                }

                var retVal = ProcessData(inputLines);
                foreach (var res in retVal)
                    Console.WriteLine(res);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<String> ProcessData(IEnumerable<string> lines)
        {
            List<String> retVal = new List<String>();
            Dictionary<string, int> productDiscounts = new Dictionary<string, int>();
            Dictionary<string, string> custMax = new Dictionary<string, string>();
            HashSet<string> customers = new HashSet<string>();

            foreach (var line in lines)
            {
                var current = line.Split(',');
                string customer = current[0].Trim();
                string product = current[3].Trim();
                var priceData = current[4].Trim().Split(' ');
                int price = Convert.ToInt32(priceData[1]);

                customers.Add(customer);

                if (productDiscounts.ContainsKey(product))
                {
                    if (productDiscounts[product] < price)
                    {
                        productDiscounts[product] = price;
                        custMax[product] = customer;
                    }
                }
                else
                {
                    productDiscounts.Add(product, price);
                    custMax.Add(product, customer);
                }
            }

            foreach (var customer in customers)
            {
                int count = custMax.Count(cd => cd.Value.Contains(customer));

                if (count == 0)
                {
                    retVal.Add(customer);
                }
            }

            return retVal;
        }
    }
}
