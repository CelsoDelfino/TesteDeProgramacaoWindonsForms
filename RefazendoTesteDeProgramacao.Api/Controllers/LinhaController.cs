using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RefazendoTesteDeProgramacao.Api.Resource;
using RefazendoTesteDeProgramacao.Application;

namespace RefazendoTesteDeProgramacao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinhaController : ControllerBase
    {
        private readonly LinhaApplication application;
        public LinhaController(LinhaApplication application)
        {
            this.application = application; 
        }

        [HttpPost]
        public void Post(List<LinhaResource> linhaResources)
        {
            var domain = LinhaResource.ConverteListaEntidade(linhaResources);

            foreach(var linha in domain)
            {
                linha.CalculaDezPorCento();
            }
            application.Post(domain);
        }



    }
}
