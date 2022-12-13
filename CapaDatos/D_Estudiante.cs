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
    public class D_Estudiante
    {
        //Cadena de conexion a la Base de Datos
        public readonly SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaconexion"].ConnectionString);
        
        public DataTable MostrarRegistros()
        {
            DataTable resultado = new DataTable();
            SqlCommand command = new SqlCommand("sp_mostrar_usuario", connection)//select * from estudiantes;
            {
                CommandType = CommandType.StoredProcedure
            };
            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(resultado);

            return resultado;
        }
        
        public bool Login(E_Estudiante E)
        {
            connection.Open();
            
                    SqlCommand cmd = new SqlCommand ("Select* From Usuario, Cargo Where( Usuario.usuar ='" + E.User + "' and Usuario.Contraseña ='" + E.Pass + "' )");
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@Usuario", E.User);
                    cmd.Parameters.AddWithValue("@Contraseña", E.Pass);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())//Obtenemos los datos de la columna y asignamos a los campos de la Cache de Usuario
                        {
                            E.IDE = reader.GetInt32(0);
                            E.IDCargo = reader.GetInt32(1);
                            E.Nombre = reader.GetString(2);
                            E.Apellido = reader.GetString(3);
                            E.CI = reader.GetString(4);
                            E.Telefono = reader.GetString(5);
                            E.Correo = reader.GetString(6);
                            E.Usuario = reader.GetString(7);
                            E.Contraseña = reader.GetString(8);
                            E.Creacion = reader.GetDataTypeName(9);
                            E.Actualizacion = reader.GetDataTypeName(10);
                        }
                        return true;
                    }
                    else
                        return false;
        }
        public void Crear(E_Estudiante E)
        {
            connection.Open();

            string Query = "INSERT INTO Usuario(IDC, Nombre, Apellido, CI, Telefono, Correo, usuar, Contraseña, CreacionDatos, Actualizacion) VALUES ('1','" + E.Nombre + "','" + E.Apellido + "','" + E.CI + "','" + E.Telefono + "','" + E.Correo + "','" + E.Usuario + "','" + E.Contraseña + "',SYSDATETIME(),SYSDATETIME())";
            SqlCommand sql = new SqlCommand(Query, connection);
            sql.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("REGISTRO GUARDADO");
        }
        public void CrearADM(E_Estudiante E)
        {
            connection.Open();

            string Query = "INSERT INTO Usuario(IDC, Nombre, Apellido, CI, Telefono, Correo, usuar, Contraseña, CreacionDatos, Actualizacion) VALUES ('" + E.IDCargo + "','" + E.Nombre + "','" + E.Apellido + "','" + E.CI + "','" + E.Telefono + "','" + E.Correo + "','" + E.Usuario + "','" + E.Contraseña + "',SYSDATETIME(),SYSDATETIME())";
            SqlCommand sql = new SqlCommand(Query, connection);
            sql.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("REGISTRO GUARDADO");
        }

        public DataSet Listar()
        {
            connection.Open();
            string Query = "SELECT TOP 1000 * FROM Usuario";
            SqlDataAdapter adaptar;
            DataSet datos = new DataSet();  
            adaptar = new SqlDataAdapter(Query, connection);
            adaptar.Fill(datos, "tbl");
            connection.Close();
            return datos;
        }

        public void Actualizar(E_Estudiante E)
        {
            connection.Open();
             
            string Query = "UPDATE Usuario SET IDC = '" + E.IDCargo+"', Nombre = '" + E.Nombre + "' ,Apellido = '" + E.Apellido + "',CI ='" + E.CI + "',Telefono ='" + E.Telefono + "',Correo ='" + E.Correo + "',usuar ='" + E.Usuario + "',Contraseña ='" + E.Contraseña + "',Actualizacion = SYSDATETIME() WHERE IDU = " + E.IDE+"";
            SqlCommand sql = new SqlCommand(Query, connection);
            sql.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("REGISTRO ACTUALIZADO");
        }
        //public void ListarEstudiantes(E_Estudiante E)
        //{
        //    connection.Open();

        //    string Query = "select DISTINCT U.Nombre,U.Apellido,N.PreExamen,N.ExamenTipFun,N.ExamenDominio,N.ExamenExpo,N.ExamenTrigo,N.ExamenLogar,N.ExamenTipDeriv,N.ExamenRegDer,N.ExamenFinal,N.ExamenFinalDerivada from Usuario U,Notas N,NotasParcial NP where U.IDU =N." + E.IDE + " ";
        //    SqlCommand sql = new SqlCommand(Query, connection);
        //    sql.ExecuteNonQuery();
        //    connection.Close();
        //    MessageBox.Show("REGISTRO ACTUALIZADO");
        //}
        public DataSet ListarEstudiantes()
        {
            connection.Open();
            string Query = "select DISTINCT U.IDU, U.Nombre,U.Apellido,N.PreExamen as PreExamen,N.ExamenTipFun as Tipos_Funciones,N.ExamenDominio as Dominio,N.ExamenExpo as Exponencial,N.ExamenTrigo as Trigonometrico,N.ExamenLogar as Logaritmos,N.ExamenTipDeriv as TiposDerivadas,N.ExamenRegDer as ReglaCadena,N.ExamenFinal as Funciones,N.ExamenFinalDerivada as Derivadas from Usuario U,Notas N,NotasParcial NP where U.IDU =N.IDU ";
            SqlDataAdapter adaptar;
            DataSet datos = new DataSet();
            adaptar = new SqlDataAdapter(Query, connection);
            adaptar.Fill(datos, "tbl");
            connection.Close();
            return datos;
        }
        public DataSet ListarEstudiantesParcial()
        {
            connection.Open();
            string Query = "SELECT DISTINCT U.IDU, U.Apellido, U.Nombre,N.Tema1 as Parabola,N.Tema2 as Hiperbola,N.Tema3 as Elipse,N.Tema4 as Numeros_Reales,N.Tema5 as Desigualdad_E_Inecuaciones,N.Tema6 as Limite_Continuidad,N.Tema7 as Calculo_Empleado,N.ExamenFinal as Final from Usuario U , NotasParcial N where N.IDU = U.IDU ";
            SqlDataAdapter adaptar;
            DataSet datos = new DataSet();
            adaptar = new SqlDataAdapter(Query, connection);
            adaptar.Fill(datos, "tbl");
            connection.Close();
            return datos;
        }
        public void Eliminar(E_Estudiante E)
        {
            connection.Open();
            string Query = "DELETE Usuario WHERE IDU = " + E.IDE + "";
            SqlCommand sql = new SqlCommand(Query, connection);
            sql.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("REGISTRO ELIMINADO");
        }
    }
}
