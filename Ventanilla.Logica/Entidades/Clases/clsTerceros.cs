using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Ventanilla.Logica.Clases
{
    public class clsTerceros
    {
        public string stInsertarTercero(long ln_Codigo,
            string stTelefonoTercero,
            string stCorreoTercero,
            string stDescripcionTercero)
        {
            try 
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    Entidades.Terceros obTerceros = new Entidades.Terceros
                    {
                        CodTercero = ln_Codigo,
                        TelTercero = stTelefonoTercero,
                        EmailTercero = stCorreoTercero,
                        DescTercero = stDescripcionTercero
                    };
                    obCnx.Terceros.Add(obTerceros);
                    obCnx.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
            return "Proceso Realizado con Éxito";
        }

        public string stModificarTercero(long ln_Codigo,
            string stTelefonoTercero,
            string stCorreoTercero,
            string stDescripcionTercero) 
        {
            try 
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx()) 
                {
                    Entidades.Terceros obTerceros = (from T in obCnx.Terceros
                                                     where T.CodTercero == ln_Codigo
                                                     select T).First();

                    obTerceros.TelTercero = stTelefonoTercero;
                    obTerceros.EmailTercero = stCorreoTercero;
                    obTerceros.DescTercero = stDescripcionTercero;

                    obCnx.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
            return "Proceso Realizado con Éxito";
        }

        public string stEliminarTercero(long ln_Codigo)
        {
            try 
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    Entidades.Terceros obTerceros = (from T in obCnx.Terceros
                                                     where T.CodTercero == ln_Codigo
                                                     select T).First();

                    obCnx.Terceros.Remove(obTerceros);
                    obCnx.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
            return "Proceso Realizado con Éxito";
        }

        public List<Interfaces.clsTercerosInterface> stConsultarTerceroId(long lnCodigo)
        {
            try 
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    List<Interfaces.clsTercerosInterface> obQuery = (from T in obCnx.Terceros
                                                                     where T.CodTercero == lnCodigo
                                                                     select new Interfaces.clsTercerosInterface 
                                                                     {
                                                                        ln_CodigoTercero = T.CodTercero,
                                                                        st_TelefonoTercero = T.TelTercero,
                                                                        st_CorreoTercero = T.EmailTercero,
                                                                        st_DescripcionTercero = T.DescTercero
                                                                     }).ToList();
                    return obQuery;
                }

            }
            catch (Exception ex) { throw ex; }
        }

        public List<Interfaces.clsTercerosInterface> stConsultarTercero()
        {
            try
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    List<Interfaces.clsTercerosInterface> obQuery = (from T in obCnx.Terceros
                                                                     select new Interfaces.clsTercerosInterface
                                                                     {
                                                                         ln_CodigoTercero = T.CodTercero,
                                                                         st_TelefonoTercero = T.TelTercero,
                                                                         st_CorreoTercero = T.EmailTercero,
                                                                         st_DescripcionTercero = T.DescTercero
                                                                     }).ToList();
                    return obQuery;
                }

            }
            catch (Exception ex) { throw ex; }
        }
    }
}
