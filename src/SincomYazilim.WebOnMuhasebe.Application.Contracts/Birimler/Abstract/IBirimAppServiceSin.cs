using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.Birimler.Concrete;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.Birimler.Abstract;//92
public interface IBirimAppServiceSin: ICrudAppServiceSin<SelectBirimDtoSin, ListBirimDtoSin,BirimListParameterDtoSin,CreateBirimDtoSin,UpdateBirimDtoSin,CodParameterDtoSin>
{
}
