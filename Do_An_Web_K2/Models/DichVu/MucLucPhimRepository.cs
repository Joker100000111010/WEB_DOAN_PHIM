using Do_An_Web_K2.Data;
using Do_An_Web_K2.Models.GiaoDien;
using Microsoft.EntityFrameworkCore;

namespace Do_An_Web_K2.Models.DichVu
{
    public class MucLucPhimRepository :IMucLucPhimRepository
    {
        private PhimDbContext dbContext;
        public MucLucPhimRepository(PhimDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<MucLucPhim> GetInformationPhims()
        {
            return dbContext.MucLucPhims;
        }
        public MucLucPhim? GetInformationVideo(int id)
        {
            return dbContext.MucLucPhims.FirstOrDefault(p => p.Id == id);

        }
    }
}
