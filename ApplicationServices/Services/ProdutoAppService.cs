using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;
using ApplicationServices.Interfaces;
using ModelServices.Interfaces.EntitiesServices;
using CrossCutting;
using System.Text.RegularExpressions;

namespace ApplicationServices.Services
{
    public class ProdutoAppService : AppServiceBase<PRODUTO>, IProdutoAppService
    {
        private readonly IProdutoService _baseService;
        //private readonly IMovimentoEstoqueProdutoService _movService;

        public ProdutoAppService(IProdutoService baseService) : base(baseService)
        {
            _baseService = baseService;
        }

        public List<PRODUTO> GetAllItens(Int32? idAss)
        {
            List<PRODUTO> lista = _baseService.GetAllItens(idAss);
            return lista;
        }

        public List<PRODUTO> GetAllItensAdm(Int32? idAss)
        {
            List<PRODUTO> lista = _baseService.GetAllItensAdm(idAss);
            return lista;
        }

        public List<PRODUTO> GetPontoPedido(Int32? idAss)
        {
            List<PRODUTO> lista = _baseService.GetPontoPedido(idAss);
            return lista;
        }

        public List<PRODUTO> GetEstoqueZerado(Int32? idAss)
        {
            List<PRODUTO> lista = _baseService.GetEstoqueZerado(idAss);
            return lista;
        }

        public PRODUTO GetItemById(Int32 id)
        {
            PRODUTO item = _baseService.GetItemById(id);
            return item;
        }

        public PRODUTO GetByNome(String nome, Int32? idAss)
        {
            PRODUTO item = _baseService.GetByNome(nome, idAss);
            return item;
        }

        public PRODUTO CheckExist(PRODUTO conta, Int32? idAss)
        {
            PRODUTO item = _baseService.CheckExist(conta, idAss);
            return item;
        }

        public List<CATEGORIA_PRODUTO> GetAllTipos(Int32 idAss)
        {
            List<CATEGORIA_PRODUTO> lista = _baseService.GetAllTipos(idAss);
            return lista;
        }

        public List<UNIDADE> GetAllUnidades(Int32 idAss)
        {
            List<UNIDADE> lista = _baseService.GetAllUnidades(idAss);
            return lista;
        }

        public PRODUTO_ANEXO GetAnexoById(Int32 id)
        {
            PRODUTO_ANEXO lista = _baseService.GetAnexoById(id);
            return lista;
        }

        public PRODUTO_FORNECEDOR GetFornecedorById(Int32 id)
        {
            PRODUTO_FORNECEDOR lista = _baseService.GetFornecedorById(id);
            return lista;
        }

