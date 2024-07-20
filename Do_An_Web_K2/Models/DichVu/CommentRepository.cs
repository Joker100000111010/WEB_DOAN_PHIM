using Do_An_Web_K2.Data;
using Do_An_Web_K2.Models.GiaoDien;

namespace Do_An_Web_K2.Models.DichVu
{
    public class CommentRepository : ICommentRepository
    {
        private PhimDbContext dbContext;
        public CommentRepository(PhimDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void AddBinhLuan(BinhLuan Comment)
        {
            dbContext.BinhLuans.Add(Comment);
            dbContext.SaveChanges();
        }

        public IEnumerable<BinhLuan> GetAllComment()
        {
            return dbContext.BinhLuans.ToList();
        }
    }
}
