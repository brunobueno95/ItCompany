using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCompany
{
    internal class SeniorDeveloper : ItEmployers, IitEmployers
    {
        public SeniorDeveloper(string _name) : base(_name)
        {
            Name = _name;
            Level = "Senior Developer";
            SalaryPerHour = 200;
            HoursWorked = 0;
            IsEmployed = false;
            PorjectFinished = false;
            ProjectsCapableOfDoing = new List<string>() { "Easy", "Medium", "Hard"};
            CodeHoursPerDay = 8;
        }

        
        
        public void Bonus()
        {

        }
        

        public void TimeToFinishAproject()
        {

        }
    }
}
