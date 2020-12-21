using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Modelo;

namespace Sistema.Controle {
    class LoginUsuario {
        public bool Logar(usuario u)
        {
            try
            {
                using (bdlojaEntities2 ctx = new bdlojaEntities2())
                {
                    ctx.usuarios.Find(u);
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
