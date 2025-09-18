using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategos
{
    public interface IAutenticadorDeUsuario
    {
        bool EvaluarIdentidad(string param1, string param2, Usuario identidad);
    }
}
