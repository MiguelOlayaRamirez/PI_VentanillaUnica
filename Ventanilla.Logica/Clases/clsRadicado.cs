using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventanilla.Logica.Clases
{
    public class clsRadicado
    {
        public string stInsertarRadicado(long ln_Codigo,
            long lnCodigoTercero,
            long lnCodigoAdmon,
            string stFechaRadicado,
            string stDescripcionRadicado,
            long lnCodigoUsuario)
        {
            try
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    Entidades.Radicado obRadicado = new Entidades.Radicado
                    {
                        CodRadicado = ln_Codigo,
                        CodTercero = lnCodigoTercero,
                        CodAdmon = lnCodigoAdmon,
                        Fecha_Radicado = stFechaRadicado,
                        DescRadicado = stDescripcionRadicado,
                        CodUsuario = lnCodigoUsuario
                    };
                    obCnx.Radicado.Add(obRadicado);
                    obCnx.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }

            return "Proceso realizado con éxito";
        }

        public string stModificarRadicado(long ln_Codigo,
            long lnCodigoTercero,
            long lnCodigoAdmon,
            string stFechaRadicado,
            string stDescripcionRadicado,
            long lnCodigoUsuario)
        {
            try
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    Entidades.Radicado obRadicado = (from R in obCnx.Radicado
                                                     where R.CodRadicado == ln_Codigo
                                                     select R).First();
                    
                    obRadicado.CodTercero = lnCodigoTercero;
                    obRadicado.CodAdmon = lnCodigoAdmon;
                    obRadicado.Fecha_Radicado = stFechaRadicado;
                    obRadicado.DescRadicado = stDescripcionRadicado;
                    obRadicado.CodUsuario = lnCodigoUsuario;

                    obCnx.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }

         return "Proceso realizado con éxito";
        }

        public string stEliminarRadicado(long ln_Codigo) 
        {
            try
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    Entidades.Radicado obRadicado = (from R in obCnx.Radicado
                                                     where R.CodRadicado == ln_Codigo
                                                     select R).First();
                    obCnx.Radicado.Remove(obRadicado);
                    obCnx.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }

            return "Proceso realizado con éxito";
        }

        public List<Interfaces.clsRadicadoInterface> ConsultarRadicadosId(long lnCodigo) 
        {
            try
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    List<Interfaces.clsRadicadoInterface> obQuery = (from R in obCnx.Radicado
                                                                     where R.CodRadicado == lnCodigo
                                                                     select new Interfaces.clsRadicadoInterface
                                                                     {
                                                                         ln_CodigoRadicado = R.CodRadicado,
                                                                         ln_CodTerceroRadicado = R.CodTercero,
                                                                         ln_CodAdmonRadicado = R.CodAdmon,
                                                                         st_FechaRadicado = R.Fecha_Radicado,
                                                                         st_DescripcionRadicado = R.DescRadicado,
                                                                         ln_CodUsuarioRadicado = R.CodUsuario
                                                                     }).ToList();
                    return obQuery;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Interfaces.clsRadicadoInterface> ConsultarRadicados()
        {
            try
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    List<Interfaces.clsRadicadoInterface> obQuery = (from R in obCnx.Radicado
                                                                     select new Interfaces.clsRadicadoInterface
                                                                     {
                                                                         ln_CodigoRadicado = R.CodRadicado,
                                                                         ln_CodTerceroRadicado = R.CodTercero,
                                                                         ln_CodAdmonRadicado = R.CodAdmon,
                                                                         st_FechaRadicado = R.Fecha_Radicado,
                                                                         st_DescripcionRadicado = R.DescRadicado,
                                                                         ln_CodUsuarioRadicado = R.CodUsuario
                                                                     }).ToList();
                    return obQuery;
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
