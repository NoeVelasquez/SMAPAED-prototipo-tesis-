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
    public class D_Parcial
    {
        //Cadena de conexion a la Base de Datos
        public readonly SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaconexion"].ConnectionString);
        public bool LoginParcial(E_Estudiante E, E_Parcial N)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from NotasParcial where IDU = '" + E.IDE + "'");
            //SqlCommand cmd = new SqlCommand("Select * From Usuario Where ( usuar ='" + E.User + "' and Contraseña ='" + E.Pass + "')");
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@IDU", E.IDE);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                {
                    N.IDNpar = (int)reader[0];
                    N.IDUsua = (int)reader[1];
                    N.Tema1 = (decimal)reader[2];
                    N.Tema2 = (decimal)reader[3];
                    N.Tema3 = (decimal)reader[4];
                    N.Tema4 = (decimal)reader[5];
                    N.Tema5 = (decimal)reader[6];
                    N.Tema6 = (decimal)reader[7];
                    N.Tema7 = (decimal)reader[8];
                    N.ExamenFinal = (decimal)reader[9];
                }
                return true;
            }
            else
                return false;
        }
        public void CrearParcial(E_Parcial N, string E)
        {
            connection.Open();
            string Query = "INSERT INTO NotasParcial (IDU, Tema1, Tema2, Tema3, Tema4, Tema5, Tema6, Tema7, ExamenFinal,Actualizacion) VALUES('" + E + "', '" + N.Tema1 + "', 0, 0, 0, 0, 0, 0, 0, SYSDATETIME() )";
            //string Query = "INSERT INTO Notas(IDU,PreExamen,ExamenTipFun,ExamenDominio,ExamenExpo,ExamenTrigo,ExamenLogar,ExamenTipDeriv,ExamenRegDer,ExamenFinal,ExamenFinalDerivada) VALUES('" + E + "','" + N.PreExamen + "','0','0','0','0','0','0','0','0','0')";
            //string Query = "INSERT INTO Estudiante (Nombre,Apellido,CI,Telefono,Correo,Usuario,Contraseña) VALUES ('" + E.Nombre + "','" + E.Apellido + "','" + E.CI + "','" + E.Telefono + "','" + E.Correo + "','" + E.Usuario + "','" + E.Contraseña + "')";
            SqlCommand sql = new SqlCommand(Query, connection);
            sql.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("NOTA GUARDADA");
        }
        public void ActualizarDatosParcial(E_Parcial N, string E)
        {
            connection.Open();

            string Query = "UPDATE NotasParcial SET Tema1 = '" + (decimal)N.Tema1 + "', Tema2 = '" + (decimal)N.Tema2 + "' , Tema3 = '" + (decimal)N.Tema3 + "',Tema4 ='" + (decimal)N.Tema4+ "',Tema5 ='" + (decimal)N.Tema5 + "',Tema6 ='" + (decimal)N.Tema6 + "',Tema7 ='" + (decimal)N.Tema7 + "',ExamenFinal ='" + (decimal)N.ExamenFinal + "',Actualizacion = SYSDATETIME() WHERE IDU = '" + E + "'";
            SqlCommand sql = new SqlCommand(Query, connection);
            sql.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("NOTA ACTUALIZADO");

        }

        public bool LoginNotasParcial(E_Estudiante E, E_Parcial N)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from NotasParcial where IDU = '" + E.IDE + "'");
            //SqlCommand cmd = new SqlCommand("Select * From Usuario Where ( usuar ='" + E.User + "' and Contraseña ='" + E.Pass + "')");
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@IDU", E.IDE);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {

                while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                {
                    N.IDNpar = (int)reader[0];
                    N.IDUsua = (int)reader[1];
                    N.Tema1 = (decimal)reader[2];
                    N.Tema2 = (decimal)reader[3];
                    N.Tema3 = (decimal)reader[4];
                    N.Tema4 = (decimal)reader[5];
                    N.Tema5 = (decimal)reader[6];
                    N.Tema6 = (decimal)reader[7];
                    N.Tema7 = (decimal)reader[8];
                    N.ExamenFinal = (decimal)reader[9];
                    
                }

                return true;
            }
            else
                return false;
            connection.Close();
        }
    }
}
