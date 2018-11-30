using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebPortal.Models
{
    [Table("Links")]
    public class Link
    {
        [Key]
        public string LinkID { get; set; }
        [StringLength(256)]
        public string URL { get; set; }
        [StringLength(32)]
        public string LinkName { get; set; }
    }
}