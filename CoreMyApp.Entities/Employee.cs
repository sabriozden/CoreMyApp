using App.Core.Entity;

namespace CoreMyApp.Entities
{
    public class Employee : AuditableEntity<long>, ISoftDelete
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string CompanyName { get; set; }

        public string Designation { get; set; }

        public Department Department { get; set; }
        public bool Deleted { get; set; }
    }
}