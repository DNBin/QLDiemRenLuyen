using System;
using System.Collections.Generic;

namespace QLDiemRenLuyen.Models
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            CanBo = new HashSet<CanBo>();
            SinhVien = new HashSet<SinhVien>();
        }

        public int ChucVuId { get; set; }
        public string TenChucVu { get; set; }

        public virtual ICollection<CanBo> CanBo { get; set; }
        public virtual ICollection<SinhVien> SinhVien { get; set; }
    }
}
