namespace Do_An_Web_K2.Models.GiaoDien
{
    public interface ICommentRepository
    {
        public void AddBinhLuan(BinhLuan Comment);
        IEnumerable<BinhLuan> GetAllComment();
    }
}
