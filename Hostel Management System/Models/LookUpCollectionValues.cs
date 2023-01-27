using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hostel_Management_System.Models
{
    public class LookUpCollectionValues
    {
        [Key]
        public int LookUpCollectionValueId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LookUpCollectionValue { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string IsDeleted { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CreatedOn { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CreatedBy { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ModifiedOn { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ModifiedBy { get; set; }
        public string LookUpCollectionId { get; set; }
        public LookUpCollection LookUpCollection { get; set; }
    }
}
