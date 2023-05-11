using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.Stoklar.Abstract;
using SincomYazilim.WebOnMuhasebe.Stoklar.Concrete;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Stoklar;//69
public class EfCoreStokRepositorySin : EfCoreCommonRepositorySin<Stok>, IStokRepositorySin
{
    public EfCoreStokRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
