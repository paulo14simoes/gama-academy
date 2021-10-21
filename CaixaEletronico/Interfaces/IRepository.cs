using System.Collections.Generic;

namespace CaixaEletronico.Interfaces
{
    public interface IRepository<TEntity>
    {
        public void Add(TEntity entity);

        public List<TEntity> List();
    }
}