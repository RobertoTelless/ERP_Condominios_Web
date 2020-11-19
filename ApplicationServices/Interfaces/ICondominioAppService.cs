using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ApplicationServices.Interfaces
{
    public interface ICondominioAppService : IAppServiceBase<CONDOMINIO>
    {
        Int32 ValidateCreate(CONDOMINIO perfil, USUARIO usuario);
        Int32 ValidateEdit(CONDOMINIO perfil, CONDOMINIO perfilAntes, USUARIO usuario);
        Int32 ValidateDelete(CONDOMINIO perfil, USUARIO usuario);
        Int32 ValidateReativar(CONDOMINIO perfil, USUARIO usuario);
        CONDOMINIO CheckExist(CONDOMINIO conta);
        List<CONDOMINIO> GetAllItens();
        List<CONDOMINIO> GetAllItensAdm();
        CONDOMINIO GetItemById(Int32 id);
        Int32 ExecuteFilter(Int32 tipo, String nome, out List<CONDOMINIO> objeto);
    }
}
