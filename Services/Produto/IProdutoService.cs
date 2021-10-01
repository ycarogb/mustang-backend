using Mustang_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang_Back.Services
{
    public interface IProdutoService
    {
        List<Produto> GetAll();
        bool Delete(int? id);
        bool Create(Produto p);
        Produto Get(int? id);
        bool Update(Produto p);


       List<Produto> ProdutoByUserRole(string role);

    }
}
