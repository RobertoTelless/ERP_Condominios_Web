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
    
    public partial class TAXA_CONDOMINIO
    {
        public int TACO_CD_ID { get; set; }
        public int UNID_CD_ID { get; set; }
        public int MOVI_CD_ID { get; set; }
        public int TITA_CD_ID { get; set; }
        public System.DateTime TACO_DT_REFERENCIA { get; set; }
        public decimal TACO_VL_VALOR { get; set; }
        public System.DateTime TACO_DT_VENCIMENTO { get; set; }
        public string TACO_DS_HISTORICO { get; set; }
        public int TACO_IN_ATIVO { get; set; }
    
        public virtual MOVIMENTO MOVIMENTO { get; set; }
        public virtual TIPO_TAXA TIPO_TAXA { get; set; }
        public virtual UNIDADE UNIDADE { get; set; }
    }
}
