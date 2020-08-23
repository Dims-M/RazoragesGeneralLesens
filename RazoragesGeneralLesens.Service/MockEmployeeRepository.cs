using RazoragesGeneralLesens.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazoragesGeneralLesens.Services
{

    /// <summary>
    /// Реализация  интерфейса IEmployeeRepository
    /// 
    /// </summary>
    public class MockEmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// Временный листдля хранения тестовых сущностей
        /// </summary>
        private List<Emplayee> _employeeList;


        public MockEmployeeRepository()
        {
            //Инициализаия листа с пользователями
            
            _employeeList = new List<Emplayee>()
            {
                new Emplayee()
                {
                    Id =0, Name = "Мария", Email = "mry@example.com", PhotoPath="avatar1.png", Department = Dept.HR
                },
                    new Emplayee()
                     {
                    Id =1, Name = "Mark", Email = "Mark@example.com", PhotoPath="avatar1.png", Department = Dept.IT
                     },
                    new Emplayee()
                {
                    Id =2, Name = "Kla", Email = "Kla@example.com", PhotoPath="avatar1.png", Department = Dept.IT
                    },
                    new Emplayee()
                {
                    Id =3, Name = "Руслан", Email = "руслан@example.com", PhotoPath="avatar1.png", Department = Dept.PayRoll
                    },
                    new Emplayee()
                {
                    Id =4, Name = "Стен", Email = "stepan@example.com", PhotoPath="avatar1.png", Department = Dept.HR
                   ,
                   }


            };
        }

        /// <summary>
        /// Получаем лист со всеми пользователями
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Emplayee> GetAllEmplayees()
        {
            return _employeeList;
        }


    }

}


