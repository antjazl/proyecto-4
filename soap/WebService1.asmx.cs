using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using accesoDatos;
using logica;

namespace soap
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        logicaEmpleado de = new logicaEmpleado();

        [WebMethod]
        public List<Empleado> seleccionarEmpleados()
        {
            return de.seleccionarEmpleados();
        }

        [WebMethod]
        public Empleado seleccionarEmpleado(string id)
        {
            return de.seleccionarEmpleado(id);
        }

        #region metodos de accion
        [WebMethod]
        public string insertarEmp(Empleado nuevoEmp)
        {
            return de.insertarEmp(nuevoEmp);
        }
        [WebMethod]
        public bool actualizarEmp(Empleado empModificado)
        {
            return de.actualizarEmp(empModificado);
        }
        [WebMethod]
        public bool eliminarEmp(string empEliminado)
        {
            return de.eliminarEmp(empEliminado);
        }
        #endregion
        
    }
}
