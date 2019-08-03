using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngularCoreCrud.Models
{

   public interface ICitiesRepository : IGenericRepository<TblCities> {
    
    TblCities GetSingle(int cityId);
    IEnumerable<TblCities> GetAllCities();

 int AddCiti(TblCities citi);


 int UpdateCiti(TblCities citi);

 int DeleteCiti(int id);


List<TblCities> GetCities();

   }
} 
