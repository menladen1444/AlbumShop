using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Models
{
    public class SanPhamYeuThich
    {
        [Key]
        public int SanPhamYeuThichID { get; set; }
        public int KhachHangID { get; set; }
        public int AlbumID { get; set; }

    }
}
