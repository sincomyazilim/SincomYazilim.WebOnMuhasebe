using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace SincomYazilim.WebOnMuhasebe.ServicesSin.Abstract;
public interface ICodeAppServiceSin<in TGetCodeInput> : IApplicationService
{
    Task<string> GetCodeAsync(TGetCodeInput input);
}
