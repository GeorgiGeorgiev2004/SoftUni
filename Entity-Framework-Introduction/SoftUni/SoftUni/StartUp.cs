using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SoftUni
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();
            Console.WriteLine(GetEmployee147(context));
        }
        //Task3
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var listofnames = context.Employees
                .OrderBy(e => e.EmployeeId)
                .Select(e => new { e.FirstName, e.MiddleName, e.LastName, e.JobTitle, e.Salary })
                .ToList();
            foreach (var employee in listofnames)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }
        //Task 4
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var listofnames = context.Employees
                .Where(e => e.Salary > 50000)
                .Select(e => new { e.FirstName, e.Salary }).OrderBy(e => e.FirstName).ToList();
            foreach (var employee in listofnames)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }
        //Task 5
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var listofnames = context.Employees
                .Where(e => e.Department.Name == "Research and Development")
                .Select(e => new { e.FirstName, e.LastName, e.Department, e.Salary })
                .OrderBy(e => e.Salary).ThenByDescending(e => e.FirstName).ToList();
            foreach (var employee in listofnames)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.Department.Name} - ${employee.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }
        //Task6
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var newadress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };
            Employee? nakov = context.Employees.FirstOrDefault(e => e.LastName == "Nakov");
            nakov!.Address = newadress;
            context.SaveChanges();
            var ddz = context.Employees.OrderByDescending(e => e.AddressId).Take(10)
                .Select(e => e.Address.AddressText)
                .ToList();
            foreach (var item in ddz)
            {
                sb.AppendLine(item);
            }
            return sb.ToString().TrimEnd();
        }
        //Task7 --- NO
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employees = context.Employees.Where(e => e.EmployeesProjects.Any(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2003))
               .Select(e => new
               {
                   e.FirstName,
                   e.LastName,
                   MFN = e.Manager.FirstName,
                   MLN = e.Manager.LastName,
                   Projects = e.EmployeesProjects.Select(ep => new
                   {
                       ProjectName = ep.Project.Name,
                       PSD = ep.Project.StartDate,
                       PED = ep.Project.EndDate
                   })
               }).Take(10);
            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.MFN} {e.MLN}");
                foreach (var pj in e.Projects)
                {
                    var startDate = pj.PSD.ToString("M/d/yyyy h:mm:ss tt");
                    var endDate = pj.PED.HasValue ? pj.PED.Value.ToString("M/d/yyyy h:mm:ss tt") : "not finished";

                    sb.AppendLine($"--{pj.ProjectName} - {startDate} - {endDate}");
                }
            }
            return sb.ToString().TrimEnd();
        }
        //Task 8 - NO
        public static string GetAddressesByTown(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var adresses = context.Addresses.GroupBy(a => new
            {

            });
            return "22";
        }

        //Task 9
        public static string GetEmployee147(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var SpecialEmployee = context.Employees.Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    Projects = e.EmployeesProjects.Select(ep => new
                    {
                        ProjectName = ep.Project.Name
                    }).OrderBy(p => p.ProjectName)
                    .ToList()
                }).FirstOrDefault();
            sb.AppendLine($"{SpecialEmployee.FirstName} {SpecialEmployee.LastName} - {SpecialEmployee.JobTitle}");
            foreach (var e in SpecialEmployee.Projects)
            {
                sb.AppendLine(e.ProjectName);
            }
            return sb.ToString().TrimEnd();
        }
        //Task 10
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context) 
        {
            return "s";
        }
    }
}
