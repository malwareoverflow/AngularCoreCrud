using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularCoreCrud.Models
{
    public partial class TblEmployee
    {
      [Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public long EmployeeId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
    }
}