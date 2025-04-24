using QMS.core.DatabaseContext.Shared;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QMS.core.DatabaseContext
{
    [Table("tbl_UserDetail")]
    public class UserDetail : SqlTable
    {
        //-----------------------------------
        // SqlTable override
        //-----------------------------------
        [Key]
        [Column("UserId")]
        public override int Id { get; set; }

        [Column("IsDeleted")]
        public override bool Deleted { get; set; }
        //------------ END overrides --------

        [Column("Name")]
        [StringLength(50)]
        public string? Name { get; set; }

        [Column("Email")]
        [StringLength(50)]
        [EmailAddress]
        public string? Email { get; set; }

        [Column("Username")]
        [StringLength(50)]
        public string? Username { get; set; }

        [Column("Password")]
        [StringLength(50)]
        // Use hashed passwords (e.g., VARCHAR(255) in DB)
        public string? Password { get; set; }

        [Column("CreatedDate")]
        public DateTime? CreatedDate { get; set; }
    }
}