using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }
        public string TenAlbum { get; set; }
        public string HinhAnh { get; set; }
        public DateTime NgayPhatHanh { get; set; }
        public double GiaBan { get; set; }
        public int SoLuong { get; set; }
        public int TacGiaID { get; set; }
        public int DaBan { get; set; }
        public double DiemDanhGia { get; set; }
        public string XuatXu { get; set; }
        public string MoTa { get; set; }
        public int TheLoaiID { get; set; }
    }
}
