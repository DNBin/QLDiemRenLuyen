using QLDiemRenLuyen.Data;
using QLDiemRenLuyen.Interfaces;
using QLDiemRenLuyen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLDiemRenLuyen.Services
{
    public class SinhVienService : ISinhVienService
    {
        private DataContext _context;
        public SinhVienService(DataContext context)
        {
            _context = context;
        }
        public void Create(SinhVien model)
        {
            var entity = new SinhVien();
            entity.MaSinhVien = model.MaSinhVien;
            entity.MaLop = model.MaLop;
            entity.ChucVuId = model.ChucVuId;
            entity.Block = model.Block;
            entity.TaiKhoanId = model.TaiKhoanId;
            _context.SinhViens.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(SinhVien model)
        {
            var entity = _context.SinhViens.Where(x => x.SinhVienId == model.SinhVienId).FirstOrDefault();
            if (entity == default)
                throw new Exception("Không tìm thấy dữ liệu.");

            _context.SinhViens.Remove(entity);
            _context.SaveChanges();
        }

        public List<SinhVien> Get()
        {
            return _context.SinhViens.ToList();
        }

        public SinhVien GetById(int id)
        {
            return _context.SinhViens.Where(x => x.SinhVienId == id).FirstOrDefault();
        }

        public void Update(SinhVien model)
        {
            var entity = _context.SinhViens.Where(x => x.SinhVienId == model.SinhVienId).FirstOrDefault();
            if (entity == default)
                throw new Exception("Không tìm thấy dữ liệu.");
            entity.MaSinhVien = model.MaSinhVien;
            entity.MaLop = model.MaLop;
            entity.ChucVuId = model.ChucVuId;
            entity.Block = model.Block;
            entity.TaiKhoanId = model.TaiKhoanId;
            _context.SaveChanges();
        }
    }
}