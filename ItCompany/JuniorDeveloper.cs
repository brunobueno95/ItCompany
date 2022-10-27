using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCompany
{
    internal class JuniorDeveloper : ItEmployers, IitEmployers
                                                , IEmployee
    {
        public JuniorDeveloper(string _name) : base(_name)
        {
            Name = _name;
            Level = "Junior Developer";
            SalaryPerHour = 100;
            HoursWorked = 0;
            IsEmployed = false;
            PorjectFinished = false;
            ProjectsCapableOfDoing = new List<string>() { "Easy", "Medium"};
            CodeHoursPerDay = 6;
        }

      
        public void Bonus()
        {
            
        }
       

        public void TimeToFinishAproject()
        {

        }
    }
}
