using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;//88
public interface ICrudAppServiceSin<TGetOutPutDto, TGetListOutputDto, in TGetListInput, in TCreateInput, in TUpdateInput> :
  IReadOnlyAppService<TGetOutPutDto, TGetListOutputDto, Guid, TGetListInput>,
  ICreateAppService<TGetOutPutDto, TCreateInput>,
  IUpdateAppService<TGetOutPutDto, Guid, TUpdateInput>
{

}
public interface ICrudAppServiceSin<TGetOutPutDto, TGetListOutputDto, in TGetListInput, in TCreateInput, in TUpdateInput, in TGetCodeInput> :
   ICrudAppServiceSin<TGetOutPutDto, TGetListOutputDto, TGetListInput, TCreateInput, TUpdateInput>,
   IDeleteAppService<Guid>,
   ICodeAppServiceSin<TGetCodeInput>
{

}