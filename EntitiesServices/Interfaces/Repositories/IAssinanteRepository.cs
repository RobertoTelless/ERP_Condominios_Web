using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface ICondominioRepository : IRepositoryBase<CONDOMINIO>
    {
        CONDOMINIO CheckExist(CONDOMINIO conta);
        CONDOMINIO GetItemById(Int32 id);
        List<CONDOMINIO> GetAllItens();
        List<CONDOMINIO> GetAllItensAdm();
        List<CONDOMINIO> ExecuteFilter(Int32 tipo, String nome);
    }
}

