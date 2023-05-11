using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SincomYazilim.WebOnMuhasebe.Commons;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.Faturalar.Abstract;
using SincomYazilim.WebOnMuhasebe.Faturalar.Concrete;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Faturalar;//69
public class EfCoreFaturaRepositorySin : EfCoreCommonRepositorySin<Fatura>,IFaturaRepositorySin
{
    public EfCoreFaturaRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
