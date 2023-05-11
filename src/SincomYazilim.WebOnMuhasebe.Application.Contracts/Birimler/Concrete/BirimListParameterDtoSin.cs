using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Birimler.Concrete;//74
public class BirimListParameterDtoSin : PagedResultRequestDto, IDurumSin, IEntityDto
{
    public bool Durum { get; set; }
}
