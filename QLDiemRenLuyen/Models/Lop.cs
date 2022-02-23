using System;
using System.Collections.Generic;

namespace QLDiemRenLuyen.Models
{
    public partial class Lop
    {
        public Lop()
        {
            SinhVien = new HashSet<SinhVien>();
        }

        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public int? MaKhoa { get; set; }
        public string Block { get; set; }

        public virtual Khoa MaKhoaNavigation { get; set; }
        public virtual ICollection<SinhVien> SinhVien { get; set; }
    }
}
