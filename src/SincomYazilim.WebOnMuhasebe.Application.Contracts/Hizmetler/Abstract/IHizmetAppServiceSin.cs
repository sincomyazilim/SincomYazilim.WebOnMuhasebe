using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Concrete;
using SincomYazilim.WebOnMuhasebe.Hizmetler.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.Hizmetler.Abstract;//97
public interface IHizmetAppServiceSin: ICrudAppServiceSin<SelectHizmetDtoSin,ListHizmetDtoSin,HizmetListParameterDtoSin,CreateHizmetDtoSin,UpdateHizmetDtoSin,CodParameterDtoSin>
{
}
