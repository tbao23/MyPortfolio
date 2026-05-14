using System.Net.Http.Json;
using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class GitHubService(HttpClient http)
{
    public async Task<List<GitHubRepo>> GetPublicReposAsync()
    {
        var repos = await http.GetFromJsonAsync<List<GitHubRepo>>(
            $"https://api.github.com/users/{SiteConfig.GitHubUsername}/repos?per_page=100&sort=updated");

        return repos?
            .Where(r => !r.Fork)
            .ToList() ?? [];
    }
}
