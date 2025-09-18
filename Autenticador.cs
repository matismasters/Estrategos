using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategos
{
    public class Autenticador
    {
        public static bool AutenticarViaX(string param1, string param2, Usuario usuario, string tipoAutenticacion)
        {
            if (tipoAutenticacion == "email")
            {
                return AutenticarUsuarioViaEmail(param1, param2, usuario);
            } else if (tipoAutenticacion == "celu")
            {
                return AutenticarUsuarioViaCelu(param1, param2, usuario);
            } else if (tipoAutenticacion == "recoveryCodes")
            {
                return AutenticarUsuarioViaRecoveryCodes(param1, param2, usuario);
            }

            return false;
        }

        public static bool AutenticarUsuarioViaEmail(string param0, string param2, Usuario usuario)
        {
            if (usuario.Email == param0 && usuario.Password == param2)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public static bool AutenticarUsuarioViaCelu(string param1, string param2, Usuario usuario)
        {
            if (usuario.Celu == param1 && usuario.Password == param2)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public static bool AutenticarUsuarioViaRecoveryCodes(string param1, string param2, Usuario usuario)
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
