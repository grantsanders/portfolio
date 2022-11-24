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

        public async Task<IActionResult> listProjects()
        {

            IEnumerable<ProjectModel> projects = await _projectService.GetProjects();

            return View(projects);
        }
            
        public async Task<IActionResult> invoiceLogs() {

            IEnumerable<InvoiceRecordModel> invoices = await _invoiceRecordService.GetInvoices();

            return View(invoices);
            }
    }
}
