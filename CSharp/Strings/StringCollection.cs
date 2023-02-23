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

namespace CSharp.Strings;

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
    private static List<string> MockData
    {
        get
        {
            return new List<string>
            {
                "Jon Smith, Los Angeles, 2, Cell Phone, $ 200",
                "John Doe, Los Angeles, 2, Landline Phone, $ 100",
                "John Smith, Los Angeles, 2, Landline Phone, $ 200",
                "John Smith, Los Angeles, 2, Cell Phone, $ 250",
                "Jane Smith, Los Angeles, 2, Hair Dryer, $ 200",
                "Jane Doe, Los Angeles, 2, Hair Dryer, $ 400",
                "John Smith, Los Angeles, 2, Charger, $ 200",
                "Jane Smith, Los Angeles, 2, Cell Phone, $ 150",
                "Jane Smith, Los Angeles, 2, Charger, $ 150",
                "John Cena, Los Angeles, 2, Charger, $ 100",
                "John Myth, Los Angeles, 2, Cell Phone, $ 250"
            };
        }
    }

    public static void DisplayResult()
    {
        try
        {
            string line;
            var inputLines = new List<string>();
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

    public static List<string> ProcessData(IEnumerable<string> lines)
    {
        List<string> retVal = new();
        List<PurchaseData> purchaseData = new();
        PurchaseData data;

        foreach (var line in lines)
        {
            var current = line.Split(',');
            var priceData = current[4].Trim().Split(' ');

            data = new PurchaseData();
            data.CustomerName = current[0].Trim();
            data.StoreLocation = current[1].Trim();
            data.PurchaseMonth = Convert.ToInt32(current[2].Trim());
            data.ProductName = current[3].Trim();
            data.CostPrice = Convert.ToInt32(priceData[1]);
            purchaseData.Add(data);
        }

        purchaseData = purchaseData.Select(pData =>
          {
              var tempMax = purchaseData
              .OrderByDescending(pTemp => pTemp.CostPrice)
              .Where(pTemp => pTemp.ProductName == pData.ProductName)
              .Select(pTemp => pTemp).First();
              return (pData.CostPrice != tempMax.CostPrice) ? pData : null;
          }).Where(pData => pData != null).ToList();

        retVal = purchaseData.Select(pData => pData.CustomerName).Distinct().ToList(); 
        return retVal;
    }
}
