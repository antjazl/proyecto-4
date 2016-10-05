using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesoDatos;

namespace datos
{
    public class datosEmpleado
    {
        HospitalEntities contexto;

        public datosEmpleado()
        {
            contexto = new HospitalEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List<Empleado> seleccionarEmpleados()
        {
            var res = from emp in contexto.Empleado
                  select emp;

            return res.ToList();
        }
        public Empleado seleccionarEmpleado(string id)
        {
            var res = from emp in contexto.Empleado
                      where emp.idEmpleado == id
                      select emp;

            return res.SingleOrDefault();
        }

        #region metodos de accion

        public string insertarEmp(Empleado nuevoEmp)
        {
            contexto.Empleado.Add(nuevoEmp);
            contexto.SaveChanges();
            return nuevoEmp.idEmpleado;
        }

        public bool actualizarEmp(Empleado empModificado)
        {
            Empleado emp = contexto.Empleado.Where(e => e.idEmpleado == empModificado.idEmpleado).SingleOrDefault();
            if (emp != null)
            {
                emp.nombre = empModificado.nombre;
                
                contexto.SaveChanges();
                return true;
            }
            else return false;
        }

        public bool eliminarEmp(string empEliminado)
        {
            Empleado emp = contexto.Empleado.Where(e => e.idEmpleado == empEliminado).SingleOrDefault();
            if (emp != null)
            {
                contexto.Empleado.Remove(emp);
                contexto.SaveChanges();
                return true;
            }
            else return false;
        }
        #endregion
    }
}
