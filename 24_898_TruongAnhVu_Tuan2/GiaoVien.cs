using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class GiaoVien
    {
        string tenGV;
        int soNhom;
        public string TenGV
        {
            get { return tenGV; }
            set { tenGV = value; }
        }
        public int SoNhom
        {
            get { return soNhom; }
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Số nhóm không hợp lệ, Gán bằng 0");
                    soNhom = 0;
                }
                else soNhom = value;
            }
        }
        public GiaoVien()
        {
            TenGV = "";
            SoNhom = 1;
        }
        public GiaoVien(string TenGV, int SoNhom)
        {
            this.TenGV = TenGV;
            this.SoNhom = SoNhom;
        }

        public void Nhap()
        {
            Console.Write("Nhập họ tên cho giáo viên: ");
            TenGV = Console.ReadLine();
            Console.Write("Nhập số nhóm hướng dẫn: ");
            SoNhom = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("{0}\t{1}", tenGV, soNhom);
        }
    }
}
