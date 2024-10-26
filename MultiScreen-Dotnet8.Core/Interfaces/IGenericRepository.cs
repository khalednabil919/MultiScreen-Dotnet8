using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.Core.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        string? GetSchema();
        string? GetTableName();
        string? GetPrimaryKeyColmunName();
        DbSet<TEntity> DbSet();
        IQueryable<TEntity> Query();
        void SetContextState(TEntity entity, EntityState state);

        TEntity Add(TEntity entity);
        IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities);

        TEntity Update(TEntity entity);
        IEnumerable<TEntity> UpdateRange(IEnumerable<TEntity> entities);

        void Delete(object id);
        void DeleteRange(IEnumerable<object> ids);

        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

        void Attach(TEntity entity);
        void AttachRange(IEnumerable<TEntity> entities);



        //ASync
        Task<TEntity> AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);
    }

}
