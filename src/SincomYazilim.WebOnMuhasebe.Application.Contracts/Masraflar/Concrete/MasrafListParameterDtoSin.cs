using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Masraflar.Concrete;//82
public class MasrafListParameterDtoSin : PagedResultRequestDto, IDurumSin, IEntityDto
{

    public bool Durum { get; set; }
}
