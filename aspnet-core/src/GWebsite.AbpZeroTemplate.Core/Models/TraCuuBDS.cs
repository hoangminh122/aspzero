namespace GWebsite.AbpZeroTemplate.Core.Models
{

    public class TraCuuBDS:FullAuditModel
    {
        public string maTaiSan { get; set; }
        public string maBDS { get; set; }
        public string  maDiaDiem { get; set; }
        public string maLoaiBDS { get; set; }
        public string tenDiaDiem { get; set; }
        public bool trangThai { get; set; }

    }
}
