using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_api_desktop
{
    class Inmobiliaria
    {
        public List<Inmuebles> Inmuebles { get; set; }
    }

    public class Inmuebles
    {
        public string Administracion { get; set; }
        public string Alcobas { get; set; }
        public string AreaConstruida { get; set; }
        public string AreaLote { get; set; }
        public string Barrio { get; set; }
        public string Canon { get; set; }
        public string Ciudad { get; set; }
        public string Codigo_Inmueble { get; set; }
        public string Departamento { get; set; }
        public string MyProperty { get; set; }
        public int EdadInmueble { get; set; }
        public string Estrato { get; set; }
        public string Gestion { get; set; }
        public string IdInmobiliaria { get; set; }
        public string NombreInmo { get; set; }
        public string Tipo_Inmueble { get; set; }
        public string Venta { get; set; }
        public string Zona { get; set; }
        public string banios { get; set; }
        public string descripcionlarga { get; set; }
        public string fingreso { get; set; }
        public string foto1 { get; set; }
        public string foto360 { get; set; }
        public string garaje { get; set; }
        public string idEstado { get; set; }
        public string idGestion { get; set; }
        public string id_sede { get; set; }
        public string latitud { get; set; }
        public string logo { get; set; }
        public string longitud { get; set; }
        public string sede { get; set; }
        public string valorFiltro { get; set; }
        public string video360 { get; set; }
    }
}
