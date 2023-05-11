using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.BankaSubeler;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.Depolar.Abstract;
using SincomYazilim.WebOnMuhasebe.Depolar.Concrete;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Depolar;//69
public class EfCoreDepoRepositorySin : EfCoreCommonRepositorySin<Depo>, IDepoRepositorySin
{
    public EfCoreDepoRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
