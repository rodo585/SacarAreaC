using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Area
{
    /// <summary>
    /// Descripción breve de AreaWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreaWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public decimal cuadrado(decimal n1)
        {
            SacarArea s = new SacarArea();
            s.numero1 = n1;
            return s.cuadrado(n1);
        }
        [WebMethod]
        public decimal triangulo(decimal n1, decimal n2)
        {
            SacarArea s = new SacarArea();
            s.numero1 = n1;
            s.numero2 = n2;
            return s.triangulo(n1,n2);
        }
        [WebMethod]
        public double circulo(double n3)
        {
            SacarArea s = new SacarArea();
            s.numero3 = n3;
            return s.circulo(n3);
        }
    }
}
