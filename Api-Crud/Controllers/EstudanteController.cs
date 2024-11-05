using Core.Entidades;
using Core.Entidades.Interfaces.Service;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Data.SQLite;

namespace Api_Crud.Controllers;

[ApiController]
[Route("[controller]")]
public class EstudanteController : ControllerBase
{
    private readonly IEstudanteService _service;

    public EstudanteController(IEstudanteService service)
    {
        _service = service;
    }
    [HttpPost]
    public void Adicionar(Estudante estudante)
    {
        _service.Adicionar(estudante);
    }
    [HttpGet]
    public List<Estudante> Listar()
    {
        return _service.Listar();
    }
}
