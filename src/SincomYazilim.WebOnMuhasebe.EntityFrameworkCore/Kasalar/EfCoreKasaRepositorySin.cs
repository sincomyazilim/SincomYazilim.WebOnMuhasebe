using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.Kasalar.Abstract;
using SincomYazilim.WebOnMuhasebe.Kasalar.Concrete;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Kasalar;
public class EfCoreKasaRepositorySin : EfCoreCommonRepositorySin<Kasa>, IKasaRepositorySin
{
    public EfCoreKasaRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
