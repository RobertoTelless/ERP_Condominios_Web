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
    
    public partial class CONTRATO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTRATO()
        {
            this.CONTRATO_ANEXO = new HashSet<CONTRATO_ANEXO>();
        }
    
        public int CONT_CD_ID { get; set; }
        public int FORN_CD_ID { get; set; }
        public int TICO_CD_ID { get; set; }
        public System.DateTime CONT_DT_INICIO { get; set; }
        public Nullable<System.DateTime> CONT_DT_FINAL { get; set; }
        public string CONT_DS_DESCRICAO { get; set; }
        public System.DateTime CONT_DT_CADASTRO { get; set; }
        public int CONT_IN_ATIVO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO_ANEXO> CONTRATO_ANEXO { get; set; }
        public virtual FORNECEDOR FORNECEDOR { get; set; }
        public virtual TIPO_CONTRATO TIPO_CONTRATO { get; set; }
    }
}