using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace pantallaRest
{
    public class emple
    {
        public emple() { }

        public string idEmpleado{ get; set; }
        public string nombre { get; set; }
       



        public emple(string EmpleJson)
        {
            JObject jOEmple = JObject.Parse(EmpleJson);
            idEmpleado = (string)jOEmple["idEmpleado"];
            nombre = (String)jOEmple["nombre"];
            
        }
    }
}