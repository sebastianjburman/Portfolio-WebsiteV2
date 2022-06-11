namespace PortfolioWebsite.Models
{
    public class Project
    {
        public string? Name { get; set; }
        public string? ImagePath { get; set; }
        public string? Description { get; set; }
        public string? LinkToProject { get; set; }
        public string? RepoLink { get; set; }
        public Project(string? name, string? imagePath, string? description, string? linkToProject, string? repoLink)
        {
            Name = name;
            ImagePath = imagePath;
            Description = description;
            LinkToProject = linkToProject;
            RepoLink = repoLink;
        }
    }
}
