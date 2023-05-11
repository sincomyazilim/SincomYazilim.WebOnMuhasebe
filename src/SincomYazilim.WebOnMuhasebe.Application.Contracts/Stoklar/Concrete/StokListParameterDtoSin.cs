using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Stoklar.Concrete;//85
public class StokListParameterDtoSin : PagedResultRequestDto, IDurumSin, IEntityDto
{
    public bool Durum { get; set; }
}
