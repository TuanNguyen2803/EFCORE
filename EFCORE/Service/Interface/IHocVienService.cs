using EntityFramwork.ETT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork.Service.Interface
{
    internal interface IHocVienService
    {
        List<Hocvien> HienThiHocVien();
        List<Hocvien> HienThiHocVienTheoDieuKien(int namSinh, string hoTen);
        string ThemHocVien();
        string CapNhatHocVien(int hocVienId);
        string XoaHocVien(int hocVienId);
    }
}
