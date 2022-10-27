using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCompany
{
    internal class Projects
    {
        public string NameOfTheProject { get; set; }
        private string levelOfTheProject { get; set; }
        public int HoursNeeded { get; set; }
        public int DelevelopersNeeded { get; set; }

        public Projects(string nameOfProject, string levelOfTheProject)
        {
            NameOfTheProject = nameOfProject;
            LevelOfTheProject = levelOfTheProject;
            HoursNeeded = 0;
            DelevelopersNeeded = 0;
            HoursDependLevelOfProject();
        }  
        
        public void HoursDependLevelOfProject()
        {
            if (levelOfTheProject == "Easy")
            { HoursNeeded = 50; }

            else if (levelOfTheProject == "Medium")
            { HoursNeeded = 100; }

            else if(levelOfTheProject == "Hard")
            {
                HoursNeeded = 350;
            }
        }

        

        public string LevelOfTheProject
        {
            get { return levelOfTheProject; }
            set
            {
                if(value == "Easy" || value == "Medium" || value=="Hard")
                { levelOfTheProject = value; }
            }
        }
    }
}
