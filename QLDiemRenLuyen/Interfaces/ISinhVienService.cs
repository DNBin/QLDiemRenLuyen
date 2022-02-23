using QLDiemRenLuyen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemRenLuyen.Interfaces
{
    public interface ISinhVienService
    {
        List<SinhVien> Get();
        SinhVien GetById(int id);
        void Create(SinhVien model);
        void Update(SinhVien model);
        void Delete(SinhVien model);
    }
}
