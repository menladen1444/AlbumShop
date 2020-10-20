using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Models
{
    public class HinhAnhNoiBat
    {
        [Key]
        public int HinhAnhNoiBatID { get; set; }
        public string HinhAnh { get; set; }
        public string TenHinhAnh { get; set; }
        public string ClassName { get; set; }
    }
}
