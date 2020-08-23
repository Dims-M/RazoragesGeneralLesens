using RazoragesGeneralLesens.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazoragesGeneralLesens.Services
{
    /// <summary>
    /// Интрефейс для работы(Методы) с БД.
    /// </summary>
   public interface IEmployeeRepository
    {
        /// <summary>
        /// Получитьвсех сотридников из Бд
        /// </summary>
        /// <returns></returns>
        IEnumerable<Emplayee> GetAllEmplayees();
        

    }
}
