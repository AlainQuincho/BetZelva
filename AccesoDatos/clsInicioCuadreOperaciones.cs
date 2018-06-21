using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using System.Data;
namespace AccesoDatos
{
    public class clsInicioCuadreOperaciones
    {
        GenEjeSp objEjeSp = new GenEjeSp();
        public DataTable ListaUsuario(int nidUsurio, string cTipBus)
        {
            return objEjeSp.EjecSp("BET_DatosCliente_sp", nidUsurio, cTipBus);
        }
        public DataTable SaldoIniOpe(DateTime dFecSis, int nidUsuario)
        {
            return objEjeSp.EjecSp("BET_SaldoInicial_sp", dFecSis, nidUsuario);
        }
        public DataTable ValIniOpeCaja(DateTime dFecSis, int nidUsuario)
        {
            return objEjeSp.EjecSp("BET_ValidaIniOpe_sp", dFecSis, nidUsuario);
        }

        public string GuardaIniOpe(DateTime dFecSis, int nidUsuario, double nMonSoles, double nmonDolares)
        {
            string cRpta;
            try
            {
                objEjeSp.EjecSp("BET_InicioOperaciones_sp", dFecSis, nidUsuario, nMonSoles, nmonDolares);
                cRpta = "OK";
            }
            catch (Exception e)
            {
                cRpta = e.Message;
            }
            return cRpta;
        }
        public string ValidaCorteFracc(DateTime dFecSis, int nidUsuari, ref string msg)
        {
                string cEstCie;
                DataTable tbValCorFra = objEjeSp.EjecSp("BET_ValidaCorteFrac_sp", dFecSis, nidUsuari);
            cEstCie = tbValCorFra.Rows[0]["cEstCorFra"].ToString();
                try
                {
                    msg = "OK";
                }
                catch (Exception e)
                {
                    msg = e.Message;
                }
                return cEstCie;
        }
        public DataTable ListarBillMon(int idMon, int idBillMon, ref string msg)
        {
                try
                {
                    msg = "OK";
                    return objEjeSp.EjecSp("BET_ListaBillMon_Sp", idMon, idBillMon);
                }
                catch (Exception e)
                {
                    msg = e.Message;
                    return null;
                }
            
        }
        public DataTable ListarCorteFrac(DateTime dFecCor, int idUsu, int idMon, int idMonBill, ref string msg)
        {                try
                {
                    msg = "OK";
                    return objEjeSp.EjecSp("BET_CorteFraccionario_Sp", dFecCor, idUsu, idMon, idMonBill);
                }
                catch (Exception e)
                {
                    msg = e.Message;
                    return null;
                }
        }
        public string registroCorFrac(int idusu, DateTime dFecReg, string XmlMonSol, string XmlBillSol, string XmlBillDol)
        {
                string msg;
                try
                {
                     objEjeSp.EjecSp("BET_RegistraCorFrac_Sp", idusu, dFecReg,  XmlMonSol, XmlBillSol, XmlBillDol);
                    msg = "OK";
                }
                catch (Exception e)
                {
                    msg = e.Message;
                }
                return msg;
        }
        public DataTable ValidarCierreOpe(DateTime dFecOpe,int idUsuario, ref string msg)
        {
            {
                try
                {
                    msg = "OK";
                    return  objEjeSp.EjecSp("BET_ValidaCierreOpe_Sp", dFecOpe,idUsuario);
                }
                catch (Exception e)
                {
                    msg = e.Message;
                    return null;
                }
            }
        }
        //=============================================================
        //--Cuadre de Operacones
        //=============================================================
        public DataTable CuadreOperaciones(DateTime dFecReg, int idUsu, int idMoneda,   int idTipIE, ref string msg)
        {
            
                try
                {
                    msg = "OK";
                    return objEjeSp.EjecSp("BET_ListaCuadreOpe_Sp", dFecReg, idUsu,idMoneda, idTipIE);
                }
                catch (Exception e)
                {
                    msg = e.Message;
                    return null;
                }
        }
        public DataTable SaldoinicialOpe(DateTime dFecReg, int idUsu, ref string msg)
        {
            {
                try
                {
                    msg = "OK";
                    return objEjeSp.EjecSp("BET_SaldoIniOpe_sp", dFecReg, idUsu);
                }
                catch (Exception e)
                {
                    msg = e.Message;
                    return null;
                }
            }
        }
        public string RetMontoCorFracc(DateTime dFecSis, int nidUsuario,  ref double nMonCorSoles, ref double nMonCorDolar)
        {
                string msg;
                try
                {
                    DataTable tbMonCorFra =  objEjeSp.EjecSp("BET_RetMontoCorFrac_Sp", dFecSis, nidUsuario);
                    if (tbMonCorFra.Rows.Count > 0)
                    {
                        nMonCorSoles = Convert.ToDouble(tbMonCorFra.Rows[0]["nTotal"].ToString());
                        nMonCorDolar = Convert.ToDouble(tbMonCorFra.Rows[1]["nTotal"].ToString());
                    }
                    else
                    {
                        nMonCorSoles = 0.00;
                        nMonCorDolar = 0.00;
                    }
                    msg = "OK";
                }
                catch (Exception e)
                {
                    msg = e.Message;
                }
                return msg;
            
        }
        public string RegCierreOperaciones(DateTime dFecReg,        int idusu,                   double nSalIniSol,         double nSalIniDol,
                                                                       double nSalFinSol,          double nSalFinDol,   string xmlIngSol,           string XmlEgrSol,       string XmlIngDol,       string XmlEgrDol)
        {
                string msg;
                try
                {
                    objEjeSp.EjecSp("BET_GuardaCierreOpe_Sp", dFecReg, idusu, nSalIniSol, nSalIniDol,
                                  nSalFinSol, nSalFinDol, xmlIngSol, XmlEgrSol, XmlIngDol, XmlEgrDol);
                    msg = "OK";
                }
                catch (Exception e)
                {
                    msg = e.Message;
                }
                return msg;
        }

    }
}
