using EmployeeAssignmentLibrary;
using System;
using System.Collections.Generic;

namespace EmployeeAssignment {
    class Program {
        void Run()
            {

            var emp1 = new Employee("Kevin Jones", "", 32000);
            var emp2 = new Employee("Joey Williams", "", 23000);
            var emp3 = new Employee("Jane Doe", "", 43000);

            var mgr1 = new Manager("Lidya Tsegay", "General Mgr", 55000, 7);
            var mgr2 = new Manager("Crystal Vaze", "District Mgr", 75000, 15);
            Console.WriteLine(mgr2.Print());

            var emps = new List<Employee>() { emp1, emp2, emp3, mgr1, mgr2 };
            foreach(var emp in emps) {
                Console.WriteLine(emp.Print());
            }
            
        }

        static void Main(string[] args) {
            (new Program()).Run();
        }
    }
}
