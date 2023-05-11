using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace SincomYazilim.WebOnMuhasebe.BankaHesaplar.Concrete;//71
public class BankaHesapCodeParameterDtoSin : IEntityDto, IDurumSin
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}
