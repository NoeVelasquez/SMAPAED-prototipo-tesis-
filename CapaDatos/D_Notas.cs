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


namespace CapaDatos
{
    public class D_Notas
    {
        //Cadena de conexion a la Base de Datos
        public readonly SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaconexion"].ConnectionString);
        public DataSet CargarNota()
        {
            /*connection.Open();
            DataTable resultado = new DataTable();
            SqlCommand cmd = new SqlCommand("select '"+ E.Nombre + "', '"+ E.Apellido + "', '"+ NE.PreExame + "' From NotaEjercicios NE, Estudiante E  Where NE.IDE = E.IDE)");
            //SqlCommand cmd = new SqlCommand("Select * From Estudiante Where ( Usuario ='" + E.User + "' and Contraseña ='" + E.Pass + "')");
            cmd.Connection = connection;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(resultado);

            return resultado;
            //cmd.Parameters.AddWithValue("@Usuario", E.User);
            //cmd.Parameters.AddWithValue("@Contraseña", E.Pass);*/
            connection.Open();
            string Query = "select  E.Nombre,  E.Apellido , NE.PreExamen  From Notas NE, Usuario E  Where NE.IDU = E.IDU";
            SqlDataAdapter adaptar;
            DataSet datos = new DataSet();
            adaptar = new SqlDataAdapter(Query, connection);
            adaptar.Fill(datos, "tbl");
            connection.Close();
            return datos;

        }
        public bool LoginNotas(E_Estudiante E, E_Notas N)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Notas where IDU = '" + E.IDE + "'");
            //SqlCommand cmd = new SqlCommand("Select * From Usuario Where ( usuar ='" + E.User + "' and Contraseña ='" + E.Pass + "')");
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@IDU", E.IDE);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                {
                    N.IDN = (int)reader[0];
                    N.IDU = (int)reader[1];
                    N.PreExamen = (decimal)reader[2];
                    N.ExamenTipFun = (decimal)reader[3];
                    N.ExamenDominio = (decimal)reader[4];
                    N.ExamenExpo = (decimal)reader[5];
                    N.ExamenTrigo = (decimal)reader[6];
                    N.ExamenLogar = (decimal)reader[7];
                    N.ExamenTipDeriv = (decimal)reader[8];
                    N.ExamenRegDer = (decimal)reader[9];
                    N.ExamenFinal = (decimal)reader[10];
                    N.ExamenFinalDerivada = (decimal)reader[11];
                }
                return true;
            }
            else
                return false;
        }
        public bool LoginNotasTipfun(E_Estudiante E, E_Notas N)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Notas where IDU = '"+E.IDE+"'");
            //SqlCommand cmd = new SqlCommand("Select * From Usuario Where ( usuar ='" + E.User + "' and Contraseña ='" + E.Pass + "')");
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@IDU", E.IDE);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {

                while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                {
                    N.IDN = (int)reader[0];
                    N.IDU = (int)reader[1];
                    N.PreExamen = (decimal)reader[2];
                    N.ExamenTipFun = (decimal)reader[3];
                    N.ExamenDominio = (decimal)reader[4];
                    N.ExamenExpo = (decimal)reader[5];
                    N.ExamenTrigo = (decimal)reader[6];
                    N.ExamenLogar = (decimal)reader[7];
                    N.ExamenTipDeriv = (decimal)reader[8];
                    N.ExamenRegDer = (decimal)reader[9];
                    N.ExamenFinal = (decimal)reader[10];
                    N.ExamenFinalDerivada = (decimal)reader[11];
                }

                return true;
            }
            else
                return false;
            connection.Open();
        }

        /* public bool ListarDatoNota(String E, E_Notas N)
         {
             connection.Open();
             SqlCommand cmd = new SqlCommand("select IDNE,PreExame,ExamenFinal,IDP,IDE from NotaEjercicios where IDE = '" + E + "'");
             var reader = cmd.ExecuteReader();
             cmd.Connection = connection;

             cmd.CommandType = CommandType.Text;
             SqlDataReader read = cmd.ExecuteReader();
             if (read.HasRows)
             {

                 while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                 {
                     N.IDNE = (int)read[0];
                     N.PreExame = (decimal)read[1];
                     N.ExamenFinal = (decimal)read[2];
                     N.IDP = (int)read[3];
                     N.IDE = (int)read[4];

                 }

                 return true;
             }
             else
                 return false;

         }*/
        public void CrearNota(E_Notas N, string E)
        {
            connection.Open();
            string Query = "INSERT INTO Notas(IDU,PreExamen,ExamenTipFun,ExamenDominio,ExamenExpo,ExamenTrigo,ExamenLogar,ExamenTipDeriv,ExamenRegDer,ExamenFinal,ExamenFinalDerivada,Actualizacion) VALUES('" + E + "','" + N.PreExamen + "','0','0','0','0','0','0','0','0','0',SYSDATETIME())";
            //string Query = "INSERT INTO Estudiante (Nombre,Apellido,CI,Telefono,Correo,Usuario,Contraseña) VALUES ('" + E.Nombre + "','" + E.Apellido + "','" + E.CI + "','" + E.Telefono + "','" + E.Correo + "','" + E.Usuario + "','" + E.Contraseña + "')";
            SqlCommand sql = new SqlCommand(Query, connection);
            sql.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("NOTA GUARDADA");
        }

        public void ActualizarNtipoFuncion(E_Notas N, string E)
        {
            connection.Open();

            string Query = "UPDATE Notas SET PreExamen = '"+(decimal)N.PreExamen+"', ExamenTipFun = '"+ (decimal)N.ExamenTipFun+"' , ExamenDominio = '"+ (decimal)N.ExamenDominio+"',ExamenExpo ='"+ (decimal)N.ExamenExpo+"',ExamenTrigo ='"+ (decimal)N.ExamenTrigo+"',ExamenLogar ='"+ (decimal)N.ExamenLogar+"',ExamenTipDeriv ='"+ (decimal)N.ExamenTipDeriv+"',ExamenRegDer ='"+ (decimal)N.ExamenRegDer+"',ExamenFinal = '"+ (decimal)N.ExamenFinal+ "',ExamenFinalDerivada= '" + (decimal)N.ExamenFinalDerivada + "',Actualizacion = SYSDATETIME()  WHERE IDU = '" + E+"'";
            SqlCommand sql = new SqlCommand(Query, connection);
            sql.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("NOTA ACTUALIZADO");

        }

        public DataTable getNotas(DateTime fromdate, DateTime todate)
        {
            connection.Open();
            using(var command= new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = @"select U.IDU,U.Apellido,U.Nombre,N.PreExamen,N.ExamenTipFun," +
                    "N.ExamenDominio,N.ExamenExpo,N.ExamenTrigo,N.ExamenLogar," +
                    "N.ExamenTipDeriv,N.ExamenRegDer,N.ExamenFinal as Funciones, " +
                    "N.ExamenFinalDerivada as Derivadas" +
                    "from Usuario U inner join Notas N on N.IDU = U.IDU " +
                    "where U.Actualizacion between @fromdate and @todate" +
                    "order by U.IDU";
                command.Parameters.Add("@fromdate", SqlDbType.Date).Value = fromdate;
                command.Parameters.Add("@todate", SqlDbType.Date).Value = todate;
                command.CommandType = CommandType.Text;
                var reader = command.ExecuteReader();
                var table = new DataTable();
                table.Load(reader );
                reader.Dispose();

                return table;
            }
        }

    }
}
