using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mustang_Back.API;
using Mustang_Back.Models;
using Mustang_Back.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Mustang_Back.Controllers.v1
{
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiController]
    [Route("[Controller]")]
    public class ProdutoController : ApiBaseController
    {
        IProdutoService _service;

        public ProdutoController(IProdutoService service)//, ILogger<ProdutoController> logger)
        {
            _service = service;
            //_logger = logger;
        }

        /// <summary>
        /// Retorna uma lista de todos os produtos existentes no banco de dados.
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public IActionResult Index() =>
            ApiOk(_service.GetAll());


        /// <summary>
        /// Retorna um produto específico de acordo com o id informado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("{id}")]
        [HttpGet]
        public IActionResult Index(int? id)
        {
            Produto exists = _service.Get(id);
            //_logger.LogInformation("Este é um exemplo de LogInformation. :)");
            //_logger.LogWarning($"O usuario {User.Identity.Name} pesquisou pelo produto {id}.");
            return exists == null ?
                ApiNotFound("Não foi encontrado o produto solicitado.") :
                ApiOk(exists);
        }


        [HttpPost]
        public IActionResult Create([FromBody] Produto Produto)
        {
            Produto.createdById = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            return _service.Create(Produto) ?
                ApiOk("Produto criado com sucesso!") :
                ApiNotFound("Erro ao criar Produto!");
        }

        /// <summary>
        /// "Atualiza um produto específico de acordo com os dados do body"
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] Produto Produto)
        {
            Produto.updatedById = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            return _service.Update(Produto) ?
                ApiOk("Produto atualizado com sucesso!") :
                ApiNotFound("Erro ao atualizar Produto!");
        }
        /// <summary>
        /// "Apaga um produto específico de acordo com o id informado"
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [AuthorizeRoles(RoleType.Admin)]
        [Route("{id}")]

        [HttpDelete]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
                ApiOk("Produto deletado com sucesso!") :
                ApiNotFound("Erro ao deletar Produto!");


    }
}
