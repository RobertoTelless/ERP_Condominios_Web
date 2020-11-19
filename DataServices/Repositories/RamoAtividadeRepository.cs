using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using ModelServices.Interfaces.Repositories;
using EntitiesServices.Work_Classes;
using System.Data.Entity;

namespace DataServices.Repositories
{
    public class RamoAtividadeRepository : RepositoryBase<RAMO_ATIVIDADE>, IRamoAtividadeRepository
    {
        public RAMO_ATIVIDADE GetItemById(Int32 id)
        {
            IQueryable<RAMO_ATIVIDADE> query = Db.RAMO_ATIVIDADE;
            query = query.Where(p => p.RAAT_CD_ID == id);
            return query.FirstOrDefault();
        }

        public List<RAMO_ATIVIDADE> GetAllItensAdm(Int32 idAss   )
        {
            IQueryable<RAMO_ATIVIDADE> query = Db.RAMO_ATIVIDADE;
            return query.ToList();
        }

        public List<RAMO_ATIVIDADE> GetAllItens(Int32 idAss)
        {
            IQueryable<RAMO_ATIVIDADE> query = Db.RAMO_ATIVIDADE;
            return query.ToList();
        }

    }
}
 