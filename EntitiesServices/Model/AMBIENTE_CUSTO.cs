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
    
    public partial class AMBIENTE_CUSTO
    {
        public int AMCU_CD_ID { get; set; }
        public int AMBI_CD_ID { get; set; }
        public decimal AMCU_VL_BASE { get; set; }
        public Nullable<decimal> AMCU_VL_REDUZIDO { get; set; }
        public decimal AMCU_VL_HORA { get; set; }
        public int AMCU_NM_ATIVO { get; set; }
    
        public virtual AMBIENTE AMBIENTE { get; set; }
    }
}
