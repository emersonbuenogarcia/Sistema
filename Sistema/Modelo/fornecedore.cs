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
    
    public partial class fornecedore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fornecedore()
        {
            this.produtos = new HashSet<produto>();
        }
    
        public int id_fornecedores { get; set; }
        public string for_nome { get; set; }
        public string for_endereco { get; set; }
        public string for_ativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto> produtos { get; set; }
    }
}
