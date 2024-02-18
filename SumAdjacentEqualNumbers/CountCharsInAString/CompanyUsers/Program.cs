using System;
using System.Collections.Generic;

namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companies = new Dictionary<string, Company>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" -> ");
                string companyName = arguments[0];
                string employeeId = arguments[1];

                if (!companies.ContainsKey(companyName))
                {
                    Company company = new Company(companyName);
                    companies.Add(companyName, company);
                }

                companies[companyName].AddEmployee(employeeId);
            }

            foreach (KeyValuePair<string, Company> pair in companies)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }

    class Company
    {
        public Company(string name)
        {
            Name = name;
            EmployeesIds = new List<string>();
        }

        public string Name { get; set; }
        public List<string> EmployeesIds { get; set; }

        public override string ToString()
        {
            string result = $"{Name}\n";

            for (int i = 0; i < EmployeesIds.Count; i++)
            {
                result += $"-- {EmployeesIds[i]}\n";
            }

            return result.Trim();
        }

        public void AddEmployee(string employeeId)
        {
            if (!EmployeesIds.Contains(employeeId))
            {
                EmployeesIds.Add(employeeId);
            }
        }
    }
}
