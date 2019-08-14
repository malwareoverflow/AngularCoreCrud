using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngularCoreCrud.Models
{
public class CitiesRepository :
    GenericRepository<RecordContext, TblCities>, ICitiesRepository {
   
    }

}