using SincomYazilim.WebOnMuhasebe.Bankalar.Concrete;
using SincomYazilim.WebOnMuhasebe.CommonDtosSin.Concrete;
using SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;

namespace SincomYazilim.WebOnMuhasebe.Bankalar.Abstract;//90
public interface IBankaAppServiceSin: ICrudAppServiceSin<SelectBankaDtoSin,ListBankaDtoSin,BankaListParameterSin,CreateBankaDtoSin,UpdateBankaDtoSin, CodParameterDtoSin>
{
}
