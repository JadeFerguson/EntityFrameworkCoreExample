using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
    public class Student
    {
        [Key] // will mark as primary key
        public int Id { get; set; } // will assume primary key because of ID property

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string EmailAddress { get; set; }
    }
}
