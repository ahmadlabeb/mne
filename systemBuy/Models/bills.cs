using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace systemBuy.Models
{
    public class bills
    {
        public int id { get; set; }
        [Required]
        [DisplayName("جهة الشراء")]
        public string NameBuy { get; set; }
        [Required]
        [DisplayName("رقم الفاتورة")]
        public string billNumber { get; set; }
        [Required]
        [DisplayName("تاريخ الادخال")]
        public DateTime DateBill { get; set; }
        [Required]
        [DisplayName("تاريخ المراجعة")]
        public DateTime theReviewDate { get; set; }
        public virtual ICollection<items> item { get; set; }
        public virtual ICollection<CurruncyUnit> curruncy { get; set; }
    }
}