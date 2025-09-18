using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategos
{
    public class AutenticarViaRecoveryCodes : IAutenticadorDeUsuario
    {
        public bool EvaluarIdentidad(string param1, string param2, Usuario usuario)
        {
            if (usuario.RecoveryCodes == param1 || usuario.RecoveryCodes == param2)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
