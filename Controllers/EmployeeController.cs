using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCoreCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularCoreCrud.Controllers
{

 public class EmployeeController : Controller  
    {  
        EmployeeRepository empRepo = new EmployeeRepository();  
  

   CitiesRepository cityRepo = new CitiesRepository();  
  
        [HttpGet]  
        [Route("api/Employee/Index")]  
        public IEnumerable<TblEmployee> Index()  
        {  
            return empRepo.GetAllEmployees();  
        }  
  
        [HttpPost]  
        [Route("api/Employee/Create")]  
        public int Create([FromBody] TblEmployee employee)  
        {  
            return empRepo.AddEmployee(employee);  
        }  
  
        [HttpGet]  
        [Route("api/Employee/Details/{id}")]  
        public TblEmployee Details(int id)  
        {  
            return empRepo.GetSingle(id);  
        }  
  
        [HttpPut]  
        [Route("api/Employee/Edit")]  
        public int Edit([FromBody]TblEmployee employee)  
        {  
            return empRepo.UpdateEmployee(employee);  
        }  
  
        [HttpDelete]  
        [Route("api/Employee/Delete/{id}")]  
        public int Delete(int id)  
        {  
            return empRepo.DeleteEmployee(id);  
        }  
  
        [HttpGet]  
        [Route("api/Employee/GetCityList")]  
        public IEnumerable<TblCities> Details()  
        {  
            return cityRepo.GetCities();  
        }  
    }  
}