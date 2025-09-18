using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategos
{
    public class AutenticarViaCelu : IAutenticadorDeUsuario
    {
        public bool EvaluarIdentidad(string param1, string param2, Usuario usuario)
        {
            if (usuario.Celu == param1 && usuario.Password == param2)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
