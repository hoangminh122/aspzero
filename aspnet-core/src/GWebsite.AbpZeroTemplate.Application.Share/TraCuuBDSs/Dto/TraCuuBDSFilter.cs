using GSoft.AbpZeroTemplate.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;
using System;

namespace GWebsite.AbpZeroTemplate.Application.Share.TraCuuBDSs.Dto
{
    /// <summary>
    /// <model cref="TraCuuBDS"></model>
    /// </summary>
    public class TraCuuBDSFilter : PagedAndSortedInputDto
    {
        public string maBDS { get; set; }
    }
}
