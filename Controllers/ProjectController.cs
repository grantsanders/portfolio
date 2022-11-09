using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers
{
    public class ProjectController : Controller
    {
        private ProjectService _projectService;

        public ProjectController(ProjectService projectService )
        {
            _projectService = projectService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult listProjects()
        {
            IEnumerable<ProjectModel> projects = (IEnumerable<ProjectModel>)_projectService.GetProjects();

            return View(projects);
        }
    }
}
