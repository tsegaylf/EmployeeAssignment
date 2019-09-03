using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAssignmentLibrary {

    public class Employee {

        public string EmployeeName { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }

        public virtual string Print() { //polymorphism
            return $"{this.GetType().Name}:: Name: {EmployeeName}, Job: {JobTitle}, Salary: {Salary.ToString("C")}";
        }
        public Employee(string name, string job, decimal salary) {
            this.EmployeeName = name;
            this.JobTitle = job;
            this.Salary = salary;
        }
        }
}
