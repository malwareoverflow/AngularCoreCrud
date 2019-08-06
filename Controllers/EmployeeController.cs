using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCoreCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularCoreCrud.Controllers
{

 [Route("api/[controller]")]

 public class EmployeeController : Controller  
    {  
        EmployeeRepository empRepo = new EmployeeRepository();  
  

   CitiesRepository cityRepo = new CitiesRepository();  
  
        [HttpGet]  
        [Route("api/Employee/Index")]  
        public IEnumerable<TblEmployee> Index()  
        {  
            return empRepo.GetAll();  
        }  
  
        [HttpPost]  
        [Route("api/Employee/Create")]  
        public int Create([FromBody] TblEmployee employee)  
        {  
            try{

                 empRepo.Add(employee); 
                 return 1; 
            }catch(Exception){
return 0;
            }
            
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
            try{
empRepo.Edit(employee);  
return 1;

            }catch(Exception){
                return 0;
            }
        }  
  
        [HttpDelete]  
        [Route("api/Employee/Delete/{id}")]  
        public int Delete(int id)  
        {  
            try{

empRepo.Delete(new TblEmployee(){EmployeeId=id});
return 1;
            }catch(Exception)
            {
return 0;
            }
      
        }  
  
        [HttpGet]  
        [Route("api/Employee/GetCityList")]  
        public IEnumerable<TblCities> Details()  
        {  
            return cityRepo.GetAll();  
        }  
    }  
}