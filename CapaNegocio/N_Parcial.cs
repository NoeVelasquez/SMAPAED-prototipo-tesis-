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
    public class N_Parcial
    {
        // Instancia
        private readonly D_Parcial nota = new D_Parcial();

        public bool LoginNotasParcial(E_Estudiante E, E_Parcial Nt)
        {
            //return nota.LoginNotas(E, Nt);
            return nota.LoginParcial(E, Nt);
        }
        public void CrearNotaParcial(E_Parcial N, string E)
        {
            nota.CrearParcial(N, E);
            //nota.CrearNota(N, E);
        }
        public void ActulizaNotaParcial(E_Parcial N, string Es)
        {
            nota.ActualizarDatosParcial(N, Es);
            //nota.ActualizarNtipoFuncion(N, Es);
        }

    }
}
