using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hostel_Management_System.Models
{
    public class LookUpCollection
    {
        [Key]
        public int LookUpCollectionId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LookUpCollectionName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string IsDeleted { get; set; }
    }
}
