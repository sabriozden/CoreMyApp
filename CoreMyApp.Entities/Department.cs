using System.Collections.Generic;
using App.Core.Entity;


namespace CoreMyApp.Entities
{
    public class Department : AuditableEntity<int>, ISoftDelete
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string CompanyName { get; set; }

        public string Designation { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public bool Deleted { get; set; }
    }
}