using portfolio.Models;
using System.Text.Json;

namespace portfolio.Services
{
    public class ProjectService
    {

        public ProjectService()
        {
        }

        public async Task<IEnumerable<ProjectModel>> GetProjects()
        {

            var client = new HttpClient() { BaseAddress = new Uri("https://granthum-api.azurewebsites.net") };

            var json = client.GetAsync("/api/projects").Result.Content.ReadAsStringAsync().Result;

            IEnumerable<ProjectModel> projects = JsonSerializer.Deserialize<IEnumerable<ProjectModel>>(json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return projects;

        }
    }
}
