using EntityFramwork.Helper;
using EntityFramwork.Service.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork.View
{
    internal class HocVienView
    {
        public HocVienService hocVienService = new HocVienService();
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("--------------Quan ly hoc vien--------------");
            Console.WriteLine("1. Hien thi hoc vien");
            Console.WriteLine("2. Hien thi hoc vien theo ten va nam sinh");
            Console.WriteLine("3. Them hoc vien");
            Console.WriteLine("4. Cap nhat thong tin hoc vien");
            Console.WriteLine("5. Xoa hoc vien");
            Console.WriteLine("6. Thoat");
            Console.WriteLine();
            Console.Write("Chon: ");
            int luaChon = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Action(luaChon);
        }
        private void Action(int luaChon)
        {
            switch(luaChon)
            {
                case 1:
                    hocVienService.HienThiHocVien().ForEach(x => x.InThongTin());
                    break;
                case 2:
                    Console.Write("Nhap nam sinh: ");
                    int namSinh = int.Parse(Console.ReadLine());
                    string hoTen = InputHelper.InputStr("Nhap ten hoc sinh muon tim: ", "Can nhap trong khoang tu 1 - 20 ky tu", 1, 20);
                    hocVienService.HienThiHocVienTheoDieuKien(namSinh, hoTen).ForEach(x => x.InThongTin());
                    break;
                case 3:
                    Console.WriteLine(hocVienService.ThemHocVien());
                    break;
                case 4:
                    Console.WriteLine("Nhap ma hoc vien: ");
                    int hocVienId = int.Parse(Console.ReadLine());
                    Console.WriteLine(hocVienService.CapNhatHocVien(hocVienId));
                    break;
                case 5:
                    Console.WriteLine("Nhap ma hoc vien: ");
                    int hocVienID = int.Parse(Console.ReadLine());
                    Console.WriteLine(hocVienService.XoaHocVien(hocVienID));
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
