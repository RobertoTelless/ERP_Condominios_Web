using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;

namespace ModelServices.Interfaces.EntitiesServices
{
    public interface ICondominioService : IServiceBase<CONDOMINIO>
    {
        Int32 Create(CONDOMINIO perfil, LOG log);
        Int32 Create(CONDOMINIO perfil);
        Int32 Edit(CONDOMINIO perfil, LOG log);
        Int32 Edit(CONDOMINIO perfil);
        Int32 Delete(CONDOMINIO perfil, LOG log);
        CONDOMINIO CheckExist(CONDOMINIO conta);
        CONDOMINIO GetItemById(Int32 id);
        List<CONDOMINIO> GetAllItens();
        List<CONDOMINIO> GetAllItensAdm();
        List<CONDOMINIO> ExecuteFilter(Int32 tipo, String nome);
    }
}
