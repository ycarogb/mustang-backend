using Mustang_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang_Back.Services
{
    public interface IPedidoService
    {
        List<Pedido> GetAll();
        bool Delete(int? id);
        bool Create(Pedido p);
        Produto Get(int? id);
        bool Update(Pedido m);

        List<Pedido> PedidoByUserRole(string role);

    }
}
