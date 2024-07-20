
using Do_An_Web_K2.Data;
using Do_An_Web_K2.Models.GiaoDien;
using Microsoft.EntityFrameworkCore;

namespace Do_An_Web_K2.Models.DichVu
{
    public class PhimRepository : IPhimRepository
    {
        private PhimDbContext dbContext;
        public PhimRepository(PhimDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<InformationPhim> SearchByKey(string key)
        {
            return dbContext.InformationPhim.FromSqlRaw("select * from InformationPhim where TieuDePhim like N'%" + key+"%'").ToList();
        }

        public IEnumerable<InformationPhim> GetInformationPhims()
        {
            return dbContext.InformationPhim;
        }
        public InformationPhim? GetInformationVideo(int id)
        {
            return dbContext.InformationPhim.FirstOrDefault(p => p.Id == id);

        }
    }
}
