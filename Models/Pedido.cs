using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang_Back.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public string Cliente { get; set; }
        public DateTime Data { get; set; }
        public int Qtd { get; set; }
        public double VlrFinal { get; set; }

        public DateTime? created { get; set; }
        public DateTime? updated { get; set; }
        public string updatedById { get; set; }
        public IdentityUser updatedBy { get; set; }
        public string createdById { get; set; }
        public IdentityUser createdBy { get; set; }



    }
}
