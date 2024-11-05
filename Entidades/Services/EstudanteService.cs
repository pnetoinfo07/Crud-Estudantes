using Core.Entidades;
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
    public class EstudanteService
    {
        private readonly EstudanteRepositorio repositorio;
        public EstudanteService(IConfiguration config)
        {
            repositorio = new EstudanteRepositorio(config);
        }

        public void Adicionar(Estudante estudante)
        {
            repositorio.Adicionar(estudante);
        }
        public List<Estudante> Listar()
        {
            return repositorio.Listar();
        }
    }
}
