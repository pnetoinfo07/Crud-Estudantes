using Core.Entidades;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Data.SQLite;

namespace Api_Crud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudanteController : ControllerBase
    {
        private readonly EstudanteService service;

        public EstudanteController(IConfiguration config)
        {
            service = new EstudanteService(config);
        }
        [HttpPost]
        public void Adicionar(Estudante estudante)
        {
            service.Adicionar(estudante);
        }
        [HttpGet]
        public List<Estudante> Listar()
        {
            return service.Listar();
        }
    }
}
