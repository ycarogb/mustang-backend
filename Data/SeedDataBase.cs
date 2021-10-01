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
                        Tipo = "Aro 13 CS1 185/70R13 86T",
                        Preco = 319.04,
                        Descricao = "Custo Benedício",
                        ImgUrl = "https://static.pneustore.com.br/medias/sys_master/images/images/h4c/h6a/8859171291166/pneu-cooper-aro-13-cs1-175-70r13-82t-2.jpg"
                    });
                }
                context.SaveChanges();


            }

        }
    }
}
