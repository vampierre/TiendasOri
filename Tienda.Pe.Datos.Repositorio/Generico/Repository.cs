using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tienda.Pe.Datos.IRepositorio.Generico;
using Tienda.Pe.Datos.Modelo.Context;

namespace Tienda.Pe.Datos.Repositorio.Generico
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private TiendaContext context = null;
        protected DbSet<T> entidad = null;
        public Repository(TiendaContext context)
        {
            this.context = context;
            entidad = context.Set<T>();
        }
        public virtual List<T> Listar()
        {
            var respuesta = context.Set<T>().ToList();
            return respuesta;
        }
        public virtual List<T> Listar(Expression<Func<T, bool>> Predicado)
        {
            var respuesta = context.Set<T>().Where(Predicado).ToList();
            return respuesta;
        }
        public virtual T Obtener(int id)
        {
            var respuesta = context.Set<T>().Find(id);
            return respuesta;
        }

        public virtual T Insertar(T entidad)
        {
            var entidadNueva = context.Set<T>().Add(entidad);
            return entidadNueva;
        }

        public virtual void Actualizar(T entidad)
        {
            context.Entry(entidad).State = EntityState.Modified;
        }
        public virtual void Eliminar(T entidad)
        {
            context.Set<T>().Remove(entidad);
        }
        public virtual void EliminarLogico(int id)
        {
            context.Entry(entidad).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
