using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Cariler.Concrete;//75
public class CariListParameterDtoSin : PagedResultRequestDto, IDurumSin, IEntityDto
{
    public bool Durum { get; set; }
}
