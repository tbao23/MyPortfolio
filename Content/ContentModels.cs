namespace MyPortfolio.Content;

public record SkillGroup(string Label, string[] Tags);

public record ExperienceItem(
    string YearRange,
    string Title,
    string Organization,
    string[] Bullets
);

public record EducationItem(
    string YearRange,
    string Degree,
    string Institution,
    string? Detail = null
);

public record CourseItem(
    string Code,
    string Name,
    string Credits,
    string Description,
    string[] Tags,
    double? Grade = null,
    string? Status = null
);

public record PaperItem(
    string Course,
    string Semester,
    string Title,
    string? PdfPath,
    string Description,
    string[] Tags
);

public record SchoolProject(
    string OrgAndCourse,
    string Name,
    string Url,
    string Description,
    string[] Tags
);

public record OpenSourceContribution(
    string Org,
    string Repo,
    string Url,
    string Description,
    string[] Tags
);

public record CertificationItem(
    string Name,
    string Issuer,
    string Year,
    string? Url = null
);

public class HobbySlide
{
    public string ImageUrl { get; set; } = "";
    public string Title    { get; set; } = "";
    public string Caption  { get; set; } = "";
}

public record HobbyCategory(string Label, HobbySlide[] Slides);

public record GitHubPageItem(
    string Name,
    string Url,
    string? Description = null
);
