using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Editorial.Infraestructure.Contexts
{
    public interface IRepository<T> where T : class // <= Le dice al compilador que T debe ser de tipo class
    {

        /// <summary>
        /// Retorna la entidad asociada al ID proveído por el usuario
        /// </summary>
        /// <param name="id">Id de la entidad proveído por el usuario</param>
        /// <returns>Una entiendad de tipo <seealso cref="T"/></returns>

        T Get(object id); //Recibe un object id entonces se busca por id
        T Get(Expression<Func<T, bool>> predicate); //Esto es para poder hacer una comparación por medio del predicado que devuelve true or false
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null, //Este lista todos los elementos que cumplan con el predicado
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
        void Insert(T entity); //Inserta un elemento
        void Update(T entity); //Actualiza un elemento

        void Delete(T entity); //Elimina un elemento
        void Delete(object id); //Elimina un elemento

    }
}
