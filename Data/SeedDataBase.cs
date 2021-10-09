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
                        Tipo = "Carro",
                        Preco = 319.04,
                        Descricao = "Pneu Aro 13 CS1 185/70R13 86T",
                        ImgUrl = "https://static.pneustore.com.br/medias/sys_master/images/images/h4c/h6a/8859171291166/pneu-cooper-aro-13-cs1-175-70r13-82t-2.jpg"
                    });

                    context.Produto.Add(new Models.Produto
                    {
                        Marca = "Farroad",
                        Tipo = "Carro",
                        Preco = 550.44,
                        Descricao = "Pneu ARO 16 FRD16 215/65R16 98H",
                        ImgUrl = "https://static.pneustore.com.br/medias/sys_master/images/images/h38/h59/8859175288862/pneu-farroad-aro-16-frd16-215-65r16-98h-1.jpg"
                    });
                }
                context.SaveChanges();


            }

        }
    }
}
