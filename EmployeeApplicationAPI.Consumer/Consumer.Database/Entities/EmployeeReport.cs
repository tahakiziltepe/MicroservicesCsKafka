using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.Database.Entities
{
    public class EmployeeReport
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public EmployeeReport(Guid id, Guid EmployeeId, string name, string surname)
        {
            Id = id;
            this.EmployeeId = EmployeeId;
            Name = name;
            Surname = surname;
        }
    }
}
