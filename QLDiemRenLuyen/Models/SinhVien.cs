using System;
using System.Collections.Generic;

namespace QLDiemRenLuyen.Models
{
    public partial class SinhVien
    {
        public int SinhVienId { get; set; }
        public string MaSinhVien { get; set; }
        public int? MaLop { get; set; }
        public int? ChucVuId { get; set; }
        public string Block { get; set; }
        public int? TaiKhoanId { get; set; }

        public virtual ChucVu ChucVu { get; set; }
        public virtual Lop MaLopNavigation { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
