using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using EntitiesServices.Model;
using ErpCondominio.ViewModels;

namespace MvcMapping.Mappers
{
    public class DomainToViewModelMappingProfiles : Profile
    {
        public DomainToViewModelMappingProfiles()
        {
            CreateMap<USUARIO, UsuarioViewModel>();
            CreateMap<USUARIO, UsuarioLoginViewModel>();
            CreateMap<LOG, LogViewModel>();
            CreateMap<CONFIGURACAO, ConfiguracaoViewModel>();
            CreateMap<CARGO, CargoViewModel>();
            CreateMap<NOTICIA, NoticiaViewModel>();
            CreateMap<NOTICIA_COMENTARIO, NoticiaComentarioViewModel>();
            CreateMap<NOTIFICACAO, NotificacaoViewModel>();
            CreateMap<TIPO_PESSOA, TipoPessoaViewModel>();
            CreateMap<UNIDADE, UnidadeViewModel>();
            CreateMap<TEMPLATE, TemplateViewModel>();
            CreateMap<TAREFA, TarefaViewModel>();
            CreateMap<CATEGORIA_AGENDA, CategoriaAgendaViewModel>();
            CreateMap<AGENDA, AgendaViewModel>();
            CreateMap<TAREFA_ACOMPANHAMENTO, TarefaAcompanhamentoViewModel>();
            CreateMap<TELEFONE, TelefoneViewModel>();
            CreateMap<GRUPO, GrupoViewModel>();
            CreateMap<SUBGRUPO, SubgrupoViewModel>();
            CreateMap<CENTRO_CUSTO, CentroCustoViewModel>();
            CreateMap<BANCO, BancoViewModel>();
            CreateMap<CONTA_BANCO, ContaBancariaViewModel>();
            CreateMap<CONTA_BANCO_CONTATO, ContaBancariaContatoViewModel>();
            CreateMap<CONTA_BANCO_LANCAMENTO, ContaBancariaLancamentoViewModel>();

        }
    }
}
