using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
using System.Configuration;

namespace Helper
{
    public class GenEjeSp
    {
        #region Listas
        Dictionary<string, SqlDbType> dicSQLDBType = new Dictionary<string, SqlDbType>
            {   { "bit", SqlDbType.Bit},
                { "bigint", SqlDbType.BigInt},
                { "binary", SqlDbType.Binary},
                { "char", SqlDbType.Char},
                { "date", SqlDbType.Date},
                { "datetime", SqlDbType.DateTime},
                { "datetime2", SqlDbType.DateTime2},
                { "datetimeoffset", SqlDbType.DateTimeOffset},
                { "decimal", SqlDbType.Decimal},
                { "numeric", SqlDbType.Decimal},
                { "float", SqlDbType.Float},
                { "image", SqlDbType.Image},
                { "int", SqlDbType.Int},
                { "money", SqlDbType.Money},
                { "nchar", SqlDbType.NChar},
                { "nvarchar", SqlDbType.NVarChar},
                { "ntext", SqlDbType.NText},
                { "real", SqlDbType.Real},
                { "smalldatetime", SqlDbType.SmallDateTime},
                { "smallint", SqlDbType.SmallInt},
                { "time", SqlDbType.Time},
                { "timestamp", SqlDbType.Timestamp},
                { "tinyint", SqlDbType.TinyInt},
                { "uniqueidentifier", SqlDbType.UniqueIdentifier},
                { "text", SqlDbType.Text},
                { "varbinary", SqlDbType.VarBinary},
                { "varchar", SqlDbType.VarChar},
                { "xml", SqlDbType.Xml} };

        Dictionary<string, ParameterDirection> dicParamDir = new Dictionary<string, ParameterDirection>
            {   { "IN", ParameterDirection.Input},
                { "INOUT", ParameterDirection.Output}};
        #endregion

        private List<GenParametros> _lstParametros = new List<GenParametros>();

        /// <summary>
        /// Carga los parametros de un Store Procedure determinado
        /// </summary>
        /// <param name="nombreSp">Nombre del Store Proccedure</param>
        /// <param name="con">Conexión a la base de datos</param>
        /// <returns>Listado de parametros del Store Procedure</returns>
        public List<GenParametros> CargaParametroSp(string nombreSp, SqlConnection con)
        {
            List<GenParametros> lstParamsSp = new List<GenParametros>();
            using (SqlCommand lstParams = new SqlCommand())
            {
                lstParams.Connection = con;

                lstParams.CommandText = "GEN_LstParamsxSP_SP";
                lstParams.CommandType = CommandType.StoredProcedure;
                lstParams.Parameters.Add(new SqlParameter("@x_cNombreSP", nombreSp));
                SqlDataReader parametersReader = lstParams.ExecuteReader();

                {
                    while (parametersReader.Read())
                    {
                        GenParametros paramSp = new GenParametros();
                        SqlParameter parametro = new SqlParameter();
                        //string paramInfo = string.Format(
                        //  "Orden: {0} NombreParametro: {1} Tipo: {2} Longitud: {3} Modo: {4} ",
                        //  parametersReader["ORDINAL_POSITION"],
                        //  parametersReader["PARAMETER_NAME"],
                        //  parametersReader["DATA_TYPE"],
                        //  parametersReader["CHARACTER_MAXIMUM_LENGTH"],
                        //  parametersReader["PARAMETER_MODE"]);

                        paramSp.Posicion = Convert.ToInt32(parametersReader["ORDINAL_POSITION"]);
                        paramSp.Tipodatos = parametersReader["DATA_TYPE"].ToString();
                        parametro.ParameterName = parametersReader["PARAMETER_NAME"].ToString();
                        parametro.SqlDbType = dicSQLDBType[parametersReader["DATA_TYPE"].ToString()];
                        parametro.Direction = dicParamDir[parametersReader["PARAMETER_MODE"].ToString()];
                        if (parametersReader["DATA_TYPE"].ToString() == "char")
                            parametro.Size = Convert.ToInt32(parametersReader["CHARACTER_MAXIMUM_LENGTH"]);
                        paramSp.Parametro = parametro;
                        lstParamsSp.Add(paramSp);
                    }
                }
                lstParams.Dispose();
                parametersReader.Close();
                return lstParamsSp;
            }
        }

        /// <summary>
        /// Ejecuta un Store Procedure retornando una estructura tabla de la bd
        /// </summary>
        /// <param name="nombreSp">Nombre del Store Proccedure</param>
        /// <param name="parametros">Parametros del Store Procedure</param>
        /// <returns>Tabla seleccionada por el Store Procedure</returns>
        public DataTable EjecSp(string nombreSp, params object[] parametros)
        {

            DataTable dt = new DataTable();
            using (SqlConnection conexion = new SqlConnection())
            {
                if (string.IsNullOrEmpty(GetConnectionString()))
                {
                    return estructuraVacia();
                }

                conexion.ConnectionString = GetConnectionString();// clsGENConexion.leeXML()[0].ToString() ;

                conexion.Open();
                //RoleCommand.ExecuteNonQuery();
                _lstParametros = CargaParametroSp(nombreSp, conexion);
                SqlCommand comandoSp = new SqlCommand();
                comandoSp.CommandText = nombreSp;
                comandoSp.CommandType = CommandType.StoredProcedure;
                comandoSp.Connection = conexion;
                comandoSp.CommandTimeout = 600;
                for (int i = 0; i < _lstParametros.Count; i++)
                {
                    if (_lstParametros[i].Parametro.SqlDbType == SqlDbType.Xml && parametros[i] != DBNull.Value)
                    {
                        _lstParametros[i].Parametro.Value = new SqlXml(new XmlTextReader(parametros[i].ToString(), XmlNodeType.Document, null));
                    }
                    else
                    {
                        _lstParametros[i].Parametro.Value = parametros[i];
                    }

                    comandoSp.Parameters.Add(_lstParametros[i].Parametro);
                }
                SqlDataReader reader = comandoSp.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                conexion.Close();
                conexion.Dispose();
            }
            return dt;
        }

        /********************************************************************************************************/
        /// <summary>
        /// Ejecuta un Store Procedure retornando un conjunto de tablas de la bd llenados en un dataset 
        /// </summary>
        /// <param name="nombreSp">Nombre del Store Proccedure</param>
        /// <param name="parametros">Parametros del Store Procedure</param>
        /// <returns>DataSrt con las tablas seleccionada por el Store Procedure</returns>
        public DataSet DsEjecSp(string nombreSp, params object[] parametros)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conexion = new SqlConnection())
            {
                if (string.IsNullOrEmpty(GetConnectionString()))
                {
                    return new DataSet();
                }

                conexion.ConnectionString = GetConnectionString();// clsGENConexion.leeXML()[0].ToString() ;
                SqlCommand roleCommand = new SqlCommand();
                roleCommand.CommandType = CommandType.Text;
                roleCommand.CommandText = "SP_SETAPPROLE";
                //RoleCommand.Parameters.Add(new SqlParameter("rolename", clsPassword.cRole)); // clsGENConexion.leeXML()[1].ToString()));
                //RoleCommand.Parameters.Add(new SqlParameter("password", clsPassword.cPassRole));// clsGENConexion.leeXML()[2].ToString()));
                roleCommand.CommandType = CommandType.StoredProcedure;
                roleCommand.Connection = conexion;
                conexion.Open();
                //RoleCommand.ExecuteNonQuery(); 
                _lstParametros = CargaParametroSp(nombreSp, conexion);
                SqlCommand comandoSp = new SqlCommand();
                comandoSp.CommandText = nombreSp;
                comandoSp.CommandType = CommandType.StoredProcedure;
                comandoSp.Connection = conexion;
                comandoSp.CommandTimeout = 600;
                for (int i = 0; i < _lstParametros.Count; i++)
                {
                    if (_lstParametros[i].Parametro.SqlDbType == SqlDbType.Xml)
                        _lstParametros[i].Parametro.Value = new SqlXml(new XmlTextReader(parametros[i].ToString(), XmlNodeType.Document, null));
                    else
                        _lstParametros[i].Parametro.Value = parametros[i];
                    comandoSp.Parameters.Add(_lstParametros[i].Parametro);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(comandoSp);
                adapter.Fill(ds);
                adapter.Dispose();
                roleCommand.Dispose();
                conexion.Close();
                conexion.Dispose();
            }
            return ds;
        }
        /// <summary>
        /// Ejecuta un Store Procedure con parametros de salida
        /// </summary>
        /// <param name="nombreSp">Nombre del Store Procedure</param>
        /// <param name="parametros">Parametros del Store Procedure</param>
        /// <returns>Kistado de parametros de salida(Output)</returns>
        public List<GenParametros> EjecSpOut(string nombreSp, params object[] parametros)
        {


            if (string.IsNullOrEmpty(GetConnectionString()))
            {
                return new List<GenParametros>();
            }

            using (SqlConnection conexion = new SqlConnection())
            {
                conexion.ConnectionString = GetConnectionString();
                SqlCommand roleCommand = new SqlCommand();
                roleCommand.CommandType = CommandType.Text;
                roleCommand.CommandText = "SP_SETAPPROLE";
                //RoleCommand.Parameters.Add(new SqlParameter("rolename", clsPassword.cRole));
                //RoleCommand.Parameters.Add(new SqlParameter("password", clsPassword.cPassRole));
                roleCommand.CommandType = CommandType.StoredProcedure;
                roleCommand.Connection = conexion;
                conexion.Open();
                //RoleCommand.ExecuteNonQuery();
                _lstParametros = CargaParametroSp(nombreSp, conexion);
                SqlCommand comandoSp = new SqlCommand();
                comandoSp.CommandText = nombreSp;
                comandoSp.CommandType = CommandType.StoredProcedure;
                comandoSp.Connection = conexion;
                comandoSp.CommandTimeout = 600;
                for (int i = 0; i < _lstParametros.Count; i++)
                {
                    if (_lstParametros[i].Parametro.SqlDbType == SqlDbType.Xml)
                        _lstParametros[i].Parametro.Value = new SqlXml(new XmlTextReader(parametros[i].ToString(), XmlNodeType.Document, null));
                    else
                        _lstParametros[i].Parametro.Value = parametros[i];
                    comandoSp.Parameters.Add(_lstParametros[i].Parametro);
                }
                comandoSp.ExecuteNonQuery();
                roleCommand.Dispose();
                conexion.Close();
            }
            _lstParametros.RemoveAll(x => x.Parametro.Direction != ParameterDirection.Output);
            return _lstParametros;
        }

        /// <summary>
        /// Ejecuta un Store Procedure que no retorna ningun tipo de tabla y/o parametro
        /// </summary>
        /// <param name="nombreSp">Nombre del Store Procedure</param>
        /// <param name="parametros">Parametros del Store Procedure</param>
        public void EjecSpAlm(string nombreSp, params object[] parametros)
        {


            if (string.IsNullOrEmpty(GetConnectionString()))
            {
                return;
            }

            using (SqlConnection conexion = new SqlConnection())
            {
                conexion.ConnectionString = GetConnectionString();//clsGENConexion.leeXML()[0].ToString();
                conexion.Open();
                _lstParametros = CargaParametroSp(nombreSp, conexion);
                SqlCommand comandoSp = new SqlCommand();
                comandoSp.CommandText = nombreSp;
                comandoSp.CommandType = CommandType.StoredProcedure;
                comandoSp.Connection = conexion;
                comandoSp.CommandTimeout = 600;
                for (int i = 0; i < _lstParametros.Count; i++)
                {
                    if (_lstParametros[i].Parametro.SqlDbType == SqlDbType.Xml)
                        _lstParametros[i].Parametro.Value = new SqlXml(new XmlTextReader(parametros[i].ToString(), XmlNodeType.Document, null));
                    else
                        _lstParametros[i].Parametro.Value = parametros[i];
                    comandoSp.Parameters.Add(_lstParametros[i].Parametro);
                }
                comandoSp.ExecuteNonQuery();
                conexion.Close();
            }
        }
        private string GetConnectionString()
        {
            SqlConnectionStringBuilder cnBuilder = new SqlConnectionStringBuilder();
            cnBuilder.DataSource = "jhak.database.windows.net";
            cnBuilder.InitialCatalog = "BdBetZelva";
            cnBuilder.IntegratedSecurity = false;
            cnBuilder.UserID = "jhak";
            cnBuilder.Password = "jh@k1234";

            return cnBuilder.ToString();
        }
        private DataTable estructuraVacia()
        {
            var dt = new DataTable();
            dt.Columns.Add("col1");
            dt.Columns.Add("col2");
            dt.Columns.Add("col3");
            dt.Columns.Add("col4");
            dt.Columns.Add("col5");
            return dt;
        }
    }
}
