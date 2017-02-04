using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mvc_Core_Application.Data;

namespace Mvc_Core_Application.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index
        {
            get
            {
                return View(_context.Employees.ToList());
            }
        }

        
    }
}