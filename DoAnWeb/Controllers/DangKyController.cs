using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb.Controllers
{
    public class DangKyController : Controller
    {
        // GET: DangKy
        SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_LTGFASIONConnectionString"].ConnectionString);

        public ActionResult KTDangKy(string regEmail, string regUsername, string regPassword, string confirmPassword)
        {
            Connect.Open();
            string Check_Email = "select * from TAIKHOAN where EMAIL = N'" + regEmail + "'";
            SqlCommand cmd1 = new SqlCommand(Check_Email, Connect);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            if (rd1.Read())
                return RedirectToAction("DangKy", "Home");
            Connect.Close();

            Connect.Open();
            string Check_TenDN = "select * from TAIKHOAN where TENDN = N'" + regUsername + "'";
            SqlCommand cmd2 = new SqlCommand(Check_TenDN, Connect);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            if (rd2.Read())
                return RedirectToAction("DangKy", "Home");
            Connect.Close();

            if (regPassword != confirmPassword)
            {
                return RedirectToAction("DangKy", "Home");
            }

            Connect.Open();
            string Insert_New = "insert into TAIKHOAN (TENDN, MATKHAU, EMAIL) values (N'" + regUsername + "', N'" + regPassword + "', N'" + regEmail + "')";
            SqlCommand cmd3 = new SqlCommand(Insert_New, Connect);
            cmd3.ExecuteNonQuery();
            Connect.Close();

            return RedirectToAction("DangNhap", "Home");
        }
    }
}