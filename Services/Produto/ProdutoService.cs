using Mustang_Back.Data;
using Mustang_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang_Back.Services
{
    public class ProdutoService : IProdutoService
    {
        MustangBackContext _context;

        public ProdutoService(MustangBackContext context) 
        {
            _context = context;
        }

        public List<Produto> GetAll()
        {
            return _context.Produto.ToList();
        }

        public bool Create(Produto p)
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

        public Produto Get(int? id)
        {
            return _context.Produto.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(Produto produto)
        {
            try
            {
                if (!_context.Produto.Any(m => m.Id == produto.Id)) throw new Exception("Produto não Existe");

                produto.updated = DateTime.Now;
                _context.Update(produto);
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

        public List<Produto> ProdutoByUserRole(string role)
        {
            throw new NotImplementedException();
        }
    }
    
}
