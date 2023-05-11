using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Faturalar.Concrete;//78
public class FaturaListParameterDtoSin : PagedResultRequestDto, IDurumSin, IEntityDto
{
    public FaturaTuru? FaturaTuru { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }

    public bool Durum { get; set; }
}
