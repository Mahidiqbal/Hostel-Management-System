using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hostel_Management_System.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string UserName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string UserCNIC { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UserPhone { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UserEmail { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UserBD { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UserAddress { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UserRole { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UserStatus { get; set; }
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
        [Column(TypeName = "nvarchar(50)")]
        public string UserLogin { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Password { get; set; }
    }
}
