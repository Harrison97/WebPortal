using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebPortal.Models
{
    [Table("UserRole")]
    public class UserRole
    {
        [Key]
        public string UserID { get; set; }
        [Key]
        public string RoleID { get; set; }

    }
}