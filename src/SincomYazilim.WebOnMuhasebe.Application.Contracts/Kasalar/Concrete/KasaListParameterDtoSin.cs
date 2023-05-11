using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Kasalar.Concrete;//80
public class KasaListParameterDtoSin : PagedResultRequestDto, IDurumSin, IEntityDto
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}
