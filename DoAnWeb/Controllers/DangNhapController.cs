using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using DoAnWeb.Models;
using System.Web.Http;

namespace DoAnWeb.Controllers
{
    public class DangNhapController : Controller
    {
        // GET: DangNhap
        SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LTGFASIONConnectionString"].ConnectionString);


        public ActionResult KTDangNhap(string TenDangNhap, string MatKhau)
        {
            Connect.Open();
            string Check_DN = "Select * from TAIKHOAN where TENDN = N'" + TenDangNhap + "' and MATKHAU = N'" + MatKhau + "'";
            SqlCommand cmd = new SqlCommand(Check_DN, Connect);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                if (TenDangNhap == "Admin")
                    return RedirectToAction("QL_Kho", "Admin");

                Session["name"] = TenDangNhap;
                Connect.Close();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Connect.Close();
                return RedirectToAction("DangNhap", "Home");
            }
        }

        public ActionResult DangXuat(string TenDangNhap, string MatKhau)
        {
            Session["name"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}