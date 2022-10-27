using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCompany
{
    abstract internal class   ItEmployers
    {
        public string Name { get; set; }    
        public string Level { get; set; }

        public int SalaryPerHour { get; set; }

        public int HoursWorked { get; set; }

        public bool IsEmployed { get; set; }

        public bool PorjectFinished { get; set; }

        public int CodeHoursPerDay  { get; set; }

        public List<string> ProjectsCapableOfDoing { get; set; }




        public ItEmployers(string _name)
        {
            Name = _name;
            Level = "";
            SalaryPerHour = 0;
            HoursWorked = 0;
            IsEmployed = false;
            PorjectFinished = false;
            ProjectsCapableOfDoing = new List<string>();


        }

        public void GotHired()
        {
            IsEmployed=true;
        }
        public int DaylySalary()
        {
            var DaySalary = CodeHoursPerDay  * SalaryPerHour;
            return DaySalary;
        }


    }
}
