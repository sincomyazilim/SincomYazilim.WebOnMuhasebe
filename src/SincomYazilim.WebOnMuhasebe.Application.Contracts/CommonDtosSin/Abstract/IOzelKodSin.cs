using System;
using System.Collections.Generic;
using System.Text;

namespace SincomYazilim.WebOnMuhasebe.CommonDtosSin.Abstract;//71
public interface IOzelKodSin
{
    public Guid? OzelKod1Id { get; set; }
    public string OzelKod1Adi { get; set; }

    public Guid? OzelKod2Id { get; set; }
    public string OzelKod2Adi { get; set; }
}
