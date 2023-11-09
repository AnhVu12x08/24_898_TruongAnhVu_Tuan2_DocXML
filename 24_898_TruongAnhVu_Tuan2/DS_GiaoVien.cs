using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Bai1
{
    class DS_GiaoVien
    {
        List<GiaoVien> listgv;
        public List<GiaoVien> ListGV
        {
            get { return listgv; }
            set { listgv = value; }
        }
        public DS_GiaoVien()
        {
            listgv = new List<GiaoVien>();
        }

        public void NhapDSGV()
        {
            int choice;
            Console.Write("Nhập vào số lượng giáo viên: ");
            choice = int.Parse(Console.ReadLine());
            for (int i = 0; i < choice; i++)
            {
                GiaoVien gv = new GiaoVien();
                gv.Nhap();
                listgv.Add(gv);
            }
        }
        public void XuatDSGV() 
        {
            foreach (GiaoVien x in listgv)
                x.Xuat();
        }
        public int TongSoNhom()
        {
            int sum = 0;
            sum =+ ListGV.Sum(gv => gv.SoNhom);
            return sum; 
        }

        //sắp xếp giáo viên theo tên
        public void SXTen()
        {
            listgv = listgv.OrderBy(t => t.TenGV).ToList(); 
        }
        public void DocXML(string filepath)
        {
            XmlDocument read = new XmlDocument();
            read.Load(filepath);
            XmlNodeList nodelist = read.SelectNodes("danhsach/giaovien");
            foreach (XmlNode node in nodelist)
            {
                string hoten = node["hoten"].InnerText;
                int sonhom = int.Parse(node["sonhom"].InnerText);
                GiaoVien gv = new GiaoVien(hoten, sonhom);
                listgv.Add(gv);
            }
        }



        //sắp xếp giáo viên theo nhóm
        public void SXTheoNhom()
        {
            listgv = listgv.OrderByDescending(t => t.SoNhom).ToList();
        }
        public List<GiaoVien> LocSoNhom()
        {
            return listgv.Where(t => t.SoNhom > 1).ToList();
        }
 
    }
}
