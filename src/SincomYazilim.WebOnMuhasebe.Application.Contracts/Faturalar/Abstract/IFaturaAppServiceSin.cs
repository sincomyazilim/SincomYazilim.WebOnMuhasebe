using System;
using System.Collections.Generic;
using System.Text;
using SincomYazilim.WebOnMuhasebe.Faturalar.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.Faturalar.Abstract;//96
public  interface IFaturaAppServiceSin: ICrudAppServiceSin<SelectFaturaDtoSin,ListFaturaDtoSin,FaturaListParameterDtoSin,CreateFaturaDtoSin,UpdateFaturaDtoSin,FaturaNoParameterDtoSin>
{
}
