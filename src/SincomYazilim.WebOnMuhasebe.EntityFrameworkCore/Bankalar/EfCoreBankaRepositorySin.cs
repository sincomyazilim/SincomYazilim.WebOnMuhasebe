using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.Bankalar.Abstract;
using SincomYazilim.WebOnMuhasebe.Bankalar.Concrete;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Bankalar;
public class EfCoreBankaRepositorySin : EfCoreCommonRepositorySin<Banka>, IBankaRepositorySin
{//69
    public EfCoreBankaRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
