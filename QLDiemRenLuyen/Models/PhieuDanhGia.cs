using System;
using System.Collections.Generic;

namespace QLDiemRenLuyen.Models
{
    public partial class PhieuDanhGia
    {
        public PhieuDanhGia()
        {
            Diem = new HashSet<Diem>();
            TaiKhoan = new HashSet<TaiKhoan>();
            ThongBao = new HashSet<ThongBao>();
        }

        public int PhieuId { get; set; }
        public int? SinhVienId { get; set; }
        public int? CanBoLopId { get; set; }
        public int? CanBoId { get; set; }
        public DateTime? NgayDanhGia { get; set; }

        public virtual ICollection<Diem> Diem { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoan { get; set; }
        public virtual ICollection<ThongBao> ThongBao { get; set; }
    }
}
