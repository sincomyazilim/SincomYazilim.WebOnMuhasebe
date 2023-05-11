using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.BankaSubeler;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.Donemler.Abstract;
using SincomYazilim.WebOnMuhasebe.Donemler.Concrete;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Donemler;//69
public class EfCoreDonemRepositorySin : EfCoreCommonRepositorySin<Donem>, IDonemRepositorySin
{
    public EfCoreDonemRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
