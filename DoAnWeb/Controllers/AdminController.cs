using DoAnWeb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using System.Web.UI;

namespace DoAnWeb.Controllers
{
    public class AdminController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext(ConfigurationManager.ConnectionStrings["DB_LTGFASIONConnectionString"].ConnectionString);
        SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LTGFASIONConnectionString"].ConnectionString);
        // GET: Admin
        public ActionResult QL_Kho()
        {
            var listsp = db.SANPHAMs.ToList();
            return View(listsp);
        }

        public ActionResult ThemSP()
        {
            return View();
        }

        public ActionResult KTThemSP(string MaSP, string TenSP, string GiaSP, string MotaSP, string LoaiSP, string DanhMuc, string NgayCapNhat, string SoLuongSP, string UuDaiSP, string Anh)
        {
            if (MaSP == string.Empty || TenSP == string.Empty || GiaSP == string.Empty || MotaSP == string.Empty || LoaiSP == string.Empty || DanhMuc == string.Empty || NgayCapNhat == string.Empty || SoLuongSP == string.Empty || UuDaiSP == string.Empty || Anh == string.Empty)
                return RedirectToAction("ThemSP", "Admin");

            Connect.Open();
            string Check_MASP = "select * from SANPHAM where MASP = N'" + MaSP + "'";
            SqlCommand cmd1 = new SqlCommand(Check_MASP, Connect);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            if (rd1.Read())
                return RedirectToAction("ThemSP", "Admin");
            Connect.Close();

            Connect.Open();
            string Insert_New = "insert into SANPHAM (MASP, TENSP, GIA, MOTA, DUONGDAN, MALOAI, MADANHMUC, NGAYCAPNHAT, SOLUONG, UUDAI) values ('" + MaSP + "', N'" + TenSP + "', " + GiaSP + ", N'" + MotaSP + "', N'" + Anh + "', " + LoaiSP + ", " + DanhMuc + ", '" + NgayCapNhat + "', " + SoLuongSP + ", " + UuDaiSP + ")";
            SqlCommand cmd2 = new SqlCommand(Insert_New, Connect);
            cmd2.ExecuteNonQuery();
            Connect.Close();           

            return RedirectToAction("QL_Kho", "Admin");
        }

        public ActionResult XoaSP(string id)
        {
            Connect.Open();
            string Xoa = "Delete from SANPHAM where MASP = '" + id + "'";
            SqlCommand cmd = new SqlCommand(Xoa, Connect);
            cmd.ExecuteNonQuery();
            Connect.Close();
            return RedirectToAction("QL_Kho", "Admin");
        }
        public ActionResult SuaSP(string id)
        {
            if (id == null || id == string.Empty)
                return View();
            else
            {
                Session["MaSP"] = id;
                return View();
            }
        }

        public ActionResult KTSuaSP(string MaSP, string TenSP, string GiaSP, string MotaSP, string LoaiSP, string DanhMuc, string NgayCapNhat, string SoLuongSP, string UuDaiSP, string Anh)
        {
            if (TenSP == string.Empty || GiaSP == string.Empty || MotaSP == string.Empty || LoaiSP == string.Empty || DanhMuc == string.Empty || NgayCapNhat == string.Empty || SoLuongSP == string.Empty || UuDaiSP == string.Empty || Anh == string.Empty)
                return RedirectToAction("SuaSP", "Admin");

            Connect.Open();
            string Insert_New = "Update SANPHAM set TENSP = N'" + TenSP + "', GIA = " + GiaSP + ", MOTA = N'" + MotaSP + "', DUONGDAN = N'" + Anh + "', MALOAI = " + LoaiSP + ", MADANHMUC = " + DanhMuc + ", NGAYCAPNHAT = '" + NgayCapNhat + "', SOLUONG = " + SoLuongSP + ", UUDAI = " + UuDaiSP + " where MASP = '" + MaSP + "'";
            SqlCommand cmd2 = new SqlCommand(Insert_New, Connect);
            cmd2.ExecuteNonQuery();
            Connect.Close();

            return RedirectToAction("QL_Kho", "Admin");
        }


        public ActionResult QL_TK()
        {
            var listtk = db.TAIKHOANs.ToList();
            return View(listtk);
        }

        public ActionResult DK_TK()
        {
            return View();
        }

        public ActionResult KTDangKy(string regEmail, string regUsername, string regPassword, string confirmPassword)
        {
            Connect.Open();
            string Check_Email = "select * from TAIKHOAN where EMAIL = N'" + regEmail + "'";
            SqlCommand cmd1 = new SqlCommand(Check_Email, Connect);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            if (rd1.Read())
                return RedirectToAction("DK_TK", "Admin");
            Connect.Close();

            Connect.Open();
            string Check_TenDN = "select * from TAIKHOAN where TENDN = N'" + regUsername + "'";
            SqlCommand cmd2 = new SqlCommand(Check_TenDN, Connect);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            if (rd2.Read())
                return RedirectToAction("DK_TK", "Admin");
            Connect.Close();

            if (regPassword != confirmPassword)
            {
                return RedirectToAction("DK_TK", "Admin");
            }

            Connect.Open();
            string Insert_New = "insert into TAIKHOAN (TENDN, MATKHAU, EMAIL) values (N'" + regUsername + "', N'" + regPassword + "', N'" + regEmail + "')";
            SqlCommand cmd3 = new SqlCommand(Insert_New, Connect);
            cmd3.ExecuteNonQuery();
            Connect.Close();

            return RedirectToAction("QL_TK", "Admin");
        }

        public ActionResult XoaTK(string id)
        {
            Connect.Open();
            string XoaGioHang = "Delete from GIOHANG where TENDN = N'" + id + "'";
            SqlCommand cmd1 = new SqlCommand(XoaGioHang, Connect);
            cmd1.ExecuteNonQuery();
            Connect.Close();

            Connect.Open();
            string XoaTK = "Delete from TAIKHOAN where TENDN = N'" + id + "'";
            SqlCommand cmd2 = new SqlCommand(XoaTK, Connect);
            cmd2.ExecuteNonQuery();
            Connect.Close();

            return RedirectToAction("QL_TK", "Admin");
        }
    }
}