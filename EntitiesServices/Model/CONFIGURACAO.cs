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
    
    public partial class CONFIGURACAO
    {
        public int CONF_CD_ID { get; set; }
        public Nullable<int> COND_CD_ID { get; set; }
        public int CONF_NR_FALHAS_DIA { get; set; }
        public string CONF_NM_HOST_SMTP { get; set; }
        public string CONF_NM_PORTA_SMTP { get; set; }
        public string CONF_NM_EMAIL_EMISSOR { get; set; }
        public string CONF_NM_SENHA_EMAIL_EMISSOR { get; set; }
        public System.DateTime CONF_DT_ALTERACAO { get; set; }
        public Nullable<int> CONF_NR_DIAS_CP { get; set; }
        public Nullable<int> CONF_NR_DIAS_PATRIMONIO { get; set; }
        public Nullable<int> CONF_NR_DIAS_ATENDIMENTO { get; set; }
        public Nullable<int> CONF_NR_REFRESH_DASH { get; set; }
        public string CONF_NM_ARQUIVO_ALARME { get; set; }
    
        public virtual CONDOMINIO CONDOMINIO { get; set; }
    }
}
