namespace MyCVApp.Models
{
    public class PortfolioModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
        public string ProfessionalSummary { get; set; }
        public List<string> TechnicalSkills { get; set; }
        public List<string> ProfessionalAttributes { get; set; }
        public List<Project> TechnicalProjects { get; set; }
        public List<EducationItem> Education { get; set; }
        public List<CertificationItem> Certifications { get; set; }

    }

    public class Project
    {
        public string Title { get; set; }
        public string TechStack { get; set; }
        public List<string> DescriptionPoints { get; set; }
        public string AchievementsText { get; set; }
        public string GitHubUrl { get; set; }
        public string GitHubDisplayText { get; set; }
    }

    public class EducationItem
    {
        public string Degree { get; set; }
        public string Institution { get; set; }
        public string Status { get; set; }
        public string AcademicHighlights { get; set; }
    }

    public class CertificationItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}