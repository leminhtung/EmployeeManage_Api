namespace EmployeeManage.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admin
    {
        [StringLength(50)]
        public string AdminId { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
