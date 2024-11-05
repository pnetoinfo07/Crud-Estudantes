using Core.Entidades;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;

namespace Core.Repositorios
{
    public class EstudanteRepositorio
    {
        private readonly string ConnectionString;
        public EstudanteRepositorio(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Estudante produto)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Estudante>(produto);
        }
        public List<Estudante> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Estudante>().ToList();
        }

    }
}
