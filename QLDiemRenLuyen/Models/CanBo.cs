using System;
using System.Collections.Generic;

namespace QLDiemRenLuyen.Models
{
    public partial class CanBo
    {
        public int CanBoId { get; set; }
        public string MaGv { get; set; }
        public int? ChucVuId { get; set; }
        public int? TaiKhoanId { get; set; }
        public string Block { get; set; }

        public virtual ChucVu ChucVu { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
