﻿namespace WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words=Console.ReadLine()
                .Split()
                .Where(x=>x.Length%2==0)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine,words));
        }
    }
}