using System;
using System.Collections.Generic;

namespace MutlubievWebApiProject.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Gender { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string About { get; set; }
        public string Tel { get; set; }
    }
}
