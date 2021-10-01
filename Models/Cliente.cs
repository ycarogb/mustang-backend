using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang_Back.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public int Cpf { get; set; }
        public string Nome { get; set; }

        public DateTime? created { get; set; }
        public DateTime? updated { get; set; }
        public string updatedById { get; set; }
        public IdentityUser updatedBy { get; set; }
        public string createdById { get; set; }
        public IdentityUser createdBy { get; set; }
    }
}
