//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitiesServices.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MULTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MULTA()
        {
            this.NOTIFICACAO = new HashSet<NOTIFICACAO>();
        }
    
        public int MULT_CD_ID { get; set; }
        public Nullable<int> VARE_CD_ID { get; set; }
        public string MULT_NM_MULTA { get; set; }
        public Nullable<decimal> MULT_VL_VALOR { get; set; }
        public Nullable<decimal> MULT_VL_PERCENTUAL { get; set; }
        public System.DateTime MULT_DT_CADASTRO { get; set; }
        public int MULT_IN_ATIVO { get; set; }
    
        public virtual VALOR_REFERENCIA VALOR_REFERENCIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICACAO> NOTIFICACAO { get; set; }
    }
}
