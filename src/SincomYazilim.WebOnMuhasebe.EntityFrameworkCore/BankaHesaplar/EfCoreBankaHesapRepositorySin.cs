using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.BankaHesaplar.Abstract;
using SincomYazilim.WebOnMuhasebe.BankaHesaplar.Concrete;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.BankaHesaplar;//69
public class EfCoreBankaHesapRepositorySin : EfCoreCommonRepositorySin<BankaHesap>, IBankaHesapRepositorySin
{
    public EfCoreBankaHesapRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
