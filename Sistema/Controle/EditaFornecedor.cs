using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Controle {
   public class EditaFornecedor {
        public bool InserirFornecedor(f fornecedores)
        {
            int erro;
            try
            {
                f.for_nome = txbNome.Text;
                f.for_endereco = txbEndereco.Text;
                if (ckbAtivo.IsThreeState = true)
                {
                    f.for_ativo = char.ToString('1');
                }
                else
                {
                    f.for_ativo = char.ToString('0');
                }
                using (bdlojaEntities ctx = new bdlojaEntities())
                {
                    ctx.fornecedores.Add(f);
                    ctx.SaveChanges();

                }
                return true;
            }
            catch (SQLException e)
            {
                erro = e.getErrorCode();
                System.out.println(e.getMessage() + "'" + erro);
                new TratamentoErro(erro);
                return false;
            }
        }
}
