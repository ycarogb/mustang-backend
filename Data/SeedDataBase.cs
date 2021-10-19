using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang_Back.Data
{
    public class SeedDataBase
    {
        public static void Initialize(IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<MustangBackContext>();
                context.Database.Migrate();

                if (!context.Produto.Any())
                {
                    context.Produto.Add(new Models.Produto
                    {
                        Marca = "CooperTires",
                        Tipo = "Pneu Aro 13 CS1 185/70R13 86T",
                        Preco = 319.04,
                        Descricao = "Melhor custo benefício",
                        ImgUrl = "https://static.pneustore.com.br/medias/sys_master/images/images/h4c/h6a/8859171291166/pneu-cooper-aro-13-cs1-175-70r13-82t-2.jpg",
                        Quantidade = 4
                    });

                    context.Produto.Add(new Models.Produto
                    {
                        Marca = "Farroad",
                        Tipo = "Pneu ARO 16 FRD16 215/65R16 98H",
                        Preco = 267.99,
                        Descricao = "Maior durabilidade",
                        ImgUrl = "https://static.pneustore.com.br/medias/sys_master/images/images/h0c/hb6/8909586071582/pneu-iris-aro-13-ecoris-165-70r13-79t-1.jpg",
                        Quantidade = 3
                        
                    });
                    
                    context.Produto.Add(new Models.Produto
                    {
                        Marca = "iris",
                        Tipo = "PNEU ARO 13 ECORIS 165/70R13 79T",
                        Preco = 550.44,
                        Descricao = "Maior durabilidade",
                        ImgUrl = "https://static.pneustore.com.br/medias/sys_master/images/images/h38/h59/8859175288862/pneu-farroad-aro-16-frd16-215-65r16-98h-1.jpg",
                        Quantidade = 2

                    });
                    
                    context.Produto.Add(new Models.Produto
                    {
                        Marca = "KELLY BY GOODYEAR",
                        Tipo = "PNEU  ARO 13 KELLY EDGE TOURING 165/70R13 83T XL",
                        Preco = 297.90,
                        Descricao = "Maior custo benefício",
                        ImgUrl = "https://static.pneustore.com.br/medias/sys_master/images/images/h8e/h69/8859692171294/pneu-goodyear-aro-13-kelly-edge-touring-165-70r13-83t-xl-1.jpg"
                        Quantidade = 1
                    });
                }
                context.SaveChanges();


            }

        }
    }
}
