using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCliente
{ 
    //criando entidade cliente ja definindo get e set
   public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public decimal Faturamento { get; set; }
        public DateTime DataFundacao{ get; set; }
        public bool Ativo { get; set; }
        public DateTime Alteracao { get; set; }

        
    }

    
}
