using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidades.Interfaces.Repositorio
{
    public interface IEstudanteRepository
    {
        void Adicionar(Estudante produto);
        List<Estudante> Listar();
    }
}
