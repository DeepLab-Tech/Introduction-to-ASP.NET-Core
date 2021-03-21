using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DapperRecap.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        [NotMapped]
        public List<Employee> Employees { get; set; }

    }
}