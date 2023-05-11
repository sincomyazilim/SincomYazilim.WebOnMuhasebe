using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Depolar.Concrete;//76
public class DepoListParameterDtoSin : PagedResultRequestDto, IDurumSin, IEntityDto
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}
