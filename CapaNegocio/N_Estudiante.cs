using System;
using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace CapaNegocio
{
    public class N_Estudiante
    {
        // Instancia
        private readonly D_Estudiante estudiantes = new D_Estudiante();

        //METODO
        public DataTable MostrarDatos()
        {
            return estudiantes.MostrarRegistros();
        }

        public bool LoginUser(E_Estudiante E)
        {
            return estudiantes.Login(E);
        }

        public bool ValidarDatos(E_Estudiante Estud)
        {
            bool Resultado = true;
            if(Estud.Nombre == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Nombre es Obligatorio");
            }

            if (Estud.Apellido == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Apellido es Obligatorio");
            }

            if (Estud.CI == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Carnet de Identidad es Obligatorio");
            }

            if (Estud.Telefono == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Telefono es Obligatorio");
            }

            if (Estud.Correo == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Correo electronico es Obligatorio");
            }

            if (Estud.Usuario == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Nombre de Usuario es Obligatorio");
            }

            if (Estud.Contraseña == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("La Contraseña es Obligatoria");
            }

            return Resultado;
        }

        public bool ValidarDatosADM(E_Estudiante Estud)
        {
            bool Resultado = true;
            if (Estud.IDCargo == 0)
            {
                Resultado = false;
                MessageBox.Show("El Cargo debe cambiar");
            }

            if (Estud.Nombre == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Nombre es Obligatorio");
            }

            if (Estud.Apellido == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Apellido es Obligatorio");
            }

            if (Estud.CI == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Carnet de Identidad es Obligatorio");
            }

            if (Estud.Telefono == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Telefono es Obligatorio");
            }

            if (Estud.Correo == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Correo electronico es Obligatorio");
            }

            if (Estud.Usuario == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Nombre de Usuario es Obligatorio");
            }

            if (Estud.Contraseña == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("La Contraseña es Obligatoria");
            }

            return Resultado;
        }

        public void CrearEstudiante(E_Estudiante E)
        {
            estudiantes.Crear(E);
        }
        public void CrearEstudianteADM(E_Estudiante E)
        {
            estudiantes.CrearADM(E);
        }
        public DataSet ListarEstudiante()
        {
            return estudiantes.Listar();
        }
        public DataSet ListarEstudianteNotas()
        {
            return estudiantes.ListarEstudiantes();
        }
        public DataSet ListarEstudianteNotasParcial()
        {
            return estudiantes.ListarEstudiantesParcial();
        }
        public void ActualizarEstudiante(E_Estudiante E)
        {
            estudiantes.Actualizar(E);
        }
        public void EliminarEstudiante(E_Estudiante E)
        {
            estudiantes.Eliminar(E);
        }
        // Formulario de Menu de Funciones
        
    }
}
