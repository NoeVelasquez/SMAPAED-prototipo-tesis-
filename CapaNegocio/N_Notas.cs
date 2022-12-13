using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{ 
    public class N_Notas
    {// Instancia
        private readonly D_Notas nota = new D_Notas();
       
        public DataSet ListarNotas()
        {
            return nota.CargarNota();
        }
        public bool LoginNotas(E_Estudiante E,E_Notas Nt)
        {
            return nota.LoginNotas(E,Nt);
        }

        public bool LoginNotaTF(E_Estudiante E, E_Notas Nt)
        {
            return nota.LoginNotasTipfun(E, Nt);
        }
        
        public void CrearNota(E_Notas N,string E)
        {
            nota.CrearNota(N, E);
        }
        public void ActulizaNota(E_Notas N, string Es)
        {
            nota.ActualizarNtipoFuncion(N,Es);
        }
        /* public bool CargarListaNota(String E, E_Notas Nt)
         {
             return nota.ListarDatoNota(E,Nt);
         }
        */
        

    }
}
