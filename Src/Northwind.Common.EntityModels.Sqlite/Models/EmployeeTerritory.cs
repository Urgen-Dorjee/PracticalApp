using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Common.EntityModels.Sqlite.Models
{
    [Keyless]
    public partial class EmployeeTerritory
    {
        [Column(TypeName = "int")]
        public int EmployeeId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        public string TerritoryId { get; set; } = null!;
    }
}
