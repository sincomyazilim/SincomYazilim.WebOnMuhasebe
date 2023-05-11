using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.Parametreler.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.Parametreler.Abstract;//102
public interface IFirmaParametreAppServiceSin : ICrudAppServiceSin<SelectFirmaParametreDtoSin, SelectFirmaParametreDtoSin, FirmaParametreListParemeterDtoSin,CreateFirmaParametreDtoSin,UpdateFirmaParametreDtoSin>
{
}
