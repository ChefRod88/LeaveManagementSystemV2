using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Web.Data
{
    public class LeaveType
    {
        
        public int Id { get; set; } // EF Core will know its a primary key
        [Column(TypeName = "varchar(150)")]
        public string Name { get; set; }

        public int NumberOfDays { get; set; }
    }
}
