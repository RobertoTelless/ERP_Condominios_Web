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
    
    public partial class FUNCAO_CORPO_DIRETIVO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FUNCAO_CORPO_DIRETIVO()
        {
            this.CORPO_DIRETIVO = new HashSet<CORPO_DIRETIVO>();
        }
    
        public int FUCO_CD_ID { get; set; }
        public string FUCO_NM_NOME { get; set; }
        public Nullable<int> COND_CD_ID { get; set; }
        public Nullable<int> FUCO_IN_ORDEM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CORPO_DIRETIVO> CORPO_DIRETIVO { get; set; }
    }
}
