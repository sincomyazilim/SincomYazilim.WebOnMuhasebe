using System.Linq.Expressions;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace SincomYazilim.WebOnMuhasebe.Commons.Abstract;//66
public interface ICommonRepositorySin<TEntity> : IRepository<TEntity, Guid> where TEntity : class, IEntity<Guid>//IRepository burda ıkı arguman alıyor hem enttıy hemde ıcındekı Id nın ne tur oldugunu..bız butun entıtlerede Id guid olusturduk
{

    //**************************************************************************************
    //kayıtları istedıgımız ıd ve istedıgımız sayı ve fıltre ıle ve lıskıı tabloları varsa getırıır
    Task<TEntity> GetAsyncSin(object id,
        Expression<Func<TEntity, bool>> predicate = null,
        params Expression<Func<TEntity, object>>[] includeProperties);
    //**************************************************************************************
    //kayıtları  istedıgımız sayı ve fıltre ıle ve lıskıı tabloları varsa getırıır
    Task<TEntity> GetAsyncSin(
        Expression<Func<TEntity, bool>> predicate = null,
        params Expression<Func<TEntity, object>>[] includeProperties);

    //**************************************************************************************    
    //kayıtları istedıgımız ıd ve istedıgımız sayı ve fıltre ıle  getırıır
    Task<TEntity> GetAsyncSin(object id,
        Expression<Func<TEntity, bool>> predicate = null);

    //**************************************************************************************    
    //kayıtları ıstedıgımız sayıda ve ıstedgımız kayıt sayısıkadar ve ıstedıgımız sırada ve ılıskıı tabloları varsa getırıır
    Task<List<TEntity>> GetPagedListAsyncSin<TKey>(int skipCount, int maxResultCount,
        Expression<Func<TEntity, bool>> predicate = null,
        Expression<Func<TEntity, TKey>> orderBy = null,
        params Expression<Func<TEntity, object>>[] includeProprties);
    //**************************************************************************************
    //kayıtları ıstedıgımız sayıda ıstedıgımız sırada  getırıır
    Task<List<TEntity>> GetPagedListAsyncSin<TKey>(int skipCount, int maxResultCount,
        Expression<Func<TEntity, bool>> predicate = null,
        Expression<Func<TEntity, TKey>> orderBy = null);
    //**************************************************************************************
    //kayıtları testen ve ıstedıgımız sayıda ve ıstedgımız kayıt sayısı kadar, ve ıstedıgımız sırada ve ılıskıı tabloları varsa getırıır
    Task<List<TEntity>> GetPagedLastListAsynSin<TKey>(int skipCount, int maxResultCount,
        Expression<Func<TEntity, bool>> predicate = null,
        Expression<Func<TEntity, TKey>> orderBy = null,
        params Expression<Func<TEntity, object>>[] includeProperties);
    //**************************************************************************************
    //elle gırılme olmasın dıye otomatık kod ekleme yerıdır
    Task<string> GetCodeAsyncSin(Expression<Func<TEntity, string>> propertySelector, Expression<Func<TEntity, bool>> predicate = null);
    //**************************************************************************************
    //sqlserver da stor procudere den verı cekmek ıcın bunu yazıyoruz,raporarma kısmında kullanılacak
    Task<List<TEntity>> FromsqlRawAsyncSin(string sql, params object[] parameters);
    //**************************************************************************************
    Task<bool> AnyAsyncSin(Expression<Func<TEntity, bool>> predicate = null);
    //**************************************************************************************

}
