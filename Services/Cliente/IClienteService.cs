using Mustang_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang_Back.Services
{
    public interface IClienteService
    {
        List<Cliente> GetAll();
        bool Delete(int? id);
        bool Create(Cliente c);
        Cliente Get(int? id);
        bool Update(Cliente c);


        List<Cliente> CienteByUserRole(string role);

    }
}
