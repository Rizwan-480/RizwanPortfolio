using System.Collections.Generic;
using System.Web.Mvc;
using RizwanPortfolio.Models;

namespace RizwanPortfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: /
        public ActionResult Index()
        {
            var model = new PortfolioViewModel
            {
                FullName = "Shaik Mohammed Rizwan",
                Title = "Software Developer — ASP.NET MVC",
                Tagline = "I build database-driven web systems and ship them to production on IIS.",
                Location = "Hyderabad, India",
                Phone = "+91 7995632476",
                Email = "shaikrizwan480@gmail.com",
                LinkedIn = "https://www.linkedin.com/in/rizwansde",
                GitHub = "https://github.com/Rizwan-480",
                OpenToRoles = new List<string> { "Software Developer", "Software Engineer", ".NET Developer", "Full-Stack Developer" },
                WorkMode = "Open to remote, on-site, India or international",
                BadgeId = "DEV-MVC-2026",
                PhotoPath = "~/Images/profile-badge.jpg",

                SkillGroups = new List<SkillGroup>
                {
                    new SkillGroup
                    {
                        Category = "Languages",
                        Items = new List<string> { "C#", "Java", "SQL" }
                    },
                    new SkillGroup
                    {
                        Category = "Frameworks & Libraries",
                        Items = new List<string> { "ASP.NET MVC", "ASP.NET", "jQuery", "Bootstrap" }
                    },
                    new SkillGroup
                    {
                        Category = "Databases",
                        Items = new List<string> { "MS SQL Server", "Stored Procedures", "ADO.NET" }
                    },
                    new SkillGroup
                    {
                        Category = "Tools & Platforms",
                        Items = new List<string> { "HTML", "CSS", "JavaScript", "AJAX", "GitHub", "IIS" }
                    }
                },

                Experience = new List<ExperienceEntry>
                {
                    new ExperienceEntry
                    {
                        Role = "Software Developer Intern",
                        Organization = "Future Communications Company",
                        Location = "Sharq, Kuwait (On-site)",
                        Period = "Jan 2026 — Apr 2026",
                        LogLines = new List<string>
                        {
                            "Developed 5+ database-driven web modules using C#, ASP.NET MVC and ADO.NET — cut feature development time by 25%.",
                            "Designed and optimized 20+ SQL Server stored procedures; built 10+ CRUD modules on MVC — query performance up 30%, reusability up 35%.",
                            "Integrated AJAX and jQuery for asynchronous page updates — page reload time down 40%.",
                            "Built responsive UIs with Bootstrap, HTML, CSS and JavaScript — 100% compatibility across major desktop and mobile browsers.",
                            "Implemented authentication and role-based access control for 3+ user roles — eliminated unauthorized access during testing.",
                            "Deployed and tested on IIS — 99% deployment success, production-ready performance."
                        },
                        Stack = new List<string> { "C#", "ASP.NET MVC", "ADO.NET", "SQL Server", "AJAX", "jQuery", "Bootstrap" }
                    }
                },

                Projects = new List<ProjectEntry>
                {
                    new ProjectEntry
                    {
                        Id = "AUD-01",
                        Title = "Smart Compliance & Audit Tracker",
                        Period = "Mar 2026 — Present",
                        Summary = "Centralized compliance management system supporting 3+ workflows, cutting manual processing by 30%.",
                        Highlights = new List<string>
                        {
                            "20+ secure SQL Server stored procedures — database performance up 25%.",
                            "Role-based dashboards and audit tracking modules across 3+ workflows.",
                            "AJAX + jQuery for dynamic, dependency-free page updates.",
                            "Deployed on IIS — 99% deployment success during testing."
                        },
                        Stack = new List<string> { "C#", "ASP.NET MVC", "ADO.NET", "SQL Server", "AJAX", "jQuery" }
                    },
                    new ProjectEntry
                    {
                        Id = "EDU-01",
                        Title = "School Management System",
                        Period = "Jan 2026 — Feb 2026",
                        Summary = "Web-based academic management system covering 5+ academic modules, cutting admin task time by 30%.",
                        Highlights = new List<string>
                        {
                            "Complete CRUD via ADO.NET on a structured MVC architecture — maintainability up 25%.",
                            "Responsive UI in Bootstrap — 100% compatibility across major browsers."
                        },
                        Stack = new List<string> { "ASP.NET MVC", "SQL Server", "ADO.NET", "Bootstrap" }
                    }
                },

                Education = new EducationEntry
                {
                    Institution = "Vaagdevi Institute of Technology and Science",
                    Location = "Proddatur",
                    Degree = "B.Tech, Computer Science & Engineering",
                    Period = "Aug 2022 — Jul 2026",
                    Cgpa = "8.0 / 10",
                    Coursework = "Object-Oriented Programming, Software Engineering, Database Management Systems"
                },

                Leadership = new List<string>
                {
                    "Student Lead — facilitated technical discussions and peer learning on C#, SQL Server and MVC architecture.",
                    "Led a student Tech Club, mentoring members in backend development and best coding practices.",
                    "Engaged in hackathons and technical seminars to stay current with industry practice."
                }
            };

            return View(model);
        }
    }
}
