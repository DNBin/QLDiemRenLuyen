using System;
using System.Collections.Generic;

namespace QLDiemRenLuyen.Models
{
    public partial class Quyen
    {
        public Quyen()
        {
            TaiKhoan = new HashSet<TaiKhoan>();
        }

        public int MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public string MoTa { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoan { get; set; }
    }
}
