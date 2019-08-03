using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngularCoreCrud.Models
{
public class EmployeeRepository :
    GenericRepository<RecordContext, TblEmployee>, IEmployeeRepository {

 RecordContext db = new RecordContext();


        public int AddEmployee(TblEmployee employee)
        {
            try  
            {  
                db.TblEmployee.Add(employee);  
                db.SaveChanges();  
                return 1;  
            }  
            catch  
            {  
                throw;  
            }  
        }

        public int DeleteEmployee(int id)
        {
           try  
            {  
                TblEmployee citi = db.TblEmployee.Find(id);  
                db.TblEmployee.Remove(citi);  
                db.SaveChanges();  
                return 1;  
            }  
            catch  
            {  
                throw;  
            }  
        }

        public IEnumerable<TblEmployee> GetAllEmployees()
        {
          try  
            {  
                return db.TblEmployee.ToList();  
            }  
            catch  
            {  
                throw;  
            }  
        }

        public List<TblEmployee> GetEmployees()
        {
             List<TblEmployee> employees = new List<TblEmployee>();  
            employees = (from CityList in db.TblEmployee select CityList).ToList();  
  
            return employees;  
        }

        public TblEmployee GetSingle(int empId) {

        var query = GetAll().FirstOrDefault(x => x.EmployeeId == empId);
        return query;
    }

        public int UpdateEmployee(TblEmployee employee)
        {
           try  
            {  
                db.Entry(employee).State = EntityState.Modified;  
                db.SaveChanges();  
  
                return 1;  
            }  
            catch  
            {  
                throw;  
            }  
        }
    }

}