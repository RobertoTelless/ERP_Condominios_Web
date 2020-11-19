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
    public class CondominioAppService : AppServiceBase<CONDOMINIO>, ICondominioAppService
    {
        private readonly ICondominioService _baseService;

        public CondominioAppService(ICondominioService baseService): base(baseService)
        {
            _baseService = baseService;
        }

        public CONDOMINIO CheckExist(CONDOMINIO conta)
        {
            CONDOMINIO item = _baseService.CheckExist(conta);
            return item;
        }

        public List<CONDOMINIO> GetAllItens()
        {
            List<CONDOMINIO> lista = _baseService.GetAllItens();
            return lista;
        }

        public List<CONDOMINIO> GetAllItensAdm()
        {
            List<CONDOMINIO> lista = _baseService.GetAllItensAdm();
            return lista;
        }

        public CONDOMINIO GetItemById(Int32 id)
        {
            CONDOMINIO item = _baseService.GetItemById(id);
            return item;
        }

        public Int32 ExecuteFilter(Int32 tipo, String nome, out List<CONDOMINIO> objeto)
        {
            try
            {
                objeto = new List<CONDOMINIO>();
                Int32 volta = 0;

                // Processa filtro
                objeto = _baseService.ExecuteFilter(tipo, nome);
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

        public Int32 ValidateCreate(CONDOMINIO item, USUARIO usuario)
        {
            try
            {
                // Verifica existencia prévia
                if (_baseService.CheckExist(item) != null)
                {
                    return 1;
                }

                // Completa objeto
                item.COND_IN_ATIVO = 1;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    COND_CD_ID = usuario.COND_CD_ID,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_NM_OPERACAO = "AddASSI",
                    LOG_IN_ATIVO = 1,
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CONDOMINIO>(item)
                };

                // Persiste
                Int32 volta = _baseService.Create(item, log);
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateEdit(CONDOMINIO item, CONDOMINIO itemAntes, USUARIO usuario)
        {
            try
            {
                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    COND_CD_ID = usuario.COND_CD_ID,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_NM_OPERACAO = "EditASSI",
                    LOG_IN_ATIVO = 1,
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CONDOMINIO>(item),
                    LOG_TX_REGISTRO_ANTES = Serialization.SerializeJSON<CONDOMINIO>(itemAntes)
                };

                // Persiste
                return _baseService.Edit(item, log);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateDelete(CONDOMINIO item, USUARIO usuario)
        {
            try
            {
                // Verifica integridade referencial
                if (item.USUARIO.Count > 0)
                {
                    return 1;
                }

                // Acerta campos
                item.COND_IN_ATIVO = 0;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    COND_CD_ID = usuario.COND_CD_ID,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_IN_ATIVO = 1,
                    LOG_NM_OPERACAO = "DelASSI",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CONDOMINIO>(item)
                };

                // Persiste
                return _baseService.Edit(item, log);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateReativar(CONDOMINIO item, USUARIO usuario)
        {
            try
            {
                // Verifica integridade referencial

                // Acerta campos
                item.COND_IN_ATIVO = 1;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    COND_CD_ID = usuario.COND_CD_ID,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    LOG_IN_ATIVO = 1,
                    LOG_NM_OPERACAO = "ReatASSI",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CONDOMINIO>(item)
                };

                // Persiste
                return _baseService.Edit(item, log);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
