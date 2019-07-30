namespace EmployeeManage.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        
        [Column(Order = 1)]
        [StringLength(50)]
        public string Username { get; set; }
        
        [Column(Order = 2)]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        
        [Column(Order = 3)]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
