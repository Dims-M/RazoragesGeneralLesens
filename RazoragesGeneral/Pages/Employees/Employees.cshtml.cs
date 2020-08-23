using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazoragesGeneralLesens.Services;
using RazoragesGeneralLesens.Models;

namespace RazoragesGeneral.Pages.Employees
{
    //"Представление контролера" Employees
    public class EmployeesModel : PageModel
    {
        private readonly IEmployeeRepository _db;

        public EmployeesModel(IEmployeeRepository db)
        {
            _db = db; // Подключение к Бд
        }

        public IEnumerable<Emplayee> Employees { get; set; }

        public void OnGet()
        {
            Employees = _db.GetAllEmplayees();
        }
    }
}