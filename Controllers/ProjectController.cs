using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers
{
    public class ProjectController : Controller
    {
        private ProjectService _projectService;
        private InvoiceRecordService _invoiceRecordService;
        public ProjectController(ProjectService projectService, InvoiceRecordService invoiceRecordService )
        {
            _projectService = projectService;
            _invoiceRecordService = invoiceRecordService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult listProjects()
        {

            IEnumerable<ProjectModel> projects = _projectService.GetProjects();

            return View(projects);
        }
            
        public IActionResult invoiceLogs() {

            IEnumerable<InvoiceRecordModel> invoices = _invoiceRecordService.GetInvoices();

            return View(invoices);
            }
    }
}
