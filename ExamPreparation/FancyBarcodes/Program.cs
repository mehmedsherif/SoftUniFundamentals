﻿using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string pattern = @"@#+(?'barcode'[A-Z]{1}[A-Za-z-0-9]{4,}[A-Z]{1})@#+";
            RegexOptions options = RegexOptions.Multiline;
            for (int i = 0; i < n; i++) 
            {
                string line=Console.ReadLine();
                GroupCollection groupCollection=Regex.Match(line,pattern,options).Groups;

                if(groupCollection.Count==1) 
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                string barcode = groupCollection["barcode"].Value;
                string barcodeDigits=new string(barcode.Where(x=>char.IsDigit(x)).ToArray());
                if(barcodeDigits.Length == 0 )
                {
                    Console.WriteLine("Product group: 00");
                }
                else
                {
                    Console.WriteLine($"Product group: {barcodeDigits}");
                }
            }

        }
    }
}
