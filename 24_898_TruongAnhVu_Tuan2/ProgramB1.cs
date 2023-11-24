using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class ProgramB1
    {
        static void Main(string[] args)
        {
            //Xuất định dạng Unicode
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //Khởi tạo danh sách giáo viên
            DS_GiaoVien ds = new DS_GiaoVien();
            //ds.NhapDSGV();
            ds.DocXML(@"..\..\danhsach.xml");
            Console.WriteLine("---------DANH SÁCH GIÁO VIÊN----------\nTên giáo viên\tSố nhóm hướng dẫn của giáo viên");
            ds.XuatDSGV();
            Console.Write("\nTổng số nhóm là: {0}\n",ds.TongSoNhom().ToString());
            ds.SXTheoNhom();
            Console.WriteLine("\nSắp xếp theo nhóm");
            ds.XuatDSGV();
            ds.SXTen();
            Console.WriteLine("\nSắp xếp theo tên");
            ds.XuatDSGV();
            List<GiaoVien> dsloc = ds.LocSoNhom();
            Console.WriteLine("\nDanh sách giáo viên dạy lơn hơn 1 nhóm là: ");
            foreach (GiaoVien gv in dsloc)
                gv.Xuat();
            Console.ReadLine();
        }
    }
}
