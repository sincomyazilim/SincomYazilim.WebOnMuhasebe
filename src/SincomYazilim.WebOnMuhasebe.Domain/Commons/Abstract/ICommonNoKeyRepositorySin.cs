using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace SincomYazilim.WebOnMuhasebe.Commons.Abstract;//67 raporlar yapıırken ıd baglı olmayan ıcın kullanıyor
public interface ICommonNoKeyRepositorySin<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    Task<TEntity> FromSqlRawSingleAsync(string sql, params object[] parameters);
    Task<IList<TEntity>> FromSqlRawAsync(string sql, params object[] parameters);
}
