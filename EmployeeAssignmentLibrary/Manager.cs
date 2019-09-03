using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAssignmentLibrary {

    public class Manager : Employee {

        private int TeamSize { get; set; } = 0;

        public override string Print() {
            return base.Print() + $" , TeamSize: {TeamSize}";
        }

        public Manager(string name, string job, decimal salary, int teamSize) 
            : base(name, job, salary) {
            this.TeamSize = teamSize;

        }
    }
}
