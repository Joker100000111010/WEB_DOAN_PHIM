using Do_An_Web_K2.Models;
using Do_An_Web_K2.Models.GiaoDien;
using Microsoft.AspNetCore.Mvc;

namespace Do_An_Web_K2.Controllers
{
    public class BinhLuanController : Controller
    {
        private readonly ICommentRepository CommentRepository;

        public BinhLuanController(ICommentRepository CommentRepository)
        {
            this.CommentRepository = CommentRepository;
        }

        [HttpPost]
        public IActionResult SubmitBinhLuan(BinhLuan BinhLuan)
        {
            if (ModelState.IsValid)
            {
                // Lưu thông tin liên hệ vào cơ sở dữ liệu
                CommentRepository.AddBinhLuan(BinhLuan);

                // Chuyển hướng hoặc hiển thị thông điệp thành công
                return RedirectToAction("ContactSuccess");
            }

            // Nếu ModelState không hợp lệ, quay lại trang liên hệ
            return View("Index", BinhLuan);
        }

        public IActionResult ContactSuccess()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
