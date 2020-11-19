using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IRamoAtividadeRepository : IRepositoryBase<RAMO_ATIVIDADE>
    {
        List<RAMO_ATIVIDADE> GetAllItens(Int32 idAss);
        RAMO_ATIVIDADE GetItemById(Int32 id);
        List<RAMO_ATIVIDADE> GetAllItensAdm(Int32 idAss);
    }
}