        public Int32 ExecuteFilter(Int32? catId, String barcode, String nome, String marca, String codigo, String modelo, String fabricante, Int32? idAss, out List<PRODUTO> objeto)
        {
            try
            {
                objeto = new List<PRODUTO>();
                Int32 volta = 0;

                // Processa filtro
                objeto = _baseService.ExecuteFilter(catId, barcode, nome, marca, codigo, modelo, fabricante, idAss);
                if (objeto.Count == 0)
                {
                    volta = 1;
                }
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //public Int32 ValidateCreate(PRODUTO item, USUARIO usuario)
        //{
        //    try
        //    {
        //        // Verifica existencia prévia
        //        if (_baseService.CheckExist(item) != null)
        //        {
        //            return 1;
        //        }

        //        // Completa objeto
        //        item.PROD_IN_ATIVO = 1;
        //        item.ASSI_CD_ID = SessionMocks.IdAssinante;
        //        item.PROD_QN_ESTOQUE = item.PROD_QN_QUANTIDADE_INICIAL;
        //        item.PROD_DT_ULTIMA_MOVIMENTACAO = DateTime.Today;
        //        MOVIMENTO_ESTOQUE_PRODUTO movto = new MOVIMENTO_ESTOQUE_PRODUTO();

        //        // Monta Log
        //        LOG log = new LOG
        //        {
        //            LOG_DT_DATA = DateTime.Now,
        //            ASSI_CD_ID = SessionMocks.IdAssinante,
        //            USUA_CD_ID = usuario.USUA_CD_ID,
        //            LOG_NM_OPERACAO = "AddPROD",
        //            LOG_IN_ATIVO = 1,
        //            LOG_TX_REGISTRO = Serialization.SerializeJSON<PRODUTO>(item)
        //        };

        //        // Atualiza preços

        //        // Persiste produto
        //        Int32 volta = _baseService.Create(item, log, movto);

        //        // Cria linha de estoque
        //        List<FILIAL> filiais = _filService.GetAllItens();
        //        if (usuario.FILI_CD_ID != null)
        //        {
        //            filiais = filiais.Where(x => x.FILI_CD_ID == usuario.FILI_CD_ID).ToList();
        //        }
        //        foreach (var filial in filiais)
        //        {
        //            PRODUTO_ESTOQUE_FILIAL est = new PRODUTO_ESTOQUE_FILIAL();
        //            est.FILI_CD_ID = filial.FILI_CD_ID;
        //            est.PREF_DS_JUSTIFICATIVA = null;
        //            est.PREF_DT_ULTIMO_MOVIMENTO = null;
        //            est.PREF_IN_ATIVO = 1;
        //            est.PREF_NR_MARKUP = 0;
        //            est.PREF_QN_ESTOQUE = 0;
        //            est.PREF_QN_QUANTIDADE_ALTERADA = 0;
        //            est.PROD_CD_ID = item.PROD_CD_ID;
        //            Int32 volta1 = _estService.Create(est);
        //        }
        //        return volta;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //public Int32 ValidateCreateLeve(PRODUTO item, USUARIO usuario)
        //{
        //    try
        //    {
        //        // Verifica existencia prévia

        //        // Completa objeto
        //        item.PROD_IN_ATIVO = 1;
        //        item.ASSI_CD_ID = SessionMocks.IdAssinante;
        //        item.PROD_QN_ESTOQUE = item.PROD_QN_QUANTIDADE_INICIAL;
        //        item.PROD_DT_ULTIMA_MOVIMENTACAO = DateTime.Today;
        //        MOVIMENTO_ESTOQUE_PRODUTO movto = new MOVIMENTO_ESTOQUE_PRODUTO();

        //        // Monta Log
        //        LOG log = new LOG()
        //        {
        //            LOG_DT_DATA = DateTime.Now,
        //            ASSI_CD_ID = SessionMocks.IdAssinante,
        //            USUA_CD_ID = usuario.USUA_CD_ID,
        //            LOG_NM_OPERACAO = "AddPROD",
        //            LOG_IN_ATIVO = 1,
        //            LOG_TX_REGISTRO = null
        //        };

        //        // Persiste produto
        //        Int32 volta = _baseService.Create(item, log, movto);

        //        // Monta movimento estoque
        //        movto.MOEP_DT_MOVIMENTO = DateTime.Today;
        //        movto.MOEP_IN_ATIVO = 1;
        //        movto.MOEP_IN_CHAVE_ORIGEM = item.PROD_CD_ID;
        //        movto.MOEP_IN_ORIGEM = "PROD";
        //        movto.MOEP_IN_TIPO_MOVIMENTO = 1;
        //        movto.MOEP_QN_QUANTIDADE = item.PROD_QN_QUANTIDADE_INICIAL;
        //        movto.PROD_CD_ID = item.PROD_CD_ID;
        //        movto.USUA_CD_ID = usuario.USUA_CD_ID;
        //        movto.ASSI_CD_ID = SessionMocks.IdAssinante;

        //        // Persiste estoque
        //        volta = _movService.Create(movto);
        //        return volta;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //public Int32 ValidateEdit(PRODUTO item, PRODUTO itemAntes, USUARIO usuario)
        //{
        //    try
        //    {

        //        // Monta Log
        //        LOG log = new LOG
        //        {
        //            LOG_DT_DATA = DateTime.Now,
        //            ASSI_CD_ID = SessionMocks.IdAssinante,
        //            USUA_CD_ID = usuario.USUA_CD_ID,
        //            LOG_NM_OPERACAO = "EditPROD",
        //            LOG_IN_ATIVO = 1,
        //            LOG_TX_REGISTRO = Serialization.SerializeJSON<PRODUTO>(item),
        //            LOG_TX_REGISTRO_ANTES = Serialization.SerializeJSON<PRODUTO>(itemAntes)
        //        };

        //        // Persiste
        //        return _baseService.Edit(item, log);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //public Int32 ValidateEdit(PRODUTO item, PRODUTO itemAntes)
        //{
        //    try
        //    {
        //        // Persiste
        //        return _baseService.Edit(item);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //public Int32 ValidateAcertaEstoque(PRODUTO item, PRODUTO itemAntes, USUARIO usuario)
        //{
        //    try
        //    {
        //        Int32 volta = 0;

        //        // Monta movimento estoque
        //        if (item.PROD_QN_ESTOQUE != item.PROD_QN_CONTAGEM)
        //        {
        //            // Monta Log
        //            LOG log = new LOG
        //            {
        //                LOG_DT_DATA = DateTime.Now,
        //                ASSI_CD_ID = SessionMocks.IdAssinante,
        //                USUA_CD_ID = usuario.USUA_CD_ID,
        //                LOG_NM_OPERACAO = "EditEST",
        //                LOG_IN_ATIVO = 1,
        //                LOG_TX_REGISTRO = Serialization.SerializeJSON<PRODUTO>(item),
        //                LOG_TX_REGISTRO_ANTES = Serialization.SerializeJSON<PRODUTO>(itemAntes)
        //            };

        //            // Persiste
        //            volta = _baseService.Edit(item, log);


        //            Int32 tipo = item.PROD_QN_ESTOQUE < item.PROD_QN_CONTAGEM ? 1 : 2;
        //            Int32? quant = 0;
        //            if (item.PROD_QN_CONTAGEM > item.PROD_QN_ESTOQUE)
        //            {
        //                quant = item.PROD_QN_CONTAGEM - item.PROD_QN_ESTOQUE;
        //            }
        //            else
        //            {
        //                quant = item.PROD_QN_ESTOQUE - item.PROD_QN_CONTAGEM;
        //            }

        //            MOVIMENTO_ESTOQUE_PRODUTO movto = new MOVIMENTO_ESTOQUE_PRODUTO();
        //            movto.MOEP_DT_MOVIMENTO = DateTime.Today;
        //            movto.MOEP_IN_ATIVO = 1;
        //            movto.MOEP_IN_CHAVE_ORIGEM = item.PROD_CD_ID;
        //            movto.MOEP_IN_ORIGEM = "EST";
        //            movto.MOEP_IN_TIPO_MOVIMENTO = tipo;
        //            movto.MOEP_QN_QUANTIDADE = quant.Value;
        //            movto.PROD_CD_ID = item.PROD_CD_ID;
        //            movto.USUA_CD_ID = usuario.USUA_CD_ID;
        //            movto.ASSI_CD_ID = SessionMocks.IdAssinante;
        //            movto.MOEP_DS_JUSTIFICATIVA = item.PROD_DS_JUSTIFICATIVA;

        //            // Persiste estoque
        //            volta = _movService.Create(movto);
        //        }
        //        return volta;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}


        //public Int32 ValidateDelete(PRODUTO item, USUARIO usuario)
        //{
        //    try
        //    {
        //        // Verifica integridade referencial
        //        if (item.MOVIMENTO_ESTOQUE_PRODUTO.Count > 0)
        //        {
        //            return 1;
        //        }
        //        if (item.PRECO_PRODUTO.Count > 0)
        //        {
        //            return 1;
        //        }

        //        // Acerta campos
        //        item.PROD_IN_ATIVO = 0;

        //        // Monta Log
        //        LOG log = new LOG
        //        {
        //            LOG_DT_DATA = DateTime.Now,
        //            ASSI_CD_ID = SessionMocks.IdAssinante,
        //            USUA_CD_ID = usuario.USUA_CD_ID,
        //            LOG_IN_ATIVO = 1,
        //            LOG_NM_OPERACAO = "DelPROD",
        //            LOG_TX_REGISTRO = Serialization.SerializeJSON<PRODUTO>(item)
        //        };

        //        // Persiste
        //        return _baseService.Edit(item, log);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //public Int32 ValidateReativar(PRODUTO item, USUARIO usuario)
        //{
        //    try
        //    {
        //        // Verifica integridade referencial

        //        // Acerta campos
        //        item.PROD_IN_ATIVO = 1;

        //        // Monta Log
        //        LOG log = new LOG
        //        {
        //            LOG_DT_DATA = DateTime.Now,
        //            ASSI_CD_ID = SessionMocks.IdAssinante,
        //            USUA_CD_ID = usuario.USUA_CD_ID,
        //            LOG_IN_ATIVO = 1,
        //            LOG_NM_OPERACAO = "ReatPROD",
        //            LOG_TX_REGISTRO = Serialization.SerializeJSON<PRODUTO>(item)
        //        };

        //        // Persiste
        //        return _baseService.Edit(item, log);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        public Int32 ValidateEditFornecedor(PRODUTO_FORNECEDOR item)
        {
            try
            {
                // Persiste
                return _baseService.EditFornecedor(item);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateCreateFornecedor(PRODUTO_FORNECEDOR item)
        {
            try
            {
                // Persiste
                Int32 volta = _baseService.CreateFornecedor(item);
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        //public Int32 IncluirTabelaPreco(PRODUTO item, USUARIO usuario)
        //{
        //    try
        //    {

        //        // Cria registro
        //        PRODUTO rot = _baseService.GetItemById(item.PROD_CD_ID);
        //        item.PROD_IN_ATIVO = 1;
        //        PRODUTO_TABELA_PRECO rl = new PRODUTO_TABELA_PRECO();
        //        rl.FILI_CD_ID = item.FILI_CD_ID;
        //        rl.PROD_CD_ID = item.PROD_CD_ID;
        //        rl.PRTP_DT_DATA_REAJUSTE = DateTime.Today.Date;
        //        rl.PRTP_IN_ATIVO = 1;
        //        //rl.PRTP_VL_DESCONTO_MAXIMO = item.PRTP_VL_DESCONTO_MAXIMO;
        //        rl.PRTP_VL_PRECO = item.PRTP_VL_PRECO;
        //        rl.PRTP_VL_PRECO_PROMOCAO = item.PRTP_VL_PRECO_PROMOCAO;
        //        rl.PRTP_NR_MARKUP = (Int32)item.PROD_VL_MARKUP_PADRAO;

        //        // Verifica existencia
        //        if (_tbService.CheckExist(rl) != null)
        //        {
        //            return 1;
        //        }

        //        // Inclui na coleção
        //        rot.PRODUTO_TABELA_PRECO.Add(rl);

        //        // Persiste
        //        return _baseService.Edit(rot);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //public Int32 ValidateEditTabelaPreco(PRODUTO_TABELA_PRECO item)
        //{
        //    try
        //    {
        //        // Persiste
        //        item.PRODUTO = null;
        //        return _baseService.EditTabelaPreco(item);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

    }
}
