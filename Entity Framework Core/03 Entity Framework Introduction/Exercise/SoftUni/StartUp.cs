﻿using SoftUni.Data;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
       public  static void Main(string[] args)
        {
            var context = new SoftUniContext();

            var result = GetEmployeesWithSalaryOver50000(context);
            Console.WriteLine(result);


        }
       //3. Employees Full Information
        public static string GetEmployeesFullInformation(SoftUniContext context)
       {
           var sb = new StringBuilder();

           var employees = context
               .Employees
               .OrderBy(e => e.EmployeeId)
               .Select(e => new
               {
                   e.FirstName, 
                   e.LastName,
                   e.MiddleName,
                   e.JobTitle,
                   e.Salary 
               });

           foreach (var e in employees)
           {
               sb.AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
           }

           return sb.ToString().TrimEnd();
       }

        //4.	Employees with Salary Over 50 000
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        { 
            var sb = new StringBuilder();

            var result = context
                .Employees
                .Where(e => e.Salary > 50000)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName);

            foreach (var r in result)
            {
                sb.AppendLine($"{r.FirstName} - {r.Salary:f2}");
            }


            return sb.ToString().TrimEnd();
        }
    }
    
 
}