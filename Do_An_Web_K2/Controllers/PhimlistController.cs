using Do_An_Web_K2.Models;
using Do_An_Web_K2.Models.DichVu;
using Do_An_Web_K2.Models.GiaoDien;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Do_An_Web_K2.Controllers
{
    public class PhimlistController : Controller
    {
        private IPhimRepository phimRepository;
        public PhimlistController(IPhimRepository phimRepository)
        {
            this.phimRepository = phimRepository;
        }
        public IActionResult Phim()
        {
            return View(phimRepository.GetInformationPhims());
        }
        public IActionResult NamPhim(int id)
        {
            var model = phimRepository.GetInformationVideo(id);
            var ThongTinPhim = phimRepository.GetInformationPhims();

            if (model != null)
            {
                var viewModel = new NamPhim
                {
                    MovieYear = model,
                    ThongTinPhim = ThongTinPhim
                };

                return View(viewModel);
            }
            return NotFound();
        }
        public IActionResult Search()
        {
            var ThongTinPhim = phimRepository.GetInformationPhims();
            if (ThongTinPhim != null)
            {
                var viewModel = new TimKiem
                {
                    ThongTinPhim = ThongTinPhim
                };

                return View(viewModel);
            }
            return NotFound(); 
        }

        [Authorize]
        public IActionResult Video(int id)
        {
            var model = phimRepository.GetInformationVideo(id);
            var ThongTinPhim = phimRepository.GetInformationPhims();

            if (model != null)
            {
                var viewModel = new VideoViewModel
                {
                    Video = model,
                    ThongTinPhim = ThongTinPhim
                };

                return View(viewModel);
            }
            return NotFound();
        }

    }
}
