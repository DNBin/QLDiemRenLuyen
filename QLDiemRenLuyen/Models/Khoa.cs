using System;
using System.Collections.Generic;

namespace QLDiemRenLuyen.Models
{
    public partial class Khoa
    {
        public Khoa()
        {
            Lop = new HashSet<Lop>();
        }

        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string Block { get; set; }

        public virtual ICollection<Lop> Lop { get; set; }
    }
}
