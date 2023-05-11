using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.MakbuzHareketler.Abstract;
using SincomYazilim.WebOnMuhasebe.MakbuzHareketler.Concrete;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.MakbuzHareketler;//69
public class EfCoreMakbuzHaraketRepositorySin : EfCoreCommonRepositorySin<MakbuzHareket>, IMakbuzHareketRepositorySin
{
    public EfCoreMakbuzHaraketRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
