using EntityFramwork.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork.ETT
{
    [Table("HocVien_tbl")]
    internal class Hocvien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HocVienId { get; set; }
        public string TenHocSinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgayDangKy { get; set; }
        public void Nhap()
        {
            TenHocSinh = InputHelper.InputStr("Nhap ten hoc sinh: ", "Can nhap tu 1 - 20 ky tu", 1, 20);
            SoDienThoai = InputHelper.InputStr("Nhap so dien thoai: ", "Can nhap trong khoang tu 10 - 15 ky tu", 10, 15);
            Email = InputHelper.InputStr("Nhap email: ", "Can nhap tu 1 - 20 ky tu", 1, 20);
            NgaySinh = InputHelper.InputDT("Nhap ngay sinh: ", "loi");
            GioiTinh = InputHelper.InputStr("Nhap gioi tinh: ", "Can nhap dung tu 2 - 4 ky tu", 2, 4);
            NgayDangKy = InputHelper.InputDT("Nhap ngay dang ky: ", "loi");
        }
        public void InThongTin()
        {
            Console.WriteLine("Thong tin hoc vien: ");
            Console.WriteLine($"\tMa hoc sinh: {HocVienId}");
            Console.WriteLine($"\tTen hoc sinh: {TenHocSinh}");
            Console.WriteLine($"\tNgay dang ky: {NgayDangKy.ToShortDateString()}");
        }
    }
}
