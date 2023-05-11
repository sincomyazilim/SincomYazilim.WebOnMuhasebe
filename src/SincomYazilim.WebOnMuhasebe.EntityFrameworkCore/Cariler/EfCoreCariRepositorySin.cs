using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.BankaSubeler;
using SincomYazilim.WebOnMuhasebe.Cariler.Abstract;
using SincomYazilim.WebOnMuhasebe.Cariler.Concrete;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Cariler;//69
public class EfCoreCariRepositorySin : EfCoreCommonRepositorySin<Cari>, ICariRepositorySin
{
    public EfCoreCariRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
