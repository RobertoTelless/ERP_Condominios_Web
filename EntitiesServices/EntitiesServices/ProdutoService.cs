using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;
using ModelServices.Interfaces.Repositories;
using ModelServices.Interfaces.EntitiesServices;
using CrossCutting;
using System.Data.Entity;
using System.Data;

namespace ModelServices.EntitiesServices
{
    public class ProdutoService : ServiceBase<PRODUTO>, IProdutoService
    {
        private readonly IProdutoRepository _baseRepository;
        private readonly ILogRepository _logRepository;
        private readonly ICategoriaProdutoRepository _tipoRepository;
        private readonly IProdutoAnexoRepository _anexoRepository;
        private readonly IProdutoFornecedorRepository _fornRepository;
        private readonly IUnidadeRepository _unidRepository;
        private readonly IMovimentoEstoqueProdutoRepository _movRepository;
        protected Erp_CondominioEntities Db = new Erp_CondominioEntities();

        public ProdutoService(IProdutoRepository baseRepository, ILogRepository logRepository, ICategoriaProdutoRepository tipoRepository, IProdutoAnexoRepository anexoRepository, IUnidadeRepository unidRepository, IMovimentoEstoqueProdutoRepository movRepository, IProdutoFornecedorRepository fornRepository) : base(baseRepository)
        {
            _baseRepository = baseRepository;
            _logRepository = logRepository;
            _tipoRepository = tipoRepository;
            _anexoRepository = anexoRepository;
            _unidRepository = unidRepository;
            _movRepository = movRepository;
            _fornRepository = fornRepository;
        }

        public PRODUTO CheckExist(PRODUTO conta, Int32? idAss)
        {
            PRODUTO item = _baseRepository.CheckExist(conta, idAss);
            return item;
        }

        public PRODUTO GetItemById(Int32 id)
        {
            PRODUTO item = _baseRepository.GetItemById(id);
            return item;
        }

        public PRODUTO GetByNome(String nome, Int32? idAss)
        {
            PRODUTO item = _baseRepository.GetByNome(nome, idAss);
            return item;
        }

        public List<PRODUTO> GetAllItens(Int32? idAss)
        {
            return _baseRepository.GetAllItens(idAss);
        }

        public List<PRODUTO> GetPontoPedido(Int32? idAss)
        {
            return _baseRepository.GetPontoPedido(idAss);
        }

        public List<PRODUTO> GetEstoqueZerado(Int32? idAss)
        {
            return _baseRepository.GetEstoqueZerado(idAss);
        }

        public List<PRODUTO> GetAllItensAdm(Int32? idAss)
        {
            return _baseRepository.GetAllItensAdm(idAss);
        }

        public List<CATEGORIA_PRODUTO> GetAllTipos(Int32 idAss)
        {
            return _tipoRepository.GetAllItens(idAss);
        }

        public List<UNIDADE> GetAllUnidades(Int32 idAss)
        {
            return _unidRepository.GetAllItens(idAss);
        }

        public PRODUTO_ANEXO GetAnexoById(Int32 id)
        {
            return _anexoRepository.GetItemById(id);
        }

        public PRODUTO_FORNECEDOR GetFornecedorById(Int32 id)
        {
            return _fornRepository.GetItemById(id);
        }

        public List<PRODUTO> ExecuteFilter(Int32? catId, String barcode, String nome, String marca, String codigo, String modelo, String fabricante, Int32? idAss)
        {
            return _baseRepository.ExecuteFilter(catId, barcode, nome, marca, codigo, modelo, fabricante, idAss);

        }

        public Int32 Create(PRODUTO item, LOG log, MOVIMENTO_ESTOQUE_PRODUTO movto)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    _logRepository.Add(log);
                    _baseRepository.Add(item);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public Int32 Create(PRODUTO item)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    _baseRepository.Add(item);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }


        public Int32 Edit(PRODUTO item, LOG log)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    PRODUTO obj = _baseRepository.GetById(item.PROD_CD_ID);
                    _baseRepository.Detach(obj);
                    _logRepository.Add(log);
                    _baseRepository.Update(item);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public Int32 Edit(PRODUTO item)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    PRODUTO obj = _baseRepository.GetById(item.PROD_CD_ID);
                    _baseRepository.Detach(obj);
                    _baseRepository.Update(item);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public Int32 Delete(PRODUTO item, LOG log)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    _logRepository.Add(log);
                    _baseRepository.Remove(item);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public Int32 EditFornecedor(PRODUTO_FORNECEDOR item)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    PRODUTO_FORNECEDOR obj = _fornRepository.GetById(item.PRFO_CD_ID);
                    _fornRepository.Detach(obj);
                    _fornRepository.Update(item);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public Int32 CreateFornecedor(PRODUTO_FORNECEDOR item)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    _fornRepository.Add(item);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}
