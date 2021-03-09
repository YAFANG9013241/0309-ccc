using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _0309一對多ccc.Models
{
    public class Cus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //prop
        public int Id { get; set; }

        [Required]
        [Display(Name = "顧客名稱")]
        [StringLength(50, ErrorMessage = "請輸入姓名", MinimumLength = 3)]
        public string Cusname { get; set; }

        [Required]
        [Display(Name = "顧客密碼")]
        [StringLength(50, ErrorMessage = "請輸入密碼,至少3字元", MinimumLength = 3)]
        public string Cuspassword { get; set; }

        [Required]
        [Display(Name = "顧客電話號碼")]
        [StringLength(50, ErrorMessage = "請輸入電話號碼", MinimumLength = 9)]
        public string Custel { get; set; }

        [Required]
        [Display(Name = "顧客Email")]
        [StringLength(50, ErrorMessage = "請輸入email")]
        [EmailAddress(ErrorMessage = "非email格式")]
        public string Cusemail { get; set; }
    }
}