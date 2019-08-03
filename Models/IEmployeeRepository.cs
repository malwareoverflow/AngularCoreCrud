using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngularCoreCrud.Models
{

   public interface IEmployeeRepository : IGenericRepository<TblEmployee> {
    
    TblEmployee GetSingle(int empId);


 

   }
} 
