using System.Collections.Generic;

namespace RizwanPortfolio.Models
{
    public class SkillGroup
    {
        public string Category { get; set; }
        public List<string> Items { get; set; }
    }

    public class ExperienceEntry
    {
        public string Role { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public string Period { get; set; }
        public List<string> LogLines { get; set; }
        public List<string> Stack { get; set; }
    }

    public class ProjectEntry
    {
        public string Id { get; set; }          // e.g. "AUD-01"
        public string Title { get; set; }
        public string Period { get; set; }
        public string Summary { get; set; }
        public List<string> Highlights { get; set; }
        public List<string> Stack { get; set; }
    }

    public class EducationEntry
    {
        public string Institution { get; set; }
        public string Location { get; set; }
        public string Degree { get; set; }
        public string Period { get; set; }
        public string Cgpa { get; set; }
        public string Coursework { get; set; }
    }

    /// <summary>
    /// Single view model assembled by HomeController and rendered by Views/Home/Index.cshtml.
    /// All content below is sourced directly from Shaik Mohammed Rizwan's resume.
    /// </summary>
    public class PortfolioViewModel
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Tagline { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
        public List<string> OpenToRoles { get; set; }
        public string WorkMode { get; set; }
        public string BadgeId { get; set; }
        public string PhotoPath { get; set; }

        public List<SkillGroup> SkillGroups { get; set; }
        public List<ExperienceEntry> Experience { get; set; }
        public List<ProjectEntry> Projects { get; set; }
        public EducationEntry Education { get; set; }
        public List<string> Leadership { get; set; }
    }
}
