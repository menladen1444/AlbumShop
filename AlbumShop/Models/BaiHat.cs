using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Models
{
    public class BaiHat
    {
        [Key]
        public int BaiHatID { get; set; }
        public string TenBaiHat { get; set; }
        public string LoiBaiHat { get; set; }
        public string ThoiLuong { get; set; }
        public int AlbumID { get; set; }
    }
}
