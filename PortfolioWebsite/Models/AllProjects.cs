namespace PortfolioWebsite.Models
{
    public class AllProjects
    {
        public List<PortfolioProject> allProjects;
        
        public AllProjects()
        {
           allProjects = new List<PortfolioProject>();
           allProjects.Add(new PortfolioProject("Calculator","idk", "A simple calculator built with react state.",
               "https://sebastianreactcalculator.netlify.app/", "https://github.com/sebastianjburman/Simple-React-Calculator"));
        }
    }
}
