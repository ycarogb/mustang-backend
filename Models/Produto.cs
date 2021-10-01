using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang_Back.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public  string ImgUrl { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }

        public DateTime? created { get; set; }
        public DateTime? updated { get; set; }
        public string updatedById { get; set; }
        public IdentityUser updatedBy { get; set; }
        public string createdById { get; set; }
        public IdentityUser createdBy { get; set; }
        public List<Pedido> Pedidos { get; set; }
        


    }
}
