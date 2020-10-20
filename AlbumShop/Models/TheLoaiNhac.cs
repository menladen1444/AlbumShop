using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Models
{
    public class TheLoaiNhac
    {
        [Key]
        public int TheLoaiNhacID { get; set; }
        public string TenTheLoaiNhac { get; set; }
    }
}
