using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.Masraflar.Abstract;
using SincomYazilim.WebOnMuhasebe.Masraflar.Concrete;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Masraflar;//69
public class EfCoreMasrafRepositorySin : EfCoreCommonRepositorySin<Masraf>, IMasrafRepositorySin
{
    public EfCoreMasrafRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
