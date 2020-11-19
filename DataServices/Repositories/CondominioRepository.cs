using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using ModelServices.Interfaces.Repositories;
using System.Data.Entity;
using EntitiesServices.Work_Classes;

namespace DataServices.Repositories
{
    public class CondominioRepository : RepositoryBase<CONDOMINIO>, ICondominioRepository
    {
        public CONDOMINIO CheckExist(CONDOMINIO conta)
        {
            IQueryable<CONDOMINIO> query = Db.ASSINANTE;
            query = query.Where(p => p.COND_NM_CONDOMINIO == conta.COND_NM_CONDOMINIO);
            return query.FirstOrDefault();
        }

        public CONDOMINIO GetItemById(Int32 id)
        {
            IQueryable<CONDOMINIO> query = Db.ASSINANTE;
            query = query.Where(p => p.COND_CD_ID == id);
            query = query.Include(p => p.USUARIO);
            return query.FirstOrDefault();
        }

        public List<CONDOMINIO> GetAllItens()
        {
            IQueryable<CONDOMINIO> query = Db.CONDOMINIO.Where(p => p.COND_IN_ATIVO == 1);
            query = query.Include(p => p.USUARIO);
            return query.ToList();
        }

        public List<CONDOMINIO> GetAllItensAdm()
        {
            IQueryable<CONDOMINIO> query = Db.CONDOMINIO;
            query = query.Include(p => p.USUARIO);
            return query.ToList();
        }

        public List<CONDOMINIO> ExecuteFilter(Int32 tipo, String nome)
        {
            List<CONDOMINIO> lista = new List<CONDOMINIO>();
            IQueryable<CONDOMINIO> query = Db.CONDOMINIO;
            if (!String.IsNullOrEmpty(nome))
            {
                query = query.Where(p => p.COND_NM_CONDOMINIO.Contains(nome));
            }
            if (query != null)
            {
                query = query.OrderBy(a => a.COND_NM_CONDOMINIO);
                lista = query.ToList<CONDOMINIO>();
            }
            return lista;
        }
    }
}
 