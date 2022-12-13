using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Estudiante
    {
        public String User { get; set; }
        public String Pass { get; set; }
        // Datos
        public int IDE { get; set; }
        public int IDCargo { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String CI { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public String Usuario { get; set; }
        public String Contraseña { get; set; }

        public String Creacion { get; set; }
        public String Actualizacion { get; set; }
    }
}