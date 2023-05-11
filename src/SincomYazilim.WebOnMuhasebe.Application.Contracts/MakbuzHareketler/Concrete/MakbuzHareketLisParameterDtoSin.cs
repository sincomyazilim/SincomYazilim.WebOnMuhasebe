using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using SincomYazilim.WebOnMuhasebe.Makbuzlar;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.MakbuzHareketler.Concrete;//81
public class MakbuzHareketLisParameterDtoSin : PagedResultRequestDto,   IDurumSin, IEntityDto
{
    public Guid EntityId { get; set; }
    public OdemeTuru OdemeTuru { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}
