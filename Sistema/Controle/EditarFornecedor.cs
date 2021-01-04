using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Modelo;


namespace Sistema.Controle {
    class EditarFornecedor {
        public bool InserirFornecedor(fornecedore f)
        {
            try
            {
                using (bdsistemaEntities ctx = new bdsistemaEntities())
                {
                    ctx.fornecedores.Add(f);
                    ctx.SaveChanges();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ListarFornecedores()
        {
            using (bdsistemaEntities ctx = new bdsistemaEntities())
            {
                var consulta = ctx.fornecedores;


            }
        }
    }
}
