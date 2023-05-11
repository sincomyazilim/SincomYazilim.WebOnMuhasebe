using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.Makbuzlar.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.Makbuzlar.Abstract;//99
public interface IMakbuzAppServiceSin : ICrudAppServiceSin<SelectMakbuzDtoSin,ListMakbuzDtoSin,MakbuzLisParameterDtoSin,CreateMakbuzDtoSin,UpdateMakbuzDtoSin,MakbuzNoParameterDtoSin>
{
}
