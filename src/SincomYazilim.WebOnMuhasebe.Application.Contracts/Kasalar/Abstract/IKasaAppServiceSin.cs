using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.Kasalar.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.Kasalar.Abstract;//98
public interface IKasaAppServiceSin : ICrudAppServiceSin<SelectKasaDtoSin,ListKasaDtoSin,KasaListParameterDtoSin,CreateKasaDtoSin,UpdateKasaDtoSin,KasaCodeParameterDtoSin>
{
}
