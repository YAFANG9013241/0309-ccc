using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _0309一對多ccc.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //prop
        [Display(Name = "部門編號")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "部門名稱")]
        [StringLength(50, ErrorMessage = "請輸入部門")]
        public string Departmentname { get; set; }
    }
}