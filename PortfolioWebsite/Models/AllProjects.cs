namespace PortfolioWebsite.Models
{
    public class AllProjects
    {
        public List<Project> allProjects;

        public AllProjects()
        {
            allProjects = new List<Project>();
            allProjects.Add(new Project("Crud Movie Rating Application", "Images/ProjectImages/crudMovieRatingImg.png", "Crud movie rating application created with Angular, ExpressJS and MongoDB.",
               null, "https://github.com/sebastianjburman/Crud-Movie-Rating-Application"));
            allProjects.Add(new Project("Full Stack Chat App", "Images/ProjectImages/fullstackchatapp.gif", "Full stack chat app created with React, .Net and MongoDB.",
               "https://tetraroomsjburman.netlify.app", "https://github.com/sebastianjburman/Full-Stack-Chat-App"));
            allProjects.Add(new Project("Portfolio Website", "Images/ProjectImages/Portfoliowebsiteproject.png", "This portfolio website created in Blazor webassembly.",
               "http://sebastianjburman.com", "https://github.com/sebastianjburman/Portfolio-WebsiteV2"));
            allProjects.Add(new Project("Flappy Bird Clone", "Images/ProjectImages/flappyBirdClone.gif", "Flappy bird clone created in Java using libgdx.",
               null, "https://github.com/sebastianjburman/Flappy-Bird_Clone"));
            allProjects.Add(new Project("Budget Application", "Images/ProjectImages/budgetAppImage.png", "A responsive budget application created in React. Uses local storage to save data.",
               "https://sebastianbudgetapplication.netlify.app/", "https://github.com/sebastianjburman/budget-application"));
            allProjects.Add(new Project("Weather App", "Images/ProjectImages/weatherapp.png", "A simple React weather app using the open weather api.",
               "https://sebastianweatherapp.netlify.app/", "https://github.com/sebastianjburman/React-Weather-App"));
            allProjects.Add(new Project("Calculator", "Images/ProjectImages/reactCalculatorImg.png", "A simple calculator built with React state.",
                "https://sebastianreactcalculator.netlify.app/", "https://github.com/sebastianjburman/Simple-React-Calculator"));
        }
    }
}
