using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategos
{
    public class Autenticador
    {
        public  IAutenticadorDeUsuario Estrategia { get; set; }

        public Autenticador(IAutenticadorDeUsuario estrategia)
        {
            Estrategia = estrategia;
        }

        public bool EvaluarIdentidad(string param1, string param2, Usuario usuario)
        {
            return Estrategia.EvaluarIdentidad(param1, param2, usuario);
        }
    }
}
