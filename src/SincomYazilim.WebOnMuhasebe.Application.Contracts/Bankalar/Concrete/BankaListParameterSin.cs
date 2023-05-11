using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Bankalar.Concrete;//72
public class BankaListParameterSin : PagedResultRequestDto, IEntityDto, IDurumSin
{
    public bool Durum { get; set; }
}
