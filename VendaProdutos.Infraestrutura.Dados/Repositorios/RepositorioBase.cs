
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VendaProdutos.Dominio.Interfaces.IRepositories;
using VendaProdutos.Infraestrutura.Dados.Contexto;

namespace VendaProdutos.Infraestrutura.Dados.Repositorios
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        //O nome dessa instancia é mais comum ser (DbContext)
        protected VendaProdutoContexto DbContext = new VendaProdutoContexto();

        public void Add(TEntity obj)
        {
            DbContext.Set<TEntity>().Add(obj);
            DbContext.SaveChanges();
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return DbContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            DbContext.Set<TEntity>().Remove(obj);
            DbContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            DbContext.Entry(obj).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}
