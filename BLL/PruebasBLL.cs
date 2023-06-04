using Microsoft.EntityFrameworkCore;
using Practicas1.DAL;
using Practicas1.Models;
using System.Linq.Expressions;

namespace Practicas1.BLL
{
    public class PruebasBLL
    {
        private readonly Context _context;

        public PruebasBLL(Context context)
        {
            _context = context;
        }

        public bool Existe(int prueba)
        {
            return _context.Pruebas.Any(s => s.PruebaId == prueba);
        }

        public bool Insertar(Pruebas prueba)
        {
            _context.Pruebas.Add(prueba);
            int cantidad = _context.SaveChanges();
            return cantidad > 0;
        }

        public bool Modificar(Pruebas prueba)
        {
            _context.Update(prueba);
            int cantidad = _context.SaveChanges();
            return cantidad > 0;
        }

        public bool Guardar(Pruebas prueba)
        {
            if (!Existe(prueba.PruebaId))
                return Insertar(prueba);
            else
                return Modificar(prueba);
        }

        public bool Eliminar(Pruebas prueba)
        {
            _context.Pruebas.Remove(prueba);
            int cantidad = _context.SaveChanges();
            return cantidad > 0;
        }

        public Pruebas? Buscar(int pruebaId)
        {
            return _context.Pruebas
                .AsNoTracking()
                .FirstOrDefault(s => s.PruebaId == pruebaId);
        }

        public List<Pruebas> GetList(Expression<Func<Pruebas, bool>> Criterio)
        {
            return _context.Pruebas
                .Where(Criterio)
                .AsNoTracking()
                .ToList();
        }
    }
}
