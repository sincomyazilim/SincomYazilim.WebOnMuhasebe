using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Concrete;
using SincomYazilim.WebOnMuhasebe.Masraflar.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.Masraflar.Abstract;//100
public interface IMasrafAppServiceSin : ICrudAppServiceSin<SelectMasrafDtoSin,ListMasrafDtoSin,MasrafListParameterDtoSin,CreateMasrafDtoSin,UpdateMasrafDtoSin,CodParameterDtoSin>
{
}
