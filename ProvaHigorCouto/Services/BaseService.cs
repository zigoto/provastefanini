using System.Collections.Generic;
using System.Linq;
using ProvaHigorCouto.Models;
using Microsoft.EntityFrameworkCore;

namespace ProvaHigorCouto.Services
{
    public class BaseService<T> where T : class
    {
        protected ProvaHigorCoutoContext db;

        public BaseService(ProvaHigorCoutoContext db)
        {
            this.db = db;
            Entity = db.Set<T>();
        }

        protected DbSet<T> Entity { get; private set; }

        public T adicionar(T entity)
        {
            Entity.Add(entity);
            return entity;
        }

        public T alterar(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return entity;
        }
        public void excluir(object id)
        {
            var objEntity = Entity.Find(id);
            if (objEntity != null)
            {
                Entity.Remove(objEntity);
            }
        }

        public T selecionar(params object[] keys)
        {
            return Entity.Find(keys);
        }

        public IEnumerable<T> listar()
        {
            return Entity.ToList();
        }
    }
}