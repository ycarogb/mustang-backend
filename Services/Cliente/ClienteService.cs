using Mustang_Back.Data;
using Mustang_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang_Back.Services
{
    public class ClienteService
    {
        MustangBackContext _context;

        public ClienteService(MustangBackContext context)
        {
            _context = context;
        }

        public List<Cliente> GetAll()
        {
            return _context.Cliente.ToList();
        }

        public bool Create(Cliente p)
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

        public Cliente Get(int? id)
        {
            return _context.Cliente.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Cliente Cliente)
        {
            try
            {
                if (!_context.Cliente.Any(c => c.Id == Cliente.Id)) throw new Exception("Cliente não Existe");

                Cliente.updated = DateTime.Now;
                _context.Update(Cliente);
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
