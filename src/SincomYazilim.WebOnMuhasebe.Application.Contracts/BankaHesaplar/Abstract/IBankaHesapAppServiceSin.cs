using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.BankaHesaplar.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.BankaHesaplar.Abstract;//89
public interface IBankaHesapAppServiceSin : ICrudAppServiceSin<
    SelectBankaHesapDtoSin,
    ListBankaHesapDtoSin,
    BankaHesapListParemeterDtoSin,
    CreateBankaHesapDtoSin,
    UpdatBankaHesapDtoSin,
    BankaHesapCodeParameterDtoSin>
{
}
