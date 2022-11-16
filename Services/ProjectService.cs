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

            var client = new HttpClient() { BaseAddress = new Uri("https://granthum-api.azurewebsites.net") };

            var json = client.GetAsync("/api/projects").Result.Content.ReadAsStringAsync().Result;

            IEnumerable<ProjectModel> projects = JsonSerializer.Deserialize<IEnumerable<ProjectModel>>(json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            Console.WriteLine(projects);
            return projects;


            //using (var jsonFileReader = File.OpenText(JsonFileName))
            //{
            //    return JsonSerializer.Deserialize<ProjectModel[]>(jsonFileReader.ReadToEnd(),
            //        new JsonSerializerOptions
            //        {
            //            PropertyNameCaseInsensitive = true
            //        });
            //}
        }
    }
}
