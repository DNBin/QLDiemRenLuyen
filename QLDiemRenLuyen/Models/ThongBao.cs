using System;
using System.Collections.Generic;

namespace QLDiemRenLuyen.Models
{
    public partial class ThongBao
    {
        public int ThongBaoId { get; set; }
        public int? PhieuId { get; set; }
        public DateTime? NgayThongBao { get; set; }
        public string NoiDungTb { get; set; }
        public DateTime? NgayBdSv { get; set; }
        public DateTime? NgayKtSv { get; set; }
        public DateTime? NgayBdCbl { get; set; }
        public DateTime? NgayKtCbl { get; set; }
        public DateTime? NgayBdCbk { get; set; }
        public DateTime? NgayKtCbk { get; set; }
        public string TrangThai { get; set; }

        public virtual PhieuDanhGia Phieu { get; set; }
    }
}
