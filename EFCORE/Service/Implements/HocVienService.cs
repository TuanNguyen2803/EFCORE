using EntityFramwork.ETT;
using EntityFramwork.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork.Service.Implements
{
    internal class HocVienService : IHocVienService
    {
        private readonly AppDbContext context;
        public HocVienService()
        {
            context = new AppDbContext();
        }
        public string CapNhatHocVien(int hocVienId)
        {
            Hocvien checkHocVien = context.hocviens.Find(hocVienId);
            if (checkHocVien is null)
            {
                return "Khong ton tai";
            }
            else
            {
                checkHocVien.Nhap();
                context.hocviens.Update(checkHocVien);
                context.SaveChanges();
                return "cap nhat thanh cong";
            }
        }

        public List<Hocvien> HienThiHocVien()
        {
            var list = context.hocviens.OrderByDescending(x => x.NgayDangKy).ToList();
            return list;
        }

        public List<Hocvien> HienThiHocVienTheoDieuKien(int namSinh, string hoTen)
        {
            var list = context.hocviens.Where(x => x.NgaySinh.Year == namSinh && x.TenHocSinh.ToLower().Contains(hoTen.ToLower())).ToList();
            return list;
        }

        public string ThemHocVien()
        {
            try
            {
                Hocvien hocvien = new Hocvien();
                hocvien.Nhap();
                context.hocviens.Add(hocvien);
                context.SaveChanges();
                return "Them thanh cong";
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string XoaHocVien(int hocVienId)
        {
            Hocvien checkHocVien = context.hocviens.Find(hocVienId);
            if(checkHocVien is null)
            {
                return "Khong ton tai";
            }
            else
            {
                context.hocviens.Remove(checkHocVien);
                context.SaveChanges();
                return "xoa thanh cong";
            }
        }
    }
}
