using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_api_desktop
{
    public partial class Cliente
    {
        public int ClieId { get; set; }
        public string ClieIdtipoidentificacion { get; set; }
        public string ClieIdentificacion { get; set; }
        public string ClieNombre { get; set; }
        public string ClieApellidos { get; set; }
        public string ClieDireccion { get; set; }
        public string ClieIdsexo { get; set; }
        public string ClieTelefono { get; set; }
        public string ClieBarrio { get; set; }
        public string ClieLongitud { get; set; }
        public string ClieLatitud { get; set; }
        public string ClieAltura { get; set; }
        public string ClieClave { get; set; }

        //public virtual ICollection<Cuentascliente> Cuentascliente { get; set; }
        //public virtual ICollection<Ordenes> Ordenes { get; set; }
    }
}
