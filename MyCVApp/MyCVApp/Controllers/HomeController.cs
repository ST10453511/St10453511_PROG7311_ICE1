using Microsoft.AspNetCore.Mvc;
using MyCVApp.Models;
using System.Collections.Generic;

namespace MyCVApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var cv = new PortfolioModel
            {
                Name = "MOEGAMMAD YAASEEN ALEXANDER",
                Title = "Final Year IT Student",
                Location = "Johannesburg, South Africa",
                Phone = "081 060 3097",
                Email = "moeyalexander22@gmail.com",
                LinkedIn = "www.linkedin.com/in/moegammad-alexander",
                GitHub = "github.com/ST10453511",

                ProfessionalSummary = "I am a motivated and detail-oriented Application Development student with a strong foundation in software development, object-oriented programming, and problem-solving. Passionate about building scalable, user-focused applications, I am experienced in utilizing C#, Java, ASP.NET Core, SQL Server, and Microsoft Azure. Demonstrating strong analytical thinking, adaptability, and a proactive approach to learning, I have been recognized for consistent academic performance with high averages and multiple distinctions. Seeking a Software Developer opportunity to contribute technical skills while growing within a professional environment.",

                TechnicalSkills = new List<string>
                {
                    "Programming & Web: C#, Java, SQL, HTML, CSS, JavaScript, Bootstrap",
                    "Frameworks & Databases: ASP.NET Core (MVC), .NET, Entity Framework, SQL Server, Azure SQL Database, JSON",
                    "Cloud (Azure): Fundamentals, App Services, Blob Storage, Table Storage, Azure Queues, Azure Files",
                    "Tools & Version Control: Git, GitHub, Visual Studio, GitHub Actions"
                },

                ProfessionalAttributes = new List<string>
                {
                    "Analytical Problem Solving: Adept at breaking down complex technical requirements, debugging code, and designing logical, scalable software solutions.",
                    "Attention to Detail: Committed to writing clean, maintainable code and conducting thorough testing to ensure high-quality, error-free applications.",
                    "Adaptability & Continuous Learning: Highly proactive in mastering new technologies, frameworks, and cloud services to stay current in a rapidly evolving tech landscape.",
                    "Collaborative Teamwork: Effective communicator experienced in working within project teams, sharing knowledge, and collaborating on version-controlled repositories like GitHub.",
                    "Time Management & Execution: Proven ability to balance rigorous academic coursework with intensive software development projects, consistently meeting strict deadlines with high-distinction results."
                },

                TechnicalProjects = new List<Project>
                {
                    new Project {
                        Title = "Contract Monthly Claim System (CMCS)",
                        TechStack = "C#, ASP.NET Core MVC, Entity Framework, SQL",
                        DescriptionPoints = new List<string> {
                            "Developed a multi-role web application to streamline lecturer claim submissions, featuring automated payment calculations, validation logic, structured workflows, and document uploads.",
                            "Utilized Entity Framework to ensure a clean separation between business logic and data access."
                        },
                        AchievementsText = "Achievements & Links: Achieved 84% (Distinction) in Programming 2B. | GitHub: ",
                        GitHubUrl = "https://github.com/ST10453511/PROG6212_POE_Part3",
                        GitHubDisplayText = "github.com/ST10453511/PROG6212_POE_Part3.git"
                    },
                    new Project {
                        Title = "ABC Retailer Cloud Application",
                        TechStack = "C#, ASP.NET Core MVC, Microsoft Azure, SQL Server",
                        DescriptionPoints = new List<string> {
                            "Designed a cloud-integrated retail web app leveraging Azure Blob Storage for multimedia, Table Storage for structured data, Queues for transaction processing, and Files for document storage.",
                            "Deployed the system using Azure App Service with an emphasis on distributed architecture and scalability."
                        },
                        AchievementsText = "Achievements & Links: Achieved 83% (Distinction) in Cloud Development B. | GitHub: ",
                        GitHubUrl = "https://github.com/ST10453511/CLDV6212_POE_Part3",
                        GitHubDisplayText = "github.com/ST10453511/CLDV6212_POE_Part3.git"
                    },
                    new Project {
                        Title = "EventEase Venue Booking System",
                        TechStack = "C#, ASP.NET Core MVC, SQL Server, Microsoft Azure",
                        DescriptionPoints = new List<string> {
                            "Built a database-driven venue booking application with full CRUD functionality and structured data validation.",
                            "Integrated SQL Server to ensure data consistency and designed the application for cloud deployment."
                        },
                        AchievementsText = "Achievements & Links: Achieved 85% (Distinction) in Cloud Development A. | GitHub: ",
                        GitHubUrl = "https://github.com/ST10453511/CLDV6211_POE_Part3",
                        GitHubDisplayText = "github.com/ST10453511/CLDV6211_POE_Part3.git"
                    },
                    new Project {
                        Title = "Cybersecurity Awareness Chatbot",
                        TechStack = "C#, .NET",
                        DescriptionPoints = new List<string> {
                            "Built an interactive console-based chatbot featuring structured input validation, conditional logic flows, ASCII-based UI design, and voice greeting integration."
                        },
                        AchievementsText = "Achievements & Links: Achieved 80% (Distinction) in Programming 2A. | GitHub: ",
                        GitHubUrl = "https://github.com/ST10453511/PROG6221_POE_GROUP1",
                        GitHubDisplayText = "github.com/ST10453511/PROG6221_POE_GROUP1.git"
                    },
                    new Project {
                        Title = "Task Management System",
                        TechStack = "Java",
                        DescriptionPoints = new List<string> {
                            "Created a task management application applying core OOP principles (encapsulation, inheritance, structured class design) to allow users to create, update, and track task statuses."
                        },
                        AchievementsText = "Links: GitHub: ",
                        GitHubUrl = "https://github.com/ST10453511/PROG5121_POE_Part3",
                        GitHubDisplayText = "github.com/ST10453511/PROG5121_POE_Part3.git"
                    }
                },

                Education = new List<EducationItem>
                {
                    new EducationItem {
                        Degree = "Bachelor of Computer and Information Sciences in Application Development (NQF 7)",
                        Institution = "Emeris (formerly IIE MSA) | 2024 – Present",
                        Status = "Status: Currently in Semester 5 of 6 (Expected Completion: 2026).",
                        AcademicHighlights = "Academic Highlights: Consistently achieving Pass with Distinction (PD) grades in critical modules, including Cloud Development A (85%) & B (83%); Programming 2A (80%) & 2B (84%); Information Systems 1B (87%), 2B (76%), & 2C (84%); Principles of Security (80%); and Programming 1B (83%)."
                    },
                    new EducationItem {
                        Degree = "National Senior Certificate (Matric)",
                        Institution = "Hoërskool President High | Completed",
                        Status = null,
                        AcademicHighlights = null
                    }
                },

                Certifications = new List<CertificationItem>
                {
                    new CertificationItem {
                        Title = "Certificate in Full Stack Development (32 Credits) | FNB App Academy / IT Varsity | July 2025",
                        Description = "Covered frontend, backend, APIs, deployment, UX design principles, and GitHub collaboration workflows."
                    }
                },
            };

            return View(cv);
        }
    }
}