namespace MyPortfolio.Content;

public static class PortfolioContent
{
    // ── Identity ────────────────────────────────────────────────────────────

    public const string FirstName = "Tyler";
    public const string LastName = "Bao";
    public const string Title = "Software Engineer · Full-Stack Developer";

    public const string Intro =
        "I build software solutions across the full application stack, from web applications and " +
        "backend services to databases, reporting, and automation tooling. My focus is creating " +
        "maintainable, scalable systems that solve real operational challenges.";

    public static readonly string[] Bio =
    [
        "Few things have captivated me more than taking something apart to understand how it works. In high school, I attended a vocational-technical program and earned a certificate in Computer Aided Drafting and Design, where I discovered a passion for reverse engineering. The most memorable project of the year involved disassembling a children's bicycle, measuring every bearing and chain link with a micrometer, and rebuilding the whole assembly in 3D modeling software. Watching the chain turn with a pedal stroke in the final animation was deeply satisfying, and the experience shaped how I have approached problems ever since.",

    "My route into software was not a direct one. Before writing code professionally, I spent several years in finance, progressing through roles as a teller and branch manager, processing loans, managing bookkeeping for a private country club, and eventually moving into Procurement and Financial Planning & Analysis at Pratt & Whitney. That background has proven to be one of the most valuable things I brought into a development career. I understand budgets, reconciliations, and the way business stakeholders communicate, which allows me to bridge technical and business conversations whether I am building a finance-adjacent application or gathering requirements for a project in another department entirely.",

    "Computer science had been a hobby long before it became a career. I had spent years building my own PCs, designing DIY home solutions, and modding games for fun, and at some point it became clear that I should turn that interest into something more. I pursued a B.S. in Computer Science while working full-time, and my first role out of the program was as a Data Analyst at TSYS. It was there that I developed a genuine appreciation for the stories data can tell, and as a lifelong sports fan, I began building solo projects centered on sports analytics. My newest project in that space should be live on my GitHub in the coming months. Around the same time, I had been admitted to Georgia Tech's OMSA program and was preparing to begin when I received an offer for a Software Developer role, the title I had been working toward since the start of my degree. I deferred graduate school and committed fully to development.",

    "That was four years ago. Today I build enterprise applications in C#, Blazor, and Angular, design data solutions in SQL, and have recently been developing proof-of-concept Python applications as my organization explores emerging AI capabilities. I have also returned to graduate school and am currently pursuing an M.S. in Software Engineering at East Carolina University, deepening my understanding of software architecture, design principles, and testing strategies as I prepare for future senior and architectural roles. Drafting, finance, analytics, and development have come together to form a foundation I draw on every day, and I am grateful for every step along the way."

    ];

    // ── Tech Stack ───────────────────────────────────────────────────────────

    public static readonly SkillGroup[] SkillGroups =
    [
        new("languages",       ["C#", "C++", "VB .NET", "Python", "Javascript", "Html", "CSS", "SQL", "SOQL", "Linq"]),
        new("frameworks",      [".NET Framework", ".NET Core", "Blazor", "MVC", "Entity Framework", "Angular", "xUnit / nUnit", "bUnit"]),
        new("tools & cloud",   ["Azure", "Azure Devops", "Git", "SQL Server", "SSMS", "SSIS", "Postman", "Swagger"]),
        new("methodologies",   ["CI/CD", "TDD", "Agile / Scrum", "Solid", "OOP", "Git Flow", "Pair Programming"]),
    ];

    // ── Experience ───────────────────────────────────────────────────────────

    public static readonly ExperienceItem[] Experience =
    [
        new(
            YearRange:    "2022 — present",
            Title:        "Software Developer",
            Organization: "LL Global, Inc.",
            Bullets:
            [
                "Design, develop, and maintain internal applications.",
                "Collaborate with stakeholders to gather requirements, translate business needs into technical specifications, and iterate with users to refine interface and feature design.",
                "Build unit and integration tests to ensure software reliability, reduce bugs in production, and improve data integrity.",
                "Optimize database queries, streamline data models, and refactor inefficient code to reduce processing time, improve scalability, and minimize manual intervention.",
            ]
        ),
        new(
            YearRange:    "2021 — 2022",
            Title:        "Analyst — Client Consulting",
            Organization: "TSYS",
            Bullets:
            [
                "Supported clients' testers by reviewing test cases, addressing specific inquiries, and triaging issues to ensure smooth and effective execution during the testing phase.",
                "Conducted implementation and integration tasks, including data conditioning, mock verification, business validation, and production certification activities.",
                "Developed and executed SQL queries and collaborated with the team to create automation scripts, significantly streamlining monthly and quarterly reporting tasks.",
                "Led an analysis project focused on consumer spending trends for a client webinar on the impact of Covid-19, delivering actionable insights.",
            ]
        ),
        new(
            YearRange:    "2020",
            Title:        "Finance Co-Op — Forecast and Analysis",
            Organization: "Pratt and Whitney",
            Bullets:
            [
                "Compilation and analysis of data for daily, weekly, and monthly management reports.",
                "Conducted financial forecasting to support decision-making processes.",
                "Preparation of detailed financial analyses to identify trends and variances.",
                "Development and presentation of comprehensive financial reports for stakeholders.",
                "Engagement in cost reduction analysis to enhance operational efficiency.",
            ]
        ),
        new(
            YearRange:    "2018 — 2019",
            Title:        "Bookkeeper — Project Manager",
            Organization: "Chippanee Country Club",
            Bullets:
            [
                "Oversaw full-cycle bookkeeping for private country club operations, encompassing member billing, dues management, discounts application, vendor payments, and restaurant cost analysis.",
                "Prepared and maintained financial statements, reconciliations, and expense reports, ensuring accuracy and compliance with established accounting standards.",
                "Conducted a Cost-Benefit Analysis for a modernization initiative; successfully secured leadership approval for project execution.",
                "Managed the implementation of new Accounting and CRM systems to streamline workflows, enhance operational efficiency, and improve the member experience.",
            ]
        ),
    ];

    // ── Education ────────────────────────────────────────────────────────────

    public static readonly EducationItem[] Education =
    [
        new(
            YearRange:   "2026 — present",
            Degree:      "Master of Science — Software Engineering",
            Institution: "East Carolina University",
            Detail:      "In Progress"
        ),
        new(
            YearRange:   "2020",
            Degree:      "Bachelor of Science — Computer Information Systems, Software Development",
            Institution: "Post University"
        ),
        new(
            YearRange:   "2017",
            Degree:      "Associate of Science — Business Administration, Banking and Finance",
            Institution: "New England College of Business"
        ),
    ];

    // ── ECU Stats ────────────────────────────────────────────────────────────

    public const string EcuAverage = "4.0";
    public const int EcuCoursesCount = 2;
    public const int EcuCreditHours = 6;

    // ── Completed Coursework ──────────────────────────────────────────────────

    public static readonly CourseItem[] Courses =
    [
        new(
            Code:        "SENG 6235",
            Name:        "Software Project Management",
            Credits:     "3 s.h.",
            Description: "Advanced methods and techniques to initiate, plan, and control large and complex software development " +
                         "projects. Covers project estimation, scheduling, risk management, team dynamics, Agile and traditional " +
                         "process models, and earned value management for sustained delivery of high-quality software.",
            Tags:        ["agile", "project planning", "risk management", "scrum", "estimation"],
            Grade:       100
        ),
        new(
            Code:        "SENG 6300",
            Name:        "Software Evolution and Maintenance",
            Credits:     "3 s.h.",
            Description: "Study of how software systems change and evolve over their operational lifetime. Topics include " +
                         "maintenance processes, legacy system management, refactoring, technical debt reduction, reverse " +
                         "engineering, and re-engineering strategies for sustaining large-scale software in production environments.",
            Tags:        ["refactoring", "technical debt", "legacy systems", "reverse engineering", "maintenance"],
            Grade:       94.7
        ),
        new(
            Code:        "CSCI 6020",
            Name:        "Machine Learning",
            Credits:     "3 s.h.",
            Description: "Foundations and applied methods of machine learning, including supervised and unsupervised learning, " +
                         "model evaluation, feature engineering, and neural network architectures. Emphasis on implementing and " +
                         "interpreting models for real-world datasets.",
            Tags:        ["machine learning", "neural networks", "supervised learning", "model evaluation", "python"],
            Status:      "In Progress"
        ),
        new(
            Code:        "CSCI 6905",
            Name:        "Topics in Computer Science: Applied Agentic AI",
            Credits:     "3 s.h.",
            Description: "Exploration of agentic AI systems — architectures that plan, reason, and act autonomously to complete " +
                         "multi-step tasks. Topics include large language model tool use, retrieval-augmented generation, agent " +
                         "orchestration frameworks, and responsible deployment of autonomous systems.",
            Tags:        ["agentic ai", "llm", "rag", "tool use", "agent orchestration"],
            Status:      "Scheduled"
        ),
        new(
            Code:        "SENG 6265",
            Name:        "Foundations of Software Testing",
            Credits:     "3 s.h.",
            Description: "Systematic approaches to software testing including test design, coverage criteria, unit and integration " +
                         "testing, test-driven development, automated testing pipelines, and quality assurance practices for " +
                         "complex software systems.",
            Tags:        ["testing", "tdd", "test automation", "coverage", "quality assurance"],
            Status:      "Scheduled"
        ),
        new(
            Code:        "SENG 6230",
            Name:        "Software Engineering Foundations",
            Credits:     "3 s.h.",
            Description: "Core principles and practices of software engineering including requirements analysis, architectural " +
                         "design patterns, software quality attributes, and process models. Establishes a rigorous foundation " +
                         "for advanced study in software design and systems engineering.",
            Tags:        ["software architecture", "design patterns", "requirements", "quality attributes", "process models"],
            Status:      "Scheduled"
        ),
    ];

    // ── School Projects ───────────────────────────────────────────────────────

    public static readonly SchoolProject[] SchoolProjects =
    [
        new(
            OrgAndCourse: "ECU-Pirate-Forge · SENG 6235 — Software Project Management",
            Name:         "ScrumPilot",
            Url:          "https://github.com/ECU-Pirate-Forge/scrum-pilot",
            Description:  "AI-powered Scrum project management platform built for student and professional teams. Features a " +
                          "Kanban drag-and-drop board, backlog management, AI-driven story generation, real-time planning poker, " +
                          "sprint metrics dashboards (burndown, velocity, cycle time), threaded commenting, and a Discord bot " +
                          "called ScrumLord for team communication summaries. Built with a team at ECU as the course's capstone deliverable.",
            Tags:         ["C# / ASP.NET Core", "Blazor WASM", "PostgreSQL", "SignalR", "xUnit", "Docker", "AI integration"]
        ),
    ];

    // ── Open Source Contributions ─────────────────────────────────────────────

    public static readonly OpenSourceContribution[] OpenSourceContributions = [];

    // ── Research & Writing ────────────────────────────────────────────────────

    public static readonly PaperItem[] Papers =
    [
        new(
            Course:      "SENG 6300",
            Semester:    "Spring 2026",
            Title:       "The Agile Integrity Index: A Framework for Measuring Authentic Scrum Adoption",
            PdfPath:     "docs/Agile_Integrity_Index.pdf",
            Description: "Proposes a diagnostic scoring model — the Agile Integrity Index — for assessing how faithfully a " +
                         "software team has adopted Scrum practices versus surface-level ceremony compliance. The framework " +
                         "evaluates teams across five dimensions: sprint hygiene, backlog discipline, ceremony fidelity, " +
                         "team autonomy, and continuous improvement cadence, producing a composite score that identifies " +
                         "where adoption is genuine and where it has degraded into \"Scrumwashing.\"",
            Tags:        ["agile", "scrum", "software process", "metrics", "SENG 6300"]
        ),
    ];

    // ── Educational Narrative ─────────────────────────────────────────────────

    public static readonly string[] EducationalGoals =
        [
            "I am currently pursuing my M.S. in Software Engineering at East Carolina University, " +
        "with the goal of building on my current foundation." +
        "Three years into my software career, I am confident in what I deliver day to " +
        "day. The MS is about expanding that capability into areas like software architecture, " +
        "testing strategies, and enterprise-scale design principles, and bringing what I learn " +
        "back to my organization in ways that strengthen our processes and the systems we build together.",

        "ECU's practical, project-based format suits the way I learn. I retain knowledge by " +
        "applying it rather than by sitting with it, and the distance education structure allows " +
        "me to put new concepts to work in my day job almost immediately. The program is a fit " +
        "in that sense, not just a credential.",

        "The longer arc is technical leadership and eventually architectural roles, positions " +
        "where my business background, analytical experience, and the engineering depth I am " +
        "building now can operate together. The MS is the piece of preparation that bridges " +
        "where I am today and where I am aiming.",
    ];

    // ── Hobbies ───────────────────────────────────────────────────────────────

    public static readonly (string Icon, string Label)[] Hobbies =
    [
        ("🎮", "gaming"),
        ("📚", "reading"),
        ("💻", "Custom PCs and Keyboards"),
        ("🎵", "music"),
        ("🖌️", "3d Modeling"),
        ("🖨️", "3d printing"),
        ("🎣", "fishing"),
        ("🏀", "basketball"),
        ("🏈", "football"),
    ];

    public static readonly HobbyCategory[] HobbyCategories =
    [
        new("PC Builds",
        [
            new HobbySlide { ImageUrl = "images/hobbies/PC%20Builds/01_Personal_PC.jpg",        Title = "Personal Build",            Caption = "My current personal build and my first vertical mount GPU setup." },
            new HobbySlide { ImageUrl = "images/hobbies/PC%20Builds/02_Personal_PC.jpg",        Title = "Personal Build Interior",   Caption = "My personal build with lighting and animated AIO LCD." },
            new HobbySlide { ImageUrl = "images/hobbies/PC%20Builds/03_Friends_and_Family.jpg", Title = "Friends & Family Build",    Caption = "A budget build put together for family. I added a custom 3d printed spacer between the top mounted fans and a printed fan shroud to provide them with an Animal Crossing theme." },
            new HobbySlide { ImageUrl = "images/hobbies/PC%20Builds/04_Friends_and_Family.jpg", Title = "Friends & Family Build",    Caption = "The Animal Crossing themed build with RGB." },
            new HobbySlide { ImageUrl = "images/hobbies/PC%20Builds/05_Friends_and_Family.jpg", Title = "Friends & Family Build",    Caption = "A budget build created purely from spare parts from other builds and a friends broken case. I was able to re-solder the broken controller board on the IO and 3d print feet to replace the broken ones, matching the NZXT red cable management bar within the case." },
        ]),

        new("Keyboard Builds",
        [
            new HobbySlide { ImageUrl = "images/hobbies/Keyboards/01_Personal_KB.jpg",          Title = "Personal Keyboard",         Caption = "The first Keyboard I ever built myself. Ducky keycaps on a KBD75 with Boba U4T tactile switches." },
            new HobbySlide { ImageUrl = "images/hobbies/Keyboards/02_Personal_KB.jpg",          Title = "Personal Keyboard Detail",  Caption = "My current board with WS Morandi Linear switches. I built this Sasuke themed keyboard to match my current PC build. The ND75 case includes a small screen which supports the theme with a GIF on a loop, just as my AIO Cooler does." },
            new HobbySlide { ImageUrl = "images/hobbies/Keyboards/03_Friends_and_Family.jpg",   Title = "Friends & Family Build",    Caption = "A squirtle themed keyboard built for a friend" },
            new HobbySlide { ImageUrl = "images/hobbies/Keyboards/04_Friends_and_Family.jpg",   Title = "Friends & Family Build",    Caption = "Another keyboard built for a friend who wanted a clean themeless board that could sit alongside his Gengar themed PC." },
        ]),

        new("3D Models",
        [
            new HobbySlide { ImageUrl = "images/hobbies/3d%20Models/01_Dell_Dock_Mount.png",                    Title = "Dell Dock Mount",           Caption = "A mount for my laptop dock that simply slides over my existing laptop mount beneath my Secret Labs Magnus Pro Desk." },
            new HobbySlide { ImageUrl = "images/hobbies/3d%20Models/02_PS5_Magnetic_Mount.png",                 Title = "PS5 Magnetic Mount",        Caption = "Magnetic PS5 desk mount that snaps to the underside of the Magnus." },
            new HobbySlide { ImageUrl = "images/hobbies/3d%20Models/03_Wire_Rack_mounted_Medicine_Cabinet.png", Title = "Wire Rack Cabinet Adapter", Caption = "Modular medicine cabinet designed to snap onto wire rack closet shelves." },
        ]),

        new("Custom Built Desk PC",
        [
            new HobbySlide { ImageUrl = "images/hobbies/Desk%20Build/01_Desk_3d_Model.png",  Title = "3D Model",       Caption = "My favorite project I have ever completed. This is the 3D Model that started it all. I had CAD experience but had never done woodworking before." },
            new HobbySlide { ImageUrl = "images/hobbies/Desk%20Build/02_Desk_Sketch.png",    Title = "Initial Sketch", Caption = "The original 2D CAD sketch." },
            new HobbySlide { ImageUrl = "images/hobbies/Desk%20Build/03_Desk_Cuts.png",      Title = "Cut Plan",       Caption = "Cut plan optimized to minimize material waste, utilizing only a single board of wood for every required cut. Slight adjustments made later as I hadn't taken blade width into consideration initially." },
            new HobbySlide { ImageUrl = "images/hobbies/Desk%20Build/04_Desk_Cuts.jpg",      Title = "First Cuts",     Caption = "First cuts in progress, including cable routing, fan diameter cuts, power button cutout, IO placement, etc." },
            new HobbySlide { ImageUrl = "images/hobbies/Desk%20Build/05_Desk_Frame.jpg",     Title = "Frame Assembly", Caption = "Frame assembly taking shape." },
            new HobbySlide { ImageUrl = "images/hobbies/Desk%20Build/06_Desk_Test_Fit.jpg",  Title = "Test Fit",       Caption = "Test fitting hardware. First look at Display Port and HDMI routing to top of rear panel." },
            new HobbySlide { ImageUrl = "images/hobbies/Desk%20Build/07_Desk_Testing.jpg",   Title = "Dry Run",        Caption = "Initial testing after staining the desk. Confirming proper functionality of complex fan system." },
            new HobbySlide { ImageUrl = "images/hobbies/Desk%20Build/08_Desk_Painted.jpg",   Title = "Painted",        Caption = "After confirming functionality I committed to proper cable management." },
            new HobbySlide { ImageUrl = "images/hobbies/Desk%20Build/09_Desk_Finished.jpg",  Title = "Finished",       Caption = "Finished and installed, all cable running in hidden rear raceway within desk, all peripherals plug into top of desk." },
        ]),

        new("Keyboard Screen Project",
        [
            new HobbySlide { ImageUrl = "images/hobbies/Keyboard%20print%20with%20screen/01_3d_Model.png",     Title = "3D Model",   Caption = "CAD model of the custom keyboard case with an integrated mount for a 12.3 inch widescreen display." },
            new HobbySlide { ImageUrl = "images/hobbies/Keyboard%20print%20with%20screen/02_Test_Fitting.jpg", Title = "Test Fit",   Caption = "First test print to verify keyboard fit before committing to the full assembly." },
            new HobbySlide { ImageUrl = "images/hobbies/Keyboard%20print%20with%20screen/03_Full_Print.jpg",   Title = "Full Print", Caption = "Completed print before screen installation." },
            new HobbySlide { ImageUrl = "images/hobbies/Keyboard%20print%20with%20screen/04_Final.jpg",        Title = "Final",      Caption = "Final assembly piece with the screen mounted and wired." },
        ]),

        new("My Dog",
        [
            new HobbySlide { ImageUrl = "images/hobbies/Eevee/01.jpg", Title = "Eevee", Caption = "Eevee watching Ducks." },
            new HobbySlide { ImageUrl = "images/hobbies/Eevee/02.jpg", Title = "Eevee", Caption = "Always happy by water." },
            new HobbySlide { ImageUrl = "images/hobbies/Eevee/03.jpg", Title = "Eevee", Caption = "There are no words." },
            new HobbySlide { ImageUrl = "images/hobbies/Eevee/04.jpg", Title = "Eevee", Caption = "Beach Pupper." },
            new HobbySlide { ImageUrl = "images/hobbies/Eevee/05.jpg", Title = "Eevee", Caption = "Pool Pupper." },
            new HobbySlide { ImageUrl = "images/hobbies/Eevee/06.jpg", Title = "Eevee", Caption = "Hello." },
            new HobbySlide { ImageUrl = "images/hobbies/Eevee/07.jpg", Title = "Eevee", Caption = "Bubble Pup." },
            new HobbySlide { ImageUrl = "images/hobbies/Eevee/08.jpg", Title = "Eevee", Caption = "More Bubble Pup." },
            new HobbySlide { ImageUrl = "images/hobbies/Eevee/09.jpg", Title = "Eevee", Caption = "Sun setting and still full of energy." },
        ]),

        new("Coastal Living",
        [
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/01_Wildlife.jpg",        Title = "Wildlife",           Caption = "Best action shot I've caught out on a boat. Pelican skimming the water." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/02_Wildlife.jpg",        Title = "Shore Birds",        Caption = "The local Heron who hangs out at the Marina and thinks my fishing bait is dinner." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/03_Wildlife.jpg",        Title = "Estuary",            Caption = "Battery Island Bird Sanctuary." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/04_wildlife.jpg",        Title = "Pelicans",           Caption = "Pelicans in formation." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/05_wildlife.jpg",        Title = "Dolphins",           Caption = "Dolphins in the Intracoastal." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/06_Wildlife.png",        Title = "Dolphins",           Caption = "Dolphins following us on the Jetskis." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/07_Pupper.jpg",          Title = "Eevee at the Coast", Caption = "Can't keep a Golden Retriever out of the water." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/08_Pupper.jpg",          Title = "Eevee at the Beach", Caption = "Can't beat a Sunset Beach walk with your best friend." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/09_Pupper.jpg",          Title = "Beach Zoomies",      Caption = "More beach pupper." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/10_Beach_Coffees.jpg",   Title = "Morning Coffee",     Caption = "Coffee with a view." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/11_Beach_Coffees.jpg",   Title = "Beach Coffee",       Caption = "Wash, Rinse, Repeat." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/12_Battleship.jpg",      Title = "USS North Carolina", Caption = "USS North Carolina." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/13_Jetski.jpg",          Title = "Jet Ski",            Caption = "Jetski on the ICW." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/14_Boat.jpg",            Title = "On the Water",       Caption = "Pontoon on the ICW." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/15_Fishing.jpg",         Title = "Fishing",            Caption = "Fishing on the waterway." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/16_Adopted_Turtles.jpg", Title = "Sea Turtles",        Caption = "The first nest my wife and I adopted back in 2023. Now an annual occurrence." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/17_Cargo_Ship.jpg",      Title = "Cargo Ship",         Caption = "Cargo ship on the Cape Fear." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/18_Sunset.jpg",          Title = "Sunset",             Caption = "Sunsets have no bad angles." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/19_Sunset.jpg",          Title = "Sunset",             Caption = "Sunsets have no bad angles." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/20_Sunset.jpg",          Title = "Sunset",             Caption = "Sunsets have no bad angles." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/21_Sunset.jpg",          Title = "Sunset",             Caption = "Sunsets have no bad angles." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/22_Sunset.jpg",          Title = "Sunset",             Caption = "Sunsets have no bad angles." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/23_Sunset.jpg",          Title = "Sunset",             Caption = "Sunset on an Oyster Bed." },
            new HobbySlide { ImageUrl = "images/hobbies/Coastal%20Living/24_Sunset.jpg",          Title = "Sunset",             Caption = "Sunsets have no bad angles." },
        ]),
    ];

    // ── GitHub Pages Deployments ──────────────────────────────────────────────

    public static readonly GitHubPageItem[] GitHubPages =
    [
        new(
            Name:        "Agile Integrity Index Dashboard",
            Url:         "https://tbao23.github.io/Agile-Integrity-Index-Dashboard/",
            Description: "Interactive dashboard companion to the Agile Integrity Index research paper designed to score a team's Scrum adoption across five dimensions."
        ),
    ];

    // ── Certifications ────────────────────────────────────────────────────────

    public static readonly CertificationItem[] Certifications =
    [
        new("Google Data Analytics",       "Coursera / Google",   "2021",
            "https://coursera.org/share/43e21209f7296392e638ad5d8717020a"),
        new("Intro to Python Programming", "edX / Georgia Tech",  "2021",
            "https://credentials.edx.org/credentials/5bb87da6afea46f1b165f53d5b7d933f/"),
    ];
}