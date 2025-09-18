using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategos
{
    public class Usuario
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Celu {  get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string RecoveryCodes { get; set; } = string.Empty;
    }
}
