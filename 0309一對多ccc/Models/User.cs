using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _0309一對多ccc.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //prop
        public int Id { get; set; }

        public int DepartmentID { get; set; }

        [Required]
        [Display(Name = "使用者名稱")]
        [StringLength(50, ErrorMessage = "請輸入姓名", MinimumLength = 3)]
        public string Username { get; set; }

        [Required]
        [Display(Name = "使用者密碼")]
        [StringLength(50, ErrorMessage = "請輸入密碼,至少3字元", MinimumLength = 3)]
        public string Userpassword { get; set; }

        [Required]
        [Display(Name = "使用者電話號碼")]
        [StringLength(50, ErrorMessage = "請輸入電話號碼", MinimumLength = 9)]
        public string Usertel { get; set; }

        [Required]
        [Display(Name = "使用者Email")]
        [StringLength(50, ErrorMessage = "請輸入email")]
        [EmailAddress(ErrorMessage = "非email格式")]
        public string Useremail { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department TestDepartment { get; set; }
    }
}