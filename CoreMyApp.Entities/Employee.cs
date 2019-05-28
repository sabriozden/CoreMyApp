using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMyApp.Entities
{
    [Table("employee")]
    public class Employee
    {
        [Column("id")]
        [Key]
        public long Id { get; set; }

        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("address")]
        [StringLength(200)]
        public string Address { get; set; }

        [Column("companyname")]
        [StringLength(300)]
        public string CompanyName { get; set; }

        [Column("designation")]
        [StringLength(400)]
        public string Designation { get; set; }

        public Department Department { get; set; }
    }
}