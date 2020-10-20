using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Models
{
    public class DonHang
    {
        [Key]
        public int DonHangID { get; set; }
        public int SanPhamID { get; set; }
        public double TongTien { get; set; }
        public int KhachHangID { get; set; }
    }
}
