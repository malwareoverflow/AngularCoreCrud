using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCoreCrud.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AngularCoreCrud.Controllers
{

 
//[Authorize]
  // [Route("[controller]")]


 public class EmployeeController : Controller  
    {  
//         EmployeeRepository empRepo = new EmployeeRepository();  
//   CitiesRepository cityRepo = new CitiesRepository();  
private readonly IEmployeeRepository empRepo;

private readonly ICitiesRepository cityRepo;
  public EmployeeController(IEmployeeRepository employee, ICitiesRepository cities)
    {
      empRepo=employee;
      cityRepo=cities;
    }

   
  
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
            }catch(Exception ex){
return 0;
            }
            
        }  
  
        [HttpGet]  
        [Route("api/Employee/Details/{id}")]  
        public TblEmployee Details(int id)  
        {  
            return empRepo.FindBy(x=>x.EmployeeId==id).FirstOrDefault();  
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