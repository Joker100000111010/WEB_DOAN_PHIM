namespace Do_An_Web_K2.Models.GiaoDien
{
    public interface IMucLucPhimRepository
    {
        IEnumerable<MucLucPhim> GetInformationPhims();

        MucLucPhim GetInformationVideo(int id);
    }
}
