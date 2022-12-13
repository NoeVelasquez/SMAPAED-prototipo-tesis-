using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class N_Pregunta
    {// Instancia
        private readonly D_Pregunta pregunta = new D_Pregunta();
        public bool ValidarPregunta(E_Preguntas Pre)
        {
            bool Resultado = true;
            /*if (Pre.Foto == null)
            {
                Resultado = false;
                MessageBox.Show("La foto de un ejercicio es obligatorio");
            }*/

            if (Pre.TITULO == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Titulo es Obligatorio");
            }

            if (Pre.OPA == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("La opcion A es Obligatoria");
            }

            if (Pre.OPB == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("La opcion B es Obligatoria");
            }

            if (Pre.OPC == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("La opcion C es Obligatoria");
            }

            if (Pre.OPD == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("La opcion D es Obligatoria");
            }

            if (Pre.CORRECTO == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("La opcion Correcta es Obligatoria y necesaria para validar las anteriores opciones");
            }

            return Resultado;
        }

        public void CrearPregunta(E_Preguntas P)
        {
            pregunta.Crear(P);
        }
        public void llamarFoto()
        {
            pregunta.obtener();
        }
        public DataSet ListarPregunta()
        {
            return pregunta.Listar();
        }
        public DataSet ListarPreguntaFD()
        {
            return pregunta.ListarFyD();
        }
        public void ActualizarPregunta(E_Preguntas P)
        {
            //pregunta.Actualizar(P);
        }


    }
}
