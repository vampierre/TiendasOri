using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Tienda.Pe.Datos.IRepositorio.Generico
{
    public interface IRepository<T> where T : class//, IDisposable
    {
        List<T> Listar();
        List<T> Listar(Expression<Func<T, bool>> Predicado);
        T Obtener(int id);
        T Insertar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(T entidad);
        void EliminarLogico(int id);
        void Save();
    }
}
