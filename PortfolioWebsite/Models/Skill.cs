namespace PortfolioWebsite.Models
{
    public class Skill
    {
        public string? Name { get; set; }
        public string? ImagePath { get; set; }

        public Skill(string? name, string? imagePath)
        {
            Name = name;
            ImagePath = imagePath;
        }
    }
}
