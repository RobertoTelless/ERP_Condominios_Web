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
    
    public partial class DOCUMENTO_METADADO
    {
        public int DOME_CD_ID { get; set; }
        public int DOCU_CD_ID { get; set; }
        public int META_CD_ID { get; set; }
        public string DOME_NM_VALOR { get; set; }
        public System.DateTime DOME_DT_CADASTRO { get; set; }
        public int DOME_IN_ATIVO { get; set; }
    
        public virtual DOCUMENTO DOCUMENTO { get; set; }
        public virtual METADADO METADADO { get; set; }
    }
}
