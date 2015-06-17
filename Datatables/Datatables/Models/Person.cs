using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Datatables.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Office { get; set; }
        public int Salary { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}