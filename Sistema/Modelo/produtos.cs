//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class produtos
    {
        public int id_produtos { get; set; }
        public int id_fornecedores { get; set; }
        public string pro_nome { get; set; }
        public decimal pro_quantidade { get; set; }
    
        public virtual fornecedores fornecedores { get; set; }
    }
}
