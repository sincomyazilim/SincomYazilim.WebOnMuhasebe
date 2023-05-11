using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.Commons.Abstract;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Commons;//68
public class EfCommonNoKeyRepositorySin<TEntity> : EfCoreRepository<WebOnMuhasebeDbContext, TEntity>,
    ICommonNoKeyRepositorySin<TEntity> where TEntity : class, IEntity
{
    public EfCommonNoKeyRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
    //-----------------------------------------------------------------------------------------------------
    public async Task<TEntity> FromSqlRawSingleAsync(string sql, params object[] parameters)
    {
        var dbSet=await GetDbSetAsync();
        return await dbSet.FromSqlRaw(sql, parameters).FirstOrDefaultAsync();
    }
    //**************************************************************************************************

    public async Task<IList<TEntity>> FromSqlRawAsync(string sql, params object[] parameters)
    {
        var dbSet=await GetDbSetAsync();
        return await DbSet.FromSqlRaw(sql, parameters).ToListAsync();
    }
    //************************************************************
}
