using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesoDatos;
using datos;

namespace logica
{
    public class logicaEmpleado
    {
        datosEmpleado de = new datosEmpleado();

        public List<Empleado> seleccionarEmpleados()
        {
            return de.seleccionarEmpleados();
        }
        public Empleado seleccionarEmpleado(string id)
        {
            return de.seleccionarEmpleado(id);
        }

        #region metodos de accion

        public string insertarEmp(Empleado nuevoEmp)
        {
            return de.insertarEmp(nuevoEmp);
        }

        public bool actualizarEmp(Empleado empModificado)
        {
            return de.actualizarEmp(empModificado);
        }

        public bool eliminarEmp(string empEliminado)
        {
            return de.eliminarEmp(empEliminado);
        }
        #endregion
    }
}
