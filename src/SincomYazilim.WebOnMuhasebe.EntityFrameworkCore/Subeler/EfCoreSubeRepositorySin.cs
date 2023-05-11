using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.Subeler.Abstract;
using SincomYazilim.WebOnMuhasebe.Subeler.Concrete;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Subeler;//69
public class EfCoreSubeRepositorySin : EfCoreCommonRepositorySin<Sube>, ISubeRepositorySin
{
    public EfCoreSubeRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
