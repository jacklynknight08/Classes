using System;
using System.Collections.Generic;

namespace classes
{
    
    public class Program
    {

    
        public static void Main() {
            Company store = new Company("Doggy Day Care", DateTime.Now);

            Employee person = new Employee("Jackie", "Dog Mom", DateTime.Now);
            Employee person2 = new Employee("Kyle", "Dog Dad", DateTime.Now);
            Employee person3 = new Employee("June", "Doggy", DateTime.Now);

            store.AddEmployee(person);
            store.AddEmployee(person2);
            store.AddEmployee(person3);
            
            store.ListEmployees();
        }
    }
}

    public class Company
{
    /*
        Some readonly properties
    */
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a property for holding a list of current employees
    public List<Employee> employees = new List<Employee>();

    // Create a method that allows external code to add an employee
    public void AddEmployee(Employee bart) {
        employees.Add(bart);
    }
    // Create a method that allows external code to remove an employee
    public void RemoveEmployee(Employee bart) {
        employees.Remove(bart);
    }

    //Create a constructor method that accepts two arguments:
            //1. The name of the company
            //2. The date it was created
    //The constructor will set the value of the public properties


    public Company (string name, DateTime date) {
        this.Name = name;
        this.CreatedOn = date;
    }
    public void ListEmployees() {
        foreach(Employee item in this.employees)
        {
            Console.WriteLine($"{item.Name} started as a {item.Title} on {GetStartDate(item)} ");
        }
    }

    private static DateTime GetStartDate(Employee item)
    {
        return item.StartDate;
    }
}        
    public class Employee
    {
            public string Name {get; set;}

            public string Title {get; set;}
            public DateTime StartDate {get; set;}

            public Employee (string name, string title, DateTime date)
            {
                this.Name = name;
                this.Title = title;
                this.StartDate = date;
            }
    }


