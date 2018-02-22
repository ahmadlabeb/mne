using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace systemBuy.Models
{
    public class items
    {
        public int id { get; set; }
        [Required]
        [DisplayName("اسم الصنف")]
        public string nameItem { get; set; }
        [Required]
        [DisplayName("مواصفات الصنف")]
        public string descriptions { get; set; }
        [Required]
        [DisplayName("brand")]
        public string brand { get; set; }
        [Required]
        [DisplayName("الرقم التسلسلي")]
        public string serialNamber { get; set; }
        [Required]
        [DisplayName("قارئ الباركود")]
        public string barcode { get; set; }
        public int Itembills_id { get; set; }
        public virtual bills bills { get; set; }

    }
}