using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngularCoreCrud.Models
{
    public partial class TblEmployee
    {
        [Key]
        public long EmployeeId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
    }
}
