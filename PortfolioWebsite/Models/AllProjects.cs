namespace PortfolioWebsite.Models
{
    public class AllProjects
    {
        public List<Project> allProjects;

        public AllProjects()
        {
            allProjects = new List<Project>();
            allProjects.Add(new Project("Portfolio Website", "Images/ProjectImages/Portfoliowebsiteproject.png", "This portfolio website created in blazor webassembly.",
               "http://sebastianjburman.com", "https://github.com/sebastianjburman/Portfolio-WebsiteV2"));
            allProjects.Add(new Project("Flappy Bird Clone", "Images/ProjectImages/flappyBirdClone.gif", "Flappy bird clone created in java using libgdx.",
               null, "https://github.com/sebastianjburman/Flappy-Bird_Clone"));
            allProjects.Add(new Project("Budget Application", "Images/ProjectImages/budgetAppImage.png", "A responsive budget application created in react. Uses local storage to save data.",
               "https://sebastianbudgetapplication.netlify.app/", "https://github.com/sebastianjburman/budget-application"));
            allProjects.Add(new Project("Weather App", "Images/ProjectImages/weatherapp.png", "A simple react weather app using the open weather api.",
               "https://sebastianweatherapp.netlify.app/", "https://github.com/sebastianjburman/React-Weather-App"));
            allProjects.Add(new Project("Calculator", "Images/ProjectImages/reactCalculatorImg.png", "A simple calculator built with react state.",
                "https://sebastianreactcalculator.netlify.app/", "https://github.com/sebastianjburman/Simple-React-Calculator"));
        }
    }
}
