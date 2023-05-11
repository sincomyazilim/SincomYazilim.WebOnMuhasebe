using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.Makbuzlar.Abstract;
using SincomYazilim.WebOnMuhasebe.Makbuzlar.Concrete;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Makbuzlar;//69
public class EfCoreMakbuzRepositorySin : EfCoreCommonRepositorySin<Makbuz>, IMakbuzRepositorySin
{
    public EfCoreMakbuzRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
