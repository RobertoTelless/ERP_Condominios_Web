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
    
    public partial class SOLICITACAO_MUDANCA_COMENTARIO
    {
        public int SMCO_CD_ID { get; set; }
        public Nullable<int> SOMU_CD_ID { get; set; }
        public Nullable<int> USUA_CD_ID { get; set; }
        public Nullable<System.DateTime> SMCO_DT_COMENTARIO { get; set; }
        public string SMCO_DS_COMENTARIO { get; set; }
        public Nullable<int> SMCO_IN_ATIVO { get; set; }
    
        public virtual SOLICITACAO_MUDANCA SOLICITACAO_MUDANCA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
