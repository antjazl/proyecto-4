using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using accesoDatos;
using logica;

namespace rest.Controllers
{
    public class empleadoController : ApiController
    {
        logicaEmpleado le = new logicaEmpleado();

        // GET: api/empleado
        public List<Empleado> Get()
        {
            return le.seleccionarEmpleados();
        }

        // GET: api/empleado/5
        public Empleado Get(string id)
        {
            return le.seleccionarEmpleado(id);
        }

        // POST: api/empleado
        public string Post([FromBody]Empleado nuevoEmpleado)
        {
            return le.insertarEmp(nuevoEmpleado);

        }

        // PUT: api/empleado/5
        public bool Put(string id, [FromBody]Empleado empleadoModificado)
        {
            return le.actualizarEmp(empleadoModificado);
        }

        // DELETE: api/empleado/5
        public bool Delete(string id)
        {
            return le.eliminarEmp(id);
        }
    }
}
