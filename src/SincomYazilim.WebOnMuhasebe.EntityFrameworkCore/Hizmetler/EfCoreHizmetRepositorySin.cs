using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.Hizmetler.Abstract;
using SincomYazilim.WebOnMuhasebe.Hizmetler.Concrete;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Hizmetler;//69
public class EfCoreHizmetRepositorySin : EfCoreCommonRepositorySin<Hizmet>, IHizmetRepositorySin
{
    public EfCoreHizmetRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
