using Mustang_Back.Data;
using Mustang_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang_Back.Services
{
    public class PedidoService
    {
        MustangBackContext _context;

        public PedidoService(MustangBackContext context)
        {
            _context = context;
        }

        public List<Pedido> GetAll()
        {
            return _context.Pedido.ToList();
        }

        public bool Create(Pedido p)
        {
            try
            {
                p.created = DateTime.Now;
                _context.Add(p);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Pedido Get(int? id)
        {
            return _context.Pedido.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(Pedido Pedido)
        {
            try
            {
                if (!_context.Pedido.Any(m => m.Id == Pedido.Id)) throw new Exception("Pedido não Existe");

                Pedido.updated = DateTime.Now;
                _context.Update(Pedido);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int? Id)
        {
            try
            {
                _context.Remove(this.Get(Id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
