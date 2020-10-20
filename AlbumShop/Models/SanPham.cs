using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Models
{
    public class SanPham
    {
        [Key]
        public int SanPhamID { get; set; }
        public int SoLuong { get; set; }
        public int AlbumID { get; set; }
        public double ThanhTien { get; set; }
    }
}
