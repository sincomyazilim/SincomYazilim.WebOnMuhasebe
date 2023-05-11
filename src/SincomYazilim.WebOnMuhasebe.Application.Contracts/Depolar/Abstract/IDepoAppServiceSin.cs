using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.Depolar.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.Depolar.Abstract;//94
public interface IDepoAppServiceSin: ICrudAppServiceSin<SelectDepoDtoSin,ListDepoDtoSin,DepoListParameterDtoSin,CreateDepoDtoSin,UpdateDepoDtoSin,DepoCodeParameterDtoSin>
{
}
