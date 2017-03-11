namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string username { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string password { get; set; }
    }
}
