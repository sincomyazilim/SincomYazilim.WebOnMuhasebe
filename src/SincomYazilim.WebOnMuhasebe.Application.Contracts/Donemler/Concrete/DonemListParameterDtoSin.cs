using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Donemler.Concrete;//77
public class DonemListParameterDtoSin : PagedResultRequestDto, IDurumSin, IEntityDto
{
    public bool Durum { get; set; }
}
