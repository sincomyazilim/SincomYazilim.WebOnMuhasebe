using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SincomYazilim.WebOnMuhasebe.Parametreler.Concrete;
public class SelectFirmaParametreDtoSin : EntityDto<Guid>
{

    public Guid SubeId { get; set; }
    public string SubeAdi { get; set; }
    public Guid DonemId { get; set; }
    public string DonemAdi { get; set; }
    public Guid DepoId { get; set; }
    public string DepoAdi { get; set; }
}
