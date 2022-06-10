namespace PortfolioWebsite.Models
{
    public class PortfolioProject
    {
        public string? Name { get; set; }
        public string? ImagePath { get; set; }
        public string? Description { get; set; }
        public string? LinkToProject { get; set; }
        public string? RepoLink { get; set; }
        public PortfolioProject(string? name, string? imagePath, string? description, string? linkToProject, string? repoLink)
        {
            Name = name;
            ImagePath = imagePath;
            Description = description;
            LinkToProject = linkToProject;
            RepoLink = repoLink;
        }
    }
}
