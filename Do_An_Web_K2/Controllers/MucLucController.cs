using Do_An_Web_K2.Models.DichVu;
using Do_An_Web_K2.Models.GiaoDien;
using Microsoft.AspNetCore.Mvc;

namespace Do_An_Web_K2.Controllers
{
    public class MucLucController : Controller
    {
        private IMucLucPhimRepository MucLucRepository;
        public MucLucController(IMucLucPhimRepository MucLucRepository)
        {
            this.MucLucRepository = MucLucRepository;
        }
        public IActionResult DanhSachLe()
        {
            return View(MucLucRepository.GetInformationPhims());
        }
        public IActionResult DanhSachBo()
        {
            return View(MucLucRepository.GetInformationPhims());
        }
    }
}
