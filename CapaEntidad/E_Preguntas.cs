using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Preguntas
    {
        private int IDPreg;
        private string Titulo;
        private byte[] Foto;
        private string opA;
        private string opB;
        private string opC;
        private string opD;
        private string opCorrecto;
        private string FechaActualizacion;
        private int IDC_Fk;
        private string IDEx_Fk;
        //public int IDPreg { get; set; }
        //public string Titulo { get; set; }
        //public byte[] Foto { get; set; }
        //public string opA { get; set; }
        //public string opB { get; set; }
        //public string opC { get; set; }
        //public string opD { get; set; }
        //public string opCorrecto { get; set; }
        //public string FechaActualizacion { get; set; }
        //public int IDC_Fk { get; set; }
        //public string IDEx_Fk { get; set; }

        public int ID {get {return IDPreg;}set { IDPreg = value; } }
        public string TITULO { get { return Titulo; } set { Titulo = value; } }
        public byte[] FOTO  { get { return Foto; } set { Foto = value; } }
        //public byte[] FOTO  { get { return Foto; } set { Foto = value; } }
        public string OPA { get { return opA; } set { opA = value; } }
        public string OPB { get { return opB; } set { opB = value; } }
        public string OPC { get { return opC; } set { opC = value; } }
        public string OPD { get { return opD; } set { opD = value; } }
        public string CORRECTO { get { return opCorrecto; } set { opCorrecto = value; } }
        public string ACTUALIZA { get { return FechaActualizacion; } set { FechaActualizacion = value; } }
        public int IDC { get { return IDC_Fk; } set { IDC_Fk = value; } }
        public string IDE { get { return IDEx_Fk; } set { IDEx_Fk = value; } }

        public E_Preguntas()
        {
           IDPreg = ID;
           Titulo = TITULO;
           Foto= FOTO;
           opA= OPA;
           opB= OPB;
           opC= OPC;
           opD= OPD;
           opCorrecto= CORRECTO;
           FechaActualizacion= ACTUALIZA;
           IDC_Fk= IDC;
            IDEx_Fk= IDE;
    }

    }
}
