using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventanilla.Logica.Clases
{
    public class clsDespacho
    {
        public string stInsertarDespacho(long ln_Codigo,
            string stDescripcionDespacho,
            string stDestinoDespacho,
            string stFechaDespacho) 
        {
            try {
                using (Entidades.Cnx obCnx = new Entidades.Cnx()) 
                {
                    Entidades.Despacho obDespacho = new Entidades.Despacho
                    {
                        CodDespacho = ln_Codigo,
                        DescDespacho = stDescripcionDespacho,
                        DestinoDespacho = stDestinoDespacho,
                        Fecha_Despacho = stFechaDespacho
                    };
                    obCnx.Despacho.Add(obDespacho);
                    obCnx.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
            return "Proceso Realizado con Éxito";
        }

        public string stModificarDespacho(long ln_Codigo,
            string stDescripcionDespacho,
            string stDestinoDespacho,
            string stFechaDespacho) 
        {
            try 
            {
               using (Entidades.Cnx obCnx = new Entidades.Cnx())
               {
                   Entidades.Despacho obDespacho = (from D in obCnx.Despacho
                                                    where D.CodDespacho == ln_Codigo
                                                    select D).First();

                   obDespacho.DescDespacho = stDescripcionDespacho;
                   obDespacho.DestinoDespacho = stDestinoDespacho;
                   obDespacho.Fecha_Despacho = stFechaDespacho;

                   obCnx.SaveChanges();
               };     
            }
            catch (Exception ex) { throw ex; }
            return "Proceso Realizado con Éxito";
        }

        public string stEliminarDespacho(long ln_Codigo) 
        {
            try 
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    Entidades.Despacho obDespacho = (from D in obCnx.Despacho
                                                     where D.CodDespacho == ln_Codigo
                                                     select D).First();

                    obCnx.Despacho.Remove(obDespacho);
                    obCnx.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
            return "Proceso Realizado con Éxito";
        }

        public List<Interfaces.clsDespachoInterface> lsConsultarDespachoId(long lnCodigo) 
        {
            try 
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx()) 
                {
                    List<Interfaces.clsDespachoInterface> obQuery = (from D in obCnx.Despacho
                                                                     where D.CodDespacho == lnCodigo
                                                                     select new Interfaces.clsDespachoInterface
                                                                     {
                                                                         ln_CodigoDespacho = D.CodDespacho,
                                                                         st_DescripcionDespacho = D.DescDespacho,
                                                                         st_DestinoDespacho = D.DestinoDespacho,
                                                                         st_FechaDespacho = D.Fecha_Despacho
                                                                     }).ToList();

                    return obQuery;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Interfaces.clsDespachoInterface> lsConsultarDespacho()
        {
            try
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    List<Interfaces.clsDespachoInterface> obQuery = (from D in obCnx.Despacho
                                                                     select new Interfaces.clsDespachoInterface
                                                                     {
                                                                         ln_CodigoDespacho = D.CodDespacho,
                                                                         st_DescripcionDespacho = D.DescDespacho,
                                                                         st_DestinoDespacho = D.DestinoDespacho,
                                                                         st_FechaDespacho = D.Fecha_Despacho
                                                                     }).ToList();

                    return obQuery;
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
