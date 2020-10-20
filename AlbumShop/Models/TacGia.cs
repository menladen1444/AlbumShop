using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Models
{
    public class TacGia
    {
        [Key]
        public int TacGiaID { get; set; }
        public string TenTacGia { get; set; }
        public string GioiThieuTacGia { get; set; }
        public int NamSinhTacGia { get; set; }
        public string NoiSinhTacGia { get; set; }
    }
}
