using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngularCoreCrud.Models
{
public class CitiesRepository :
    GenericRepository<RecordContext, TblCities>, ICitiesRepository {
        RecordContext db = new RecordContext();
                public int AddCiti(TblCities citi)
        {
             try  
            {  
                db.TblCities.Add(citi);  
                db.SaveChanges();  
                return 1;  
            }  
            catch  
            {  
                throw;  
            }  
        }

        public int DeleteCiti(int id)
        {
      try  
            {  
                TblCities citi = db.TblCities.Find(id);  
                db.TblCities.Remove(citi);  
                db.SaveChanges();  
                return 1;  
            }  
            catch  
            {  
                throw;  
            }  
        }

        public IEnumerable<TblCities> GetAllCities()
        {
           try  
            {  
                return db.TblCities.ToList();  
            }  
            catch  
            {  
                throw;  
            }  
        }

        public List<TblCities> GetCities()
        {
          List<TblCities> cities = new List<TblCities>();  
            cities = (from CityList in db.TblCities select CityList).ToList();  
  
            return cities;  
        }

        public TblCities GetSingle(int cityId) {

        var query = GetAll().FirstOrDefault(x => x.CityId == cityId);
        return query;
    }

        public int UpdateCiti(TblCities citi)
        {
           try  
            {  
                db.Entry(citi).State = EntityState.Modified;  
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