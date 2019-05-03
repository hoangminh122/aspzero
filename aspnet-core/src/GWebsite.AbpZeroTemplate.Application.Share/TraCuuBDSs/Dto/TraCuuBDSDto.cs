using Abp.Domain.Entities;
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.TraCuuBDSs.Dto
{
    /// <summary>
    /// <model cref="TraCuuBDS"></model>
    /// </summary>
    public class TraCuuBDSDto : Entity<int>
    {
        public string maTaiSan { get; set; }
        public string maBDS { get; set; }
        public string maDiaDiem { get; set; }
        public string maLoaiBDS { get; set; }
        public string tenDiaDiem { get; set; }
        public bool trangThai { get; set; }
    }
}
