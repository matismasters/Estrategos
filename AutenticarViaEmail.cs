using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategos
{
    public class AutenticarViaEmail
    {
        public bool AutenticarUsuarioViaEmail(string param0, string param2, Usuario usuario)
        {
            if (usuario.Email == param0 && usuario.Password == param2)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
