using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositorio.Data
{
    public static class InicializadorBd
    {
        private const string ConnectioString = "Data Source=CrudEstudante.db";
        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectioString))
            {
                connection.Open();
                string commandoSQL = @" 
                    CREATE TABLE IF NOT EXISTS Estudantes(                
                    Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                    Nome TEXT NOT NULL, 
                    Idade INTEGER NOT NULL,
                    Peso REAL NOT NULL,
                    Altura REAL NOT NULL
                    );";

                connection.Execute(commandoSQL);
            }
        }
    }
}

