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
    public class PurchaseData
    {
        public string CustomerName { get; set; }
        public string StoreLocation { get; set; }
        public int PurchaseMonth { get; set; }
        public string ProductName { get; set; }
        public int CostPrice { get; set; }
    }

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
            List<PurchaseData> purchaseData = new List<PurchaseData>();
            PurchaseData data = new PurchaseData();
            Dictionary<string, int> productDiscounts = new Dictionary<string, int>();
            Dictionary<string, string> custMax = new Dictionary<string, string>();
            HashSet<string> customers = new HashSet<string>();

            foreach (var line in lines)
            {
                var current = line.Split(',');
                var priceData = current[4].Trim().Split(' ');

                data.CustomerName = current[0].Trim();
                data.StoreLocation = current[1].Trim();
                data.PurchaseMonth = Convert.ToInt32(current[2].Trim());
                data.ProductName = current[3].Trim();
                data.CostPrice = Convert.ToInt32(priceData[1]);
                purchaseData.Add(data);
                customers.Add(data.CustomerName);

                if (productDiscounts.ContainsKey(data.ProductName))
                {
                    if (productDiscounts[data.ProductName] < data.CostPrice)
                    {
                        productDiscounts[data.ProductName] = data.CostPrice;
                        custMax[data.ProductName] = data.CustomerName;
                    }
                }
                else
                {
                    productDiscounts.Add(data.ProductName, data.CostPrice);
                    custMax.Add(data.ProductName, data.CustomerName);
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
