using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using System.Data.Sql;
using System.IO;

namespace CapaDatos
{
    public class D_Pregunta
    {
        //Cadena de conexion a la Base de Datos
        public readonly SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaconexion"].ConnectionString);
        protected List<SqlParameter> parametros;
         
        /********************************/
        protected void ExecuteNonQuery(string transacsql)
        {
            connection.Open();
            using(var comando = new SqlCommand())
            {
                comando.Connection = connection;
                comando.CommandText = transacsql;
                comando.CommandType = CommandType.StoredProcedure;
                foreach(SqlParameter item in parametros)
                {
                    comando.Parameters.Add(item);
                }
                comando.ExecuteNonQuery();
                parametros.Clear();
            }
            connection.Close();
        }

        /**************************************/
        protected DataTable ExecuteReader(string transacsql)
        {
            connection.Open();
            using (var comando = new SqlCommand())
            {
                comando.Connection = connection;
                comando.CommandText = transacsql;
                comando.CommandType = CommandType.Text;
                SqlDataReader Lector = comando.ExecuteReader();
                using (var tabla = new DataTable())
                {
                    tabla.Load(Lector);
                    Lector.Dispose();
                    return tabla;
                }
                connection.Close();
            }
            
        }

        
        /******************************/
        public void Crear(E_Preguntas p)
        {
            connection.Open();

            string Query = "insert into Preguntas(Titulo,Foto,opA,opB,opC,opD,opCorrecto,FechaActualizacion,IDC_Fk,IDEx_Fk) values('" + p.TITULO + "', '" +p.FOTO + "', '" + p.OPA+ "', '" + p.OPB + "', '" + p.OPC + "', '" + p.OPD + "', '" + p.CORRECTO + "','" + p.ACTUALIZA + "', '" + p.IDC + "', '" + p.IDE + "')";
            //string Query = "insert into Preguntas values (@Titulo,@Foto,@opA,@opB,@opC,@opD,@opCorrecto,@FechaActualizacion,@IDC_Fk,@IDEx_Fk) ";
            //parametros = new List<SqlParameter>();
            //parametros.Add(new SqlParameter("@Titulo", p.TITULO));
            //parametros.Add(new SqlParameter("@Foto", p.FOTO));
            //parametros.Add(new SqlParameter("@opA", p.OPA));
            //parametros.Add(new SqlParameter("@opB", p.OPB));
            //parametros.Add(new SqlParameter("@opC", p.OPC));
            //parametros.Add(new SqlParameter("@opD", p.OPD));
            //parametros.Add(new SqlParameter("@opCorrecto", p.CORRECTO));
            //parametros.Add(new SqlParameter("@FechaActualizacion", p.ACTUALIZA));
            //parametros.Add(new SqlParameter("@IDC_Fk", p.IDC));
            //parametros.Add(new SqlParameter("@IDEx_Fk", p.IDE));
            SqlCommand sql = new SqlCommand(Query, connection);
            sql.ExecuteNonQuery();
            //ExecuteNonQuery(Query, connection);
            connection.Close();
            //SqlCommand sql = new SqlCommand(Query, connection);
            //sql.ExecuteNonQuery();

            MessageBox.Show("REGISTRO GUARDADO");

            
        }
        
        public DataTable verImagenusuario()
        {
            string query = "select * from Preguntas";
            return ExecuteReader(query);
        }
        public DataSet Listar()
        {
            connection.Open();

            string Query = "select * from Preguntas ";
            SqlDataAdapter Adapta;
            DataSet data = new DataSet();
            
            Adapta = new SqlDataAdapter(Query, connection);
            Adapta.Fill(data, "tbl");
            connection.Close();
        
            return data;
        }
        public DataSet ListarFyD()
        {
            connection.Open();

            string Query = "select * from PreguntaFunDer ";
            SqlDataAdapter Adapta;
            DataSet data = new DataSet();

            Adapta = new SqlDataAdapter(Query, connection);
            Adapta.Fill(data, "tbl");
            connection.Close();

            return data;
        }
        //public void Actualizar(E_Preguntas p)
        //{
        //    connection.Open();

        //    string Query = "update Preguntas set Titulo ='" + p.Titulo + "',Foto ='" + p.Foto + "',opA= '" + p.opA + "',opB='" + p.opB + "',opC='" + p.opC + "',opD= '" + p.opD + "',opCorrecto='" + p.opCorrecto + "',FechaActualizacion = SYSDATETIME(),IDC_Fk='" + p.IDC_Fk + "',IDEx_Fk='" + p.IDEx_Fk + "' where IDPreg = '" + p.IDPreg + "'";

        //    SqlCommand sql = new SqlCommand(Query, connection);
        //    sql.ExecuteNonQuery();
        //    connection.Close();
        //    MessageBox.Show("REGISTRO ACTUALIZADO");
        //}

        public string scalerReturn(string q)
        {
            string sql;
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(q, connection);
                sql = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                throw;
            }
            connection.Close();
            return sql;
        }
        public string scaleReturnFyD(string q)
        {
            string sql;
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(q, connection);
                sql = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                throw;
            }
            connection.Close();
            return sql;
        }
        public byte[] obtener()
        {
            connection.Open();
            SqlCommand sql = new SqlCommand("select Foto from Preguntas", connection);
            SqlDataAdapter dp = new SqlDataAdapter(sql);
            DataSet ds = new DataSet("Preguntas");
            byte[] dato;
            DataRow ima = ds.Tables["Preguntas"].Rows[0];
            dato = (byte[])ima["Foto"];
            //MemoryStream ms = new MemoryStream(dato);
            connection.Close();
            return dato;
        }

        //public string insertar_nota(E_Preguntas p)
        //{
        //    string msg = "";
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("agregarPregunta", connection);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add("Titulo", SqlDbType.NVarChar, 200).Value = p.Titulo;
        //        cmd.Parameters.Add("Foto", SqlDbType.NVarChar, 200).Value = p.Foto;
        //        cmd.Parameters.Add("opA", SqlDbType.NVarChar, 200).Value = p.opA;
        //        cmd.Parameters.Add("opB", SqlDbType.NVarChar, 200).Value = p.opB;
        //        cmd.Parameters.Add("opC", SqlDbType.NVarChar, 200).Value = p.opC;
        //        cmd.Parameters.Add("opD", SqlDbType.NVarChar, 200).Value = p.opD;
        //        cmd.Parameters.Add("opCorrecto", SqlDbType.NVarChar, 200).Value = p.opCorrecto;
        //        cmd.Parameters.Add("FechaActualizacion", SqlDbType.NVarChar, 20).Value = p.FechaActualizacion;
        //        cmd.Parameters.Add("IDC_Fk", SqlDbType.Int).Value = p.IDC_Fk;
        //        cmd.Parameters.Add("IDEx_Fk", SqlDbType.Int).Value = p.IDEx_Fk;
        //        connection.Open();
        //        cmd.ExecuteNonQuery();
        //        msg = "Datos Guardados";
        //    }
        //    catch (Exception)
        //    {
        //        msg = "No se guardo ningun Dato";
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return msg;
        //}


        public void dato()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select Foto from Preguntas ");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            da.Fill(data, "Preguntas");
            int c = data.Tables["Preguntas"].Rows.Count;
            connection.Close();
        }



        
    }
}
