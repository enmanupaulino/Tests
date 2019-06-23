using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Test.DAL;

namespace Test.BLL
{
    public class RepositorioBase<T> :IDisposable, IRepositorio<T> where T : class
    {
        internal Contexto db;
        public RepositorioBase()
        {
            db = new Contexto();
        }
        public virtual bool Guardar (T entity)
        {
            bool paso = false;
            try
            {
                if (db.Set<T>().Add(entity) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public virtual bool Modificar (T entity)
        {
            bool paso = false;

            try
            {

                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;

            }
            return paso;
        }

        public T Buscar( int Id)
        {
            T entity;
            try
            {
                entity = db.Set<T>().Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }


        public List<T>GetList(Expression<Func<T, bool>> expression)
        {
            List<T> lista;
            try
            {
                lista = db.Set<T>().Where(expression).ToList();


            }
            catch (Exception)
            {
                throw;

            }
            return lista;
        }

        public bool Eliminar (int Id)
        {
            bool paso = false;
            T entity;
            try
            {
                entity = db.Set<T>().Find(Id);
                db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
