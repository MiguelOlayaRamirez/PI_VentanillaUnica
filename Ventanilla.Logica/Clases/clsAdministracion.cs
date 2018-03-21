using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventanilla.Logica.Clases
{
    public class clsAdministracion
    {
        public string stInsertarColaborador(long ln_Codigo,
            string stNombreColaborador,
            string stApellidoColaborador,
            string stCargoColaborador,
            string stAreaColaborador,
            long lnCodDespacho,
            long lnCodProceso)
        {
            try 
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    Entidades.Administracion obAdministracion = new Entidades.Administracion
                    {
                        CodAdmon = ln_Codigo,
                        NomAdmon = stNombreColaborador,
                        ApeAdmon = stApellidoColaborador,
                        CargoAdmon = stCargoColaborador,
                        AreaAdmon = stAreaColaborador,
                        CodDespacho = lnCodDespacho,
                        CodProceso = lnCodProceso
                    };
                    obCnx.Administracion.Add(obAdministracion);
                    obCnx.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
            return "Proceso Realizado con Éxito";
        }

        public string stModificarColaborador(long ln_Codigo,
            string stNombreColaborador,
            string stApellidoColaborador,
            string stCargoColaborador,
            string stAreaColaborador,
            long lnCodDespacho,
            long lnCodProceso)
        {
            try
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    Entidades.Administracion obAdministracion = (from A in obCnx.Administracion
                                                                 where A.CodAdmon == ln_Codigo
                                                                 select A).First();

                    obAdministracion.NomAdmon = stNombreColaborador;
                    obAdministracion.ApeAdmon = stApellidoColaborador;
                    obAdministracion.CargoAdmon = stCargoColaborador;
                    obAdministracion.AreaAdmon = stAreaColaborador;
                    obAdministracion.CodDespacho = lnCodDespacho;
                    obAdministracion.CodProceso = lnCodProceso;

                    obCnx.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
            return "Proceso Realizado con Éxito";
        }

        public string stEliminarColaborador(long ln_Codigo)
        {
            try 
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    Entidades.Administracion obAdministracion = (from A in obCnx.Administracion
                                                                 where A.CodAdmon == ln_Codigo
                                                                 select A).First();

                    obCnx.Administracion.Remove(obAdministracion);
                    obCnx.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }

            return "Proceso Realizadon con Éxito";
        }

        public List<Interfaces.clsAdministracionInterface> lsConsultarColaboradorId(long lnCodigo)
        {
            try 
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    List<Interfaces.clsAdministracionInterface> obQuery = (from A in obCnx.Administracion
                                                                           where A.CodAdmon == lnCodigo
                                                                           select new Interfaces.clsAdministracionInterface 
                                                                           {
                                                                                ln_CodigoAdmon = A.CodAdmon,
                                                                                st_NombreAdmon = A.NomAdmon,
                                                                                st_ApellidoAdmon = A.ApeAdmon,
                                                                                st_CargoAdmon = A.CargoAdmon,
                                                                                st_AreaAdmon = A.AreaAdmon,
                                                                                ln_CodDespachoAdmon = A.CodDespacho,
                                                                                ln_CodProcesoAdmon = A.CodProceso
                                                                           }).ToList();
                    return obQuery;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Interfaces.clsAdministracionInterface> lsConsultarColaborador()
        {
            try
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    List<Interfaces.clsAdministracionInterface> obQuery = (from A in obCnx.Administracion
                                                                           select new Interfaces.clsAdministracionInterface
                                                                           {
                                                                               ln_CodigoAdmon = A.CodAdmon,
                                                                               st_NombreAdmon = A.NomAdmon,
                                                                               st_ApellidoAdmon = A.ApeAdmon,
                                                                               st_CargoAdmon = A.CargoAdmon,
                                                                               st_AreaAdmon = A.AreaAdmon,
                                                                               ln_CodDespachoAdmon = A.CodDespacho,
                                                                               ln_CodProcesoAdmon = A.CodProceso
                                                                           }).ToList();
                    return obQuery;
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
