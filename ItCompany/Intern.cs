using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCompany
{
    internal class Intern : ItEmployers, IitEmployers
    {
        public Intern(string _name) : base(_name)
        {
            Name = _name;
            Level = "Intern";
            SalaryPerHour = 50;
            HoursWorked = 0;
            IsEmployed = false;
            PorjectFinished = false;
            ProjectsCapableOfDoing = new List<string>() { "Easy"};
            CodeHoursPerDay = 4;
        }



        public void Bonus()
        {

        }
        

        public void TimeToFinishAproject()
        {

        }
    }
}
