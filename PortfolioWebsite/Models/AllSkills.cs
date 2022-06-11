namespace PortfolioWebsite.Models
{
    public class AllSkills
    {
        public List<Skill> allSkills;

        public AllSkills()
        {
            allSkills = new List<Skill>();
            allSkills.Add(new Skill("Html", "/Svgs/SkillSvgs/html.svg"));
            allSkills.Add(new Skill("CSS", "/Svgs/SkillSvgs/css.svg"));
            allSkills.Add(new Skill("Javascript", "/Svgs/SkillSvgs/javascript.svg"));
            allSkills.Add(new Skill("React", "/Svgs/SkillSvgs/react.svg"));
            allSkills.Add(new Skill("VS Code", "/Svgs/SkillSvgs/vscode.svg"));
            allSkills.Add(new Skill("Java", "/Svgs/SkillSvgs/java.svg"));
            allSkills.Add(new Skill("Git", "/Svgs/SkillSvgs/git.svg"));
            allSkills.Add(new Skill("MySQL", "/Svgs/SkillSvgs/mysql.svg"));
            allSkills.Add(new Skill("Express JS", "/Svgs/SkillSvgs/expressjs.svg"));

        }
    }
}
