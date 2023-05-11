using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Concrete;
using SincomYazilim.WebOnMuhasebe.Donemler.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.Donemler.Abstract;//95
public interface IDonemAppServiceSin: ICrudAppServiceSin<SelectDonemDtoSin,ListDonemDtoSin,DonemListParameterDtoSin,CreateDonemDtoSin,UpdateDonemDtoSin,CodParameterDtoSin>
{
}
