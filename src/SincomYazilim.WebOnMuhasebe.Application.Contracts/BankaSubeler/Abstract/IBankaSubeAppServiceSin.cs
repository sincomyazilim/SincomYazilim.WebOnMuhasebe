using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.BankaSubeler.Concrete;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.BankaSubeler.Abstract;//91
public interface IBankaSubeAppServiceSin: ICrudAppServiceSin<SelectBankaSubeDtoSin,ListBankaSubeDtoSin,BankaSubeListParameterDtoSin,CreateBankaSubeDtoSin,UpdateBankaSubeDtoSin,BankaSubeCodeParameterDtoSin>
{
}
