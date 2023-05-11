using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.Parametreler.Abstract;
using SincomYazilim.WebOnMuhasebe.Parametreler.Concrete;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Parametreler;//69
public class EfCoreFirmaParametreRepositorySin : EfCoreCommonRepositorySin<FirmaParemetre>, IFirmaParemetreRepositorySin
{
    public EfCoreFirmaParametreRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
