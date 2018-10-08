using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCGA.UI.WebSite.Constants
{
    public class Application
    {
        public const string Nombre = "Clínica Alejandría - Embarazos de Alto Riesgo";
        public const string NombreCorto = "Clínica Alejandría";
        public const int SeoDescriptionLength = 260;
        public const string Email = "contacto@clinicaalejandria.com.ar";
        public const string Telefono1 = "4737-5314";
        public const string Telefono2 = "4737-7555";

        public const string Direccion = "B. de Irigoyen 696";
        public const string Localidad = "Boulogne";
        public const string CodigoPostal = "1609";
        public const string Pais = "Argentina";


        public const double Latitud = -69.667308627965596;
        public const double Longitud = -34.49549933992794;

        public static string Url => HttpContext.Current.Request.Url.AbsoluteUri;
    }
}