using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.OzelKodlar.Abstract;
using SincomYazilim.WebOnMuhasebe.OzelKodlar.Concrete;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.OzelKodlar;//69
public class EfCoreOzelKodRepositorySin : EfCoreCommonRepositorySin<OzelKod>, IOzelKodRepositorySin
{
    public EfCoreOzelKodRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
