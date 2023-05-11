using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.Cariler.Concrete;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.Cariler.Abstract;
internal interface ICariAppServiceSin: ICrudAppServiceSin<SelectCariDtoSin,ListCariDtoSin,CariListParameterDtoSin,CreateCariDtoSin,UpdateCariDtoSin, CodParameterDtoSin>
{
}
