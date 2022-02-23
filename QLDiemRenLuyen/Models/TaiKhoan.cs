using System;
using System.Collections.Generic;

namespace QLDiemRenLuyen.Models
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            CanBo = new HashSet<CanBo>();
            SinhVien = new HashSet<SinhVien>();
        }

        public int TaiKhoanId { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int? MaQuyen { get; set; }
        public string Block { get; set; }
        public DateTime? NgayTao { get; set; }
        public string TrangThai { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public int? PhieuId { get; set; }

        public virtual Quyen MaQuyenNavigation { get; set; }
        public virtual PhieuDanhGia Phieu { get; set; }
        public virtual ICollection<CanBo> CanBo { get; set; }
        public virtual ICollection<SinhVien> SinhVien { get; set; }
    }
}
