using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.FaturaHareketler.Abstract;
using SincomYazilim.WebOnMuhasebe.FaturaHareketler.Concrete;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.FaturaHareketler;//69
public class EfCoreFaturaHareketRepositorySin : EfCoreCommonRepositorySin<FaturaHareket>, IFaturaHaraketRepositorySin
{
    public EfCoreFaturaHareketRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
