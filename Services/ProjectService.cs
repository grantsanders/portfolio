using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Net.Http.Headers;
using portfolio.Models;
using System.Text.Json;

namespace portfolio.Services
{
    public class ProjectService
    {

        public ProjectService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private String JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "simDB", "db.json"); }
        }

        public IEnumerable<ProjectModel> GetProjects()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<ProjectModel[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
