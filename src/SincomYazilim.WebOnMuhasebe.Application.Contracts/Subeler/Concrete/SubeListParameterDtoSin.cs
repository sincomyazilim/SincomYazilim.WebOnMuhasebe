using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Subeler.Concrete;//86
public class SubeListParameterDtoSin : PagedResultRequestDto, IDurumSin, IEntityDto
{
    public bool Durum { get; set; }
}
