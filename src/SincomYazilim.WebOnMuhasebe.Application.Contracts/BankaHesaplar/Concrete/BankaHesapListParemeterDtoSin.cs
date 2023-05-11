using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.BankaHesaplar.Concrete;//71
public class BankaHesapListParemeterDtoSin : PagedResultRequestDto, IEntityDto, IDurumSin
{
    public BankaHesapTuru? hesapTuru { get; set; }
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}
