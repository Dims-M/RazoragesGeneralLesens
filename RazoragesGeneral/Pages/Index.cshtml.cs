using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazoragesGeneral.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// Обьект для логирования
        /// </summary>
        private readonly ILogger<IndexModel> _logger;

        public string Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // Такой метод обрабатывает GET запросы
        public void OnGet()
        {
       
            Message = $"Запуск метода  в контролере(IndexModel) \n {DateTime.Now.ToLocalTime()} ";

        }
    }
}
