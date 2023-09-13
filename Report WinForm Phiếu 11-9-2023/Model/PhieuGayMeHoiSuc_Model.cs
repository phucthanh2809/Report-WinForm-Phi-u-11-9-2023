using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_WinForm_Phiếu_11_9_2023.Model
{
    public class PhieuGayMeHoiSuc_Model
    {
        public int iid { get; set; }
        public String SoVaoVien {  get; set; }
        public String Khoa1 {  get; set; }
        public String Khoa2 { get; set; }
        public String HoTen { get; set; }
        public int Tuoi { get; set; }
        public String GioiTinh {  get; set; }
        public int Buong {  get; set; }
        public int Giuong { get; set;}
        public int ChieuCao { get; set; }
        public float CanNang {  get; set; }
        public String NhomMau { get; set; }
        public String ChuanDoan { get; set; }
        public String PPPhauThuat { get; set; }
        public String PPVoCam { get; set; }
        public String BSPhauThuat { get;set; }
        public String BSGayMe { get;set; }
        public int Ngay {  get; set; }
        public int Thang { get; set; }
        public int Nam {  get; set; }
        public String TienMe { get; set; }
        public String TacDung { get; set; }
        public String TuThe { get; set; }

        public PhieuGayMeHoiSuc_Model()
        {

        }

        public PhieuGayMeHoiSuc_Model(int iid, string soVaoVien, string khoa1, string khoa2, string hoTen, int tuoi, string gioiTinh, int buong, int giuong, int chieuCao, float canNang, string nhomMau, string chuanDoan, string pPPhauThuat, string pPVoCam, string bSPhauThuat, string bSGayMe, int ngay, int thang, int nam, string tienMe, string tacDung, string tuThe)
        {
            this.iid = iid;
            SoVaoVien = soVaoVien;
            Khoa1 = khoa1;
            Khoa2 = khoa2;
            HoTen = hoTen;
            Tuoi = tuoi;
            GioiTinh = gioiTinh;
            Buong = buong;
            Giuong = giuong;
            ChieuCao = chieuCao;
            CanNang = canNang;
            NhomMau = nhomMau;
            ChuanDoan = chuanDoan;
            PPPhauThuat = pPPhauThuat;
            PPVoCam = pPVoCam;
            BSPhauThuat = bSPhauThuat;
            BSGayMe = bSGayMe;
            Ngay = ngay;
            Thang = thang;
            Nam = nam;
            TienMe = tienMe;
            TacDung = tacDung;
            TuThe = tuThe;
        }
        public PhieuGayMeHoiSuc_Model( string soVaoVien, string khoa1, string khoa2, string hoTen, int tuoi, string gioiTinh, int buong, int giuong, int chieuCao, float canNang, string nhomMau, string chuanDoan, string pPPhauThuat, string pPVoCam, string bSPhauThuat, string bSGayMe, int ngay, int thang, int nam, string tienMe, string tacDung, string tuThe)
        {
            SoVaoVien = soVaoVien;
            Khoa1 = khoa1;
            Khoa2 = khoa2;
            HoTen = hoTen;
            Tuoi = tuoi;
            GioiTinh = gioiTinh;
            Buong = buong;
            Giuong = giuong;
            ChieuCao = chieuCao;
            CanNang = canNang;
            NhomMau = nhomMau;
            ChuanDoan = chuanDoan;
            PPPhauThuat = pPPhauThuat;
            PPVoCam = pPVoCam;
            BSPhauThuat = bSPhauThuat;
            BSGayMe = bSGayMe;
            Ngay = ngay;
            Thang = thang;
            Nam = nam;
            TienMe = tienMe;
            TacDung = tacDung;
            TuThe = tuThe;
        }
    }
}
