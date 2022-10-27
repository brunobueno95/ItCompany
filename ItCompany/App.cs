using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ItCompany
{
    internal class App
    {
        public List<IEmployee> Employees { get; set; }
        public List<ItEmployers> AllDevelopers = new List<ItEmployers>();
        public List<ItEmployers> DevelopersCapabel = new List<ItEmployers>();
        public List<ItEmployers> DevelopersHired = new List<ItEmployers> ();
        public List<Projects> ProjectsCompanyOffer = new List<Projects> ();
        
        public Projects ProjectChosen { get; set; }

        public int WorkHoursPerDay { get; set; }
        public int SalaryPerDay { get; set; }
        public int index { get; set; }
        public string Input { get; set; }

        public App()
        {
            RunApp();
        }

        public void RunApp()
        {

            ProjectsAddtoOfferList();
            DevelopersAvailabelToHire();

           
            Greetings();
            ChoosePoject();
            ShowDevelopersCapabel(ValidateInput());
            HiringDevelopers(splitingInput(ChooseDev()));
            SeparatingHiredDevelopersInAList();
            simpleWriteLine();
            CheckDurationAndPriceofTheProject();




        }


        public void Greetings()
        {
            Console.WriteLine("Hey There, we are an It company called Bruno's Solutions!Here we Offer many different kind of " +
                "software development products where you can hire your own personal team to make it Happen at the time and price" +
                "you are comfortabel with! Press enter to see the Projects we offer");
            Console.ReadLine();
        }
        public void ChoosePoject()
        {
            for(int i = 0; i< ProjectsCompanyOffer.Count; i++)
            {
                Console.WriteLine($"{i} - {ProjectsCompanyOffer[i].NameOfTheProject} - hours needed to finish the project : {ProjectsCompanyOffer[i].HoursNeeded} \n");
            }
            Console.WriteLine("\nPress The respective number to choose the project you wish");
            Input = Console.ReadLine();
        }

        public void ShowDevelopersCapabel(int theIndex)
        {
            if(theIndex >=0)
            {
                for(int i = 0; i< AllDevelopers.Count; i++)
                {

                 if( AllDevelopers[i].ProjectsCapableOfDoing.Contains(ProjectChosen.LevelOfTheProject))
                    {

                        DevelopersCapabel.Add(AllDevelopers[i]);
                    }
                }
                if (DevelopersCapabel.Count > 0)
                    {
                    Console.Clear();
                        Console.WriteLine("Those are the Developers that can do this project!\n");
                        foreach (var item in DevelopersCapabel)
                        {
                            Console.WriteLine($"{item.Name} - {item.Level} ");
                        }
                    }
                        
                    
                
                
           
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }

        public string ChooseDev()
        {
            Console.WriteLine("\nChoose the Developers you want to hire by writing their name with a space between them");
            return Console.ReadLine();
        }

        public IEnumerable<string> splitingInput(string DevNames)
        {
            //found code on the net, must learn abit more about it
            var punctuation = DevNames.Where(Char.IsPunctuation).Distinct().ToArray();
            var DevNamesHired = DevNames.Split().Select(x => x.Trim(punctuation));
            return DevNamesHired;
            
        }

        public void HiringDevelopers(IEnumerable<string> namesHiring)
        {
            foreach(var name in namesHiring)
            {
                foreach (var Dev in AllDevelopers)
                {
                    if(Dev.Name == name)
                    {
                        Console.WriteLine($"\n{Dev.Name} got hired");
                        Dev.GotHired(); }
                }
            }
        }

        public void SeparatingHiredDevelopersInAList()
        {
            DevelopersHired = AllDevelopers.FindAll(d => d.IsEmployed == true);
            
        }

        public void simpleWriteLine()
        {
            Console.WriteLine("\n Press Enter to see How long this project will take and its total costs.");
            Console.ReadLine();
        }

        public void CheckDurationAndPriceofTheProject()
        {
            foreach(var dev in DevelopersHired)
            {
               WorkHoursPerDay += dev.CodeHoursPerDay;
                SalaryPerDay += dev.DaylySalary();
                
            }

            var daysToFinish = ProjectChosen.HoursNeeded / WorkHoursPerDay;
            var totalCost = daysToFinish * SalaryPerDay;

            Console.Clear();

            Console.WriteLine($"\nThis project is {ProjectChosen.HoursNeeded} hours of work," +
                $"you have {DevelopersHired.Count} hired developers that together work {WorkHoursPerDay} hours per day. " +
                $"This project will take {daysToFinish} days to be done.");
            Console.WriteLine($"This Project will cost you {totalCost} kroners in total.");
        }

        
        public int ValidateInput()
        {
            var validation = "";
             
            for (int i =0; i< ProjectsCompanyOffer.Count; i++)
            {
                if(Input == i.ToString())
                {  validation = "valid";
                    index = i;
                }
                
            }
            if(validation == "valid")
            {
                ProjectChosen = ProjectsCompanyOffer[index];
                return index;
                 }
            else
            { return index = -1; }
            
        }

        public void DevelopersAvailabelToHire()
        {
            AllDevelopers.Add(new SeniorDeveloper("Fred"));
            AllDevelopers.Add(new SeniorDeveloper("James"));
            AllDevelopers.Add(new SeniorDeveloper("Miles"));
            AllDevelopers.Add(new JuniorDeveloper("Mike"));
            AllDevelopers.Add(new JuniorDeveloper("Tim"));
            AllDevelopers.Add(new JuniorDeveloper("Sabrina"));
            AllDevelopers.Add(new JuniorDeveloper("Maya"));
            AllDevelopers.Add(new Intern("Luca"));
            AllDevelopers.Add(new Intern("Jimmy"));
            AllDevelopers.Add(new Intern("Alex"));



        }

        public void ProjectsAddtoOfferList()
        {
            ProjectsCompanyOffer.Add(new Projects("Interactive Website", "Easy"));
            ProjectsCompanyOffer.Add(new Projects("Simple Website Game", "Easy"));
            ProjectsCompanyOffer.Add(new Projects("Simple Cellphone App", "Easy"));
            ProjectsCompanyOffer.Add(new Projects("3D Game", "Medium"));
            ProjectsCompanyOffer.Add(new Projects("Delivery App", "Medium"));
            ProjectsCompanyOffer.Add(new Projects("3D Game", "Medium"));
            ProjectsCompanyOffer.Add(new Projects("Automation", "Medium"));
            ProjectsCompanyOffer.Add(new Projects("Clous System", "Hard"));
            ProjectsCompanyOffer.Add(new Projects("Full Stack App", "Hard"));
            ProjectsCompanyOffer.Add(new Projects("Machine Learning", "Hard"));
        }
    }
}
