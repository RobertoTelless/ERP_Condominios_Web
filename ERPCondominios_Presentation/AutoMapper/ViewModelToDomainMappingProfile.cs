using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using EntitiesServices.Model;
using ErpCondominio.ViewModels;

namespace MvcMapping.Mappers
{
    public class ViewModelToDomainMappingProfiles : Profile
    {
        public ViewModelToDomainMappingProfiles()
        {
            CreateMap<UsuarioViewModel, USUARIO>();
            CreateMap<UsuarioLoginViewModel, USUARIO>();
            CreateMap<LogViewModel, LOG>();
            CreateMap<ConfiguracaoViewModel, CONFIGURACAO>();
            CreateMap<CargoViewModel, CARGO>();
            CreateMap<NoticiaViewModel, NOTICIA>();
            CreateMap<NoticiaComentarioViewModel, NOTICIA_COMENTARIO>();
            CreateMap<NotificacaoViewModel, NOTIFICACAO>();
            CreateMap<TipoPessoaViewModel, TIPO_PESSOA>();
            CreateMap<UnidadeViewModel, UNIDADE>();
            CreateMap<TemplateViewModel, TEMPLATE>();
            CreateMap<TarefaViewModel, TAREFA>();
            CreateMap<CategoriaAgendaViewModel, CATEGORIA_AGENDA>();
            CreateMap<AgendaViewModel, AGENDA>();
            CreateMap<TarefaAcompanhamentoViewModel, TAREFA_ACOMPANHAMENTO>();
            CreateMap<TelefoneViewModel, TELEFONE>();
            CreateMap<GrupoViewModel, GRUPO>();
            CreateMap<SubgrupoViewModel, SUBGRUPO>();
            CreateMap<CentroCustoViewModel, CENTRO_CUSTO>();
            CreateMap<BancoViewModel, BANCO>();
            CreateMap<ContaBancariaViewModel, CONTA_BANCO>();
            CreateMap<ContaBancariaContatoViewModel, CONTA_BANCO_CONTATO>();
            CreateMap<ContaBancariaLancamentoViewModel, CONTA_BANCO_LANCAMENTO>();

        }
    }
}