using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;

namespace ModelServices.Interfaces.EntitiesServices
{
    public interface IProdutoService : IServiceBase<PRODUTO>
    {
        Int32 Create(PRODUTO perfil, LOG log, MOVIMENTO_ESTOQUE_PRODUTO movto);
        Int32 Create(PRODUTO perfil);
        Int32 Edit(PRODUTO perfil, LOG log);
        Int32 Edit(PRODUTO perfil);
        Int32 Delete(PRODUTO perfil, LOG log);
        PRODUTO CheckExist(PRODUTO conta, Int32? idAss);
        PRODUTO GetItemById(Int32 id);
        PRODUTO GetByNome(String nome, Int32? idAss);
        List<PRODUTO> GetAllItens(Int32? idAss);
        List<PRODUTO> GetAllItensAdm(Int32? idAss);
        List<CATEGORIA_PRODUTO> GetAllTipos(Int32 idAss);
        List<UNIDADE> GetAllUnidades(Int32 idAss);
        PRODUTO_ANEXO GetAnexoById(Int32 id);
        List<PRODUTO> ExecuteFilter(Int32? catId, String barcode, String nome, String marca, String codigo, String modelo, String fabricante, Int32? idAss);
        PRODUTO_FORNECEDOR GetFornecedorById(Int32 id);
        Int32 EditFornecedor(PRODUTO_FORNECEDOR item);
        Int32 CreateFornecedor(PRODUTO_FORNECEDOR item);
        List<PRODUTO> GetPontoPedido(Int32? idAss);
        List<PRODUTO> GetEstoqueZerado(Int32? idAss);
    }
}
