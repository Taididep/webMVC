using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using DoAnWeb.Models;

namespace DoAnWeb.Controllers
{
    public class SanPhamController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: SanPham
        public ActionResult Index()
        {
            return View();
        }

        //Hien thi tat ca
        public ActionResult ShowTatCaSanPham()
        {
            return View(db.SANPHAMs.ToList());
        }


        //Hien thi theo loai
        public ActionResult ThoiTrangNamPartial()
        {
            var listSP = db.SANPHAMs.Where(sp => sp.MADANHMUC == 1).Select(sp => sp.LOAISANPHAM).Distinct().ToList();
            return View(listSP);
        }

        public ActionResult ThoiTrangNuPartial()
        {
            var listSP = db.SANPHAMs.Where(sp => sp.MADANHMUC == 2).Select(sp => sp.LOAISANPHAM).Distinct().ToList();
            return View(listSP);
        }
        public ActionResult SanPhamKhuyenMai()
        {
            var listSPKhuyenMai = db.SANPHAMs.Where(sp => sp.UUDAI > 0).ToList();
            return View(listSPKhuyenMai);
        }
        public ActionResult SanPhamMoi()
        {
            var listSPMoi = db.SANPHAMs.Where(sp => sp.NGAYCAPNHAT.HasValue && sp.NGAYCAPNHAT.Value.Year == 2023).ToList();
            return View(listSPMoi);
        }

        public ActionResult ShowTheoLoai(int Ma, int MaDanhMuc)
        {
            var listSP = db.SANPHAMs.Where(sp => sp.MALOAI == Ma && sp.MADANHMUC == MaDanhMuc).ToList();
            return View(listSP);
        }


        //Hien thi theo danh muc
        public ActionResult DanhMucPartial()
        {
            var listSP = db.DANHMUCs.ToList();
            return View(listSP);
        }
        public ActionResult ShowTheoDanhMuc(int Ma)
        {
            var ListSP = db.SANPHAMs.Where(s => s.MADANHMUC == Ma).ToList();
            if (ListSP.Count == 0)
            {
                ViewBag.TB = "Sản Phẩm hiện không có";
            }
            return View(ListSP);
        }

        //Tim Kiem
        public ActionResult Search(string keyword)
        {
            var result = db.SANPHAMs.Where(sp => sp.TENSP.Contains(keyword)).ToList();
            return View(result);
        }

        //Chi tiet san pham
        public ActionResult Details(int id)
        {
            var product = db.SANPHAMs.FirstOrDefault(sp => sp.MASP == id);

            // Kiểm tra xem sản phẩm có tồn tại không
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //GioHang
        public ActionResult ThemGioHang(int masp)
        {
            // Lấy thông tin sản phẩm từ database
            var product = db.SANPHAMs.FirstOrDefault(sp => sp.MASP == masp);

            // Kiểm tra xem sản phẩm có tồn tại không
            if (product == null)
            {
                return HttpNotFound();
            }

            // Kiểm tra xem người dùng đã đăng nhập hay chưa thông qua Session
            if (Session["name"] != null)
            {
                string tendn = Session["name"].ToString();

                var gioHangItem = db.GIOHANGs.FirstOrDefault(g => g.MASP == masp && g.TENDN == tendn);

                if (gioHangItem != null)
                {
                    // Nếu sản phẩm đã có trong giỏ hàng, tăng số lượng
                    gioHangItem.SOLUONG++;
                }
                else
                {
                    // Nếu sản phẩm chưa có trong giỏ hàng, thêm mới vào giỏ hàng
                    var newCartItem = new GIOHANG
                    {
                        TENDN = tendn,
                        MASP = masp,
                        SOLUONG = 1
                    };

                    db.GIOHANGs.InsertOnSubmit(newCartItem);
                }

                // Lưu thay đổi vào database
                db.SubmitChanges();

                // Chuyển hướng đến trang giỏ hàng
                return RedirectToAction("GioHang");
            }
            else
            {
                return RedirectToAction("DangNhap", "Home");
            }
        }


        public ActionResult GioHang()
        {
            string tendn = Session["name"].ToString();

            var cartItems = db.GIOHANGs.Where(g => g.TENDN == tendn).ToList();

            return View(cartItems);
        }


        [HttpPost]
        public ActionResult UpdateQuantity(int productId, int change)
        {
            // Lấy thông tin giỏ hàng từ database
            var cartItem = db.GIOHANGs.FirstOrDefault(g => g.MASP == productId && g.TENDN == Session["name"].ToString());

            if (cartItem != null)
            {
                // Cập nhật số lượng và lưu vào database
                cartItem.SOLUONG += change;
                db.SubmitChanges();
            }

            // Trả về tổng tiền mới
            return Json(cartItem.SANPHAM.GIA * cartItem.SOLUONG);
        }

        [HttpPost]
        public ActionResult DeleteCartItem(int productId)
        {
            // Xóa sản phẩm khỏi giỏ hàng trong database
            var cartItem = db.GIOHANGs.FirstOrDefault(g => g.MASP == productId && g.TENDN == Session["name"].ToString());

            if (cartItem != null)
            {
                db.GIOHANGs.DeleteOnSubmit(cartItem);
                db.SubmitChanges();
            }

            // Trả về success để thông báo xóa thành công
            return Json(new { success = true });
        }
        public ActionResult GetCartItems()
        {
            string tendn = Session["name"].ToString();
            var cartItems = db.GIOHANGs.Where(g => g.TENDN == tendn).ToList();

            return PartialView("Thân_giỏ_hàng", cartItems);
        }

        [HttpPost]
        public ActionResult ProcessPayment(List<int> selectedIds)
        {
            // Kiểm tra xem danh sách có sản phẩm nào được chọn không
            if (selectedIds != null && selectedIds.Count > 0)
            {
                // Lặp qua danh sách các sản phẩm được chọn
                foreach (var productId in selectedIds)
                {
                    // Lấy thông tin sản phẩm trong giỏ hàng
                    var cartItem = db.GIOHANGs.FirstOrDefault(g => g.MASP == productId);

                    if (cartItem != null)
                    {
                        // Trừ đi số lượng trong bảng SANPHAM
                        var product = db.SANPHAMs.FirstOrDefault(p => p.MASP == productId);

                        if (product != null)
                        {
                            // Kiểm tra xem số lượng trong giỏ hàng có lớn hơn số lượng trong bảng SANPHAM không
                            if (cartItem.SOLUONG <= product.SOLUONG)
                            {
                                // Trừ đi số lượng trong bảng SANPHAM
                                product.SOLUONG -= cartItem.SOLUONG;

                                // Xóa sản phẩm khỏi giỏ hàng
                                db.GIOHANGs.DeleteOnSubmit(cartItem);
                            }
                            else
                            {
                                ModelState.AddModelError("", "Không đủ hàng trong kho.");
                                return RedirectToAction("Index");
                            }
                        }
                    }
                }

                db.SubmitChanges();
            }
            return RedirectToAction("GioHang", "SanPham");
        }



    }
}