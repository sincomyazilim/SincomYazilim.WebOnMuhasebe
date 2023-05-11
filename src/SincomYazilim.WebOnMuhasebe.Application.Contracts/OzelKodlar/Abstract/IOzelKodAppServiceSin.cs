using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.OzelKodlar.Abstract;//101
public interface IOzelKodAppServiceSin : ICrudAppServiceSin<SelectOzelKodDtoSin,ListOzelKodDtoSin,OzelKodListParameterDtoSin,CreateOzelKodDtoSin,UpdateOzelKodDtoSin,OzelKodCodeParameterDtoSin>
{
}
