using Core.Entidades;
using Core.Entidades.Interfaces.Repositorio;
using Core.Entidades.Interfaces.Service;
using Core.Repositorios;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class EstudanteService : IEstudanteService
    {
        private readonly IEstudanteRepository _repositorio;
        public EstudanteService(IEstudanteRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(Estudante estudante)
        {
            _repositorio.Adicionar(estudante);
        }
        public List<Estudante> Listar()
        {
            return _repositorio.Listar();
        }
    }
}
