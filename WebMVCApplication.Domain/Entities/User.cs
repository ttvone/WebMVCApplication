namespace WebMVCApplication.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(80)]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(64)]
        public string UserPassword { get; set; }

        public short UserRole { get; set; }

        public DateTime UserCreated { get; set; }

        public DateTime UserUpdated { get; set; }
    }
}
