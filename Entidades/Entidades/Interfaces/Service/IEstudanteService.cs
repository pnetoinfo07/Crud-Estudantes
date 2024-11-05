using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidades.Interfaces.Service
{
    public interface IEstudanteService
    {
        void Adicionar(Estudante produto);
        List<Estudante> Listar();
    }
}
