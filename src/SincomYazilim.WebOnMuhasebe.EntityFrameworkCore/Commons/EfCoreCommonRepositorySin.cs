using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SincomYazilim.WebOnMuhasebe.Commons.Abstract;
using SincomYazilim.WebOnMuhasebe.EntityFrameworkCore;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SincomYazilim.WebOnMuhasebe.Commons;//68 somut kısımlarını eklıyoruz 
public class EfCoreCommonRepositorySin<TEntity> : EfCoreRepository<WebOnMuhasebeDbContext, TEntity, Guid>,ICommonRepositorySin<TEntity> where TEntity : class, IEntity<Guid>
{
    public EfCoreCommonRepositorySin(IDbContextProvider<WebOnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
    //-----------------------------------------------------------------------
    public async Task<TEntity> GetAsyncSin(object id,
           Expression<Func<TEntity, bool>> predicate = null,
           params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var querable = await WithDetailsAsync(includeProperties);//veritaban gelırken ılıskı varsa onlarında özellıklerını dolu sekılde getır
        TEntity entity;

        if (predicate != null)
        {
            entity = await querable.FirstOrDefaultAsync(predicate);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(TEntity), id);
            }
            return entity;
        }
        entity = await querable.FirstOrDefaultAsync();
        if (entity == null)
            throw new EntityNotFoundException(typeof(TEntity), id);//id burda tabloda hata olursa bu Id kayıta hata lstu dıye eklenıyor
        return entity;

    }
    //*************************************************************************************
    public async Task<TEntity> GetAsyncSin(
        Expression<Func<TEntity, bool>> predicate = null,
        params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var queryable = await WithDetailsAsync(includeProperties);
        if (predicate != null)
        {
            return await queryable.FirstOrDefaultAsync(predicate);
        }
        return await queryable.FirstOrDefaultAsync();
    }
    //*************************************************************************************
    public async Task<TEntity> GetAsyncSin(object id,
        Expression<Func<TEntity, bool>> predicate = null)
    {
        var queryable = await WithDetailsAsync();
        TEntity entity;
        if (predicate != null)
        {
            entity = await queryable.FirstOrDefaultAsync(predicate);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(TEntity), id);
                return entity;
            }

        }
        entity = await queryable.FirstOrDefaultAsync();
        if (entity == null)
            throw new EntityNotFoundException(typeof(TEntity), id);
        return entity;
    }
    //*************************************************************************************

    public async Task<List<TEntity>> GetPagedListAsyncSin<TKey>(int skipCount, int maxResultCount,
        Expression<Func<TEntity, bool>> predicate = null,
        Expression<Func<TEntity, TKey>> orderBy = null,
        params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var queryable = await WithDetailsAsync(includeProperties);
        if (predicate != null)
            queryable = queryable.Where(predicate);
        if (orderBy != null)
            queryable = queryable.OrderBy(orderBy);

        return await queryable
            .Skip(skipCount)
            .Take(maxResultCount)
            .ToListAsync();


    }
    //*************************************************************************************
    public async Task<List<TEntity>> GetPagedListAsyncSin<TKey>(int skipCount, int maxResultCount,
        Expression<Func<TEntity, bool>> predicate = null,
        Expression<Func<TEntity, TKey>> orderBy = null)
    {
        var queryable = await WithDetailsAsync();
        if (predicate != null)
            queryable = queryable.Where(predicate);
        if (orderBy != null)
            queryable = queryable.OrderBy(orderBy);

        return await queryable
            .Skip(skipCount)
            .Take(maxResultCount)
            .ToListAsync();
    }
    //*************************************************************************************

    public async Task<List<TEntity>> GetPagedLastListAsynSin<TKey>(int skipCount, int maxResultCount,
        Expression<Func<TEntity, bool>> predicate = null,
        Expression<Func<TEntity, TKey>> orderBy = null,
        params Expression<Func<TEntity, object>>[] includeProprties)
    {
        var quaryable = await WithDetailsAsync(includeProprties);
        if (quaryable != null)
            quaryable = quaryable.Where(predicate);
        if (orderBy != null)
            quaryable = quaryable.OrderByDescending(orderBy);//tersten sırala
        return await quaryable
            .Skip(skipCount)
            .Take(maxResultCount)
            .ToListAsync();
    }
    //*************************************************************************************
    public async Task<string> GetCodeAsyncSin(Expression<Func<TEntity, string>> propertySelector, Expression<Func<TEntity, bool>> predicate = null)
    {//bu metot verıtabanda olan sayısal ve albateıck kodlu hücresel bilgiyi alıp bırinden ayırıp sayısal kısmı 1 arttırıp tekrar bırlestırmek

        static string CreateNewCoduSin(string code)
        {
            var number = "";
            foreach (var item in code)
            {
                if (char.IsDigit(item))
                {
                    number += item;
                }
                else
                {
                    number = "";
                }
            }
            var newNumber = number == "" ? "1" : (long.Parse(number) + 1).ToString();
            var difference = code.Length - newNumber.Length;
            if (difference < 0)
            {
                difference = 0;
            }
            var newCode = code.Substring(0, difference);
            newCode += number;
            return newCode;
        }

        var dbSet = await GetDbSetAsync();
        var maxCode = predicate == null
            ? await dbSet.MaxAsync(propertySelector)
            : await dbSet.Where(predicate).MaxAsync(propertySelector);
        return maxCode == null
            ? "0000000000000001"
            : CreateNewCoduSin(maxCode);

    }

    //*************************************************************************************
    public async Task<List<TEntity>> FromsqlRawAsyncSin(string sql, params object[] parameters)
    {
        var context = await GetDbContextAsync();
        return await context.Set<TEntity>().FromSqlRaw(sql, parameters).ToListAsync();

        //iki kullanımı mevcutru istedıgımız yolu denerız

        //var dbSet= await GetDbSetAsync();
        //return await DbSet.FromSqlRaw(sql, parameters).ToListAsync();
    }

    //*************************************************************************************

    public async Task<bool> AnyAsyncSin(Expression<Func<TEntity, bool>> predicate = null)
    {
        var dbSet = await GetDbSetAsync();
        return predicate == null
            ? await dbSet.AnyAsync()
            : await dbSet.AnyAsync(predicate);
    }
    //*************************************************************************************

}
