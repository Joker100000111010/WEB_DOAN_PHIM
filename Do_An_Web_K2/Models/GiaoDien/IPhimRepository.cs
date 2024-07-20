namespace Do_An_Web_K2.Models.GiaoDien
{
    public interface IPhimRepository
    {
        IEnumerable<InformationPhim> GetInformationPhims();

        InformationPhim GetInformationVideo(int id);
    }
}
