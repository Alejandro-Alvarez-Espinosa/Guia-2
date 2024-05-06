using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una lista para almacenar empleados
            List<Empleado> listaEmpleado = new List<Empleado>();

            //Agregar empleados de ejemplo a la lista
            listaEmpleado.Add(new Empleado("Juan", 101, 30000));
            listaEmpleado.Add(new Empleado("María", 102, 35000));
            listaEmpleado.Add(new Empleado("Pedro", 103, 32000, false));

            //Mostrar los detalles de cada empleado en la lista
            foreach (var empleado in listaEmpleado)
            {
                empleado.MostrarDetalles();
            }
            //Cambiar el estado de un empleado por su numero de empleado 
            int numeroEmpleadoCambiarEstado = 103;//Numero de empleado a cambiar estado 
            Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleado, numeroEmpleadoCambiarEstado);


            if (empleadoCambiarEstado != null)
            {

                //Cambiar el estado a activo (1) o inactivo (0)
                empleadoCambiarEstado.CambiarEstado(1); //Cambiar a activo
                empleadoCambiarEstado.MostrarDetalles(); //Mostrar detalles actualizados 

            }
            else
            {

                Console.WriteLine($"Empleado con número {numeroEmpleadoCambiarEstado} no encontrado.");
            }

            //Aumentar el salario de un empleado por su número de empleado y porcentaje de aumento
            int numeroEmpleadoAumentarSalario = 103; // Número de empleado a aumentar el salario
            decimal porcentajeAumento = 15; // Porcentaje de aumento

            Empleado empleadoAumentarSalario = BuscarEmpleado(listaEmpleado, numeroEmpleadoAumentarSalario);

            if (empleadoAumentarSalario != null)
            {
                empleadoAumentarSalario.AumentarSalario(porcentajeAumento);
                empleadoAumentarSalario.MostrarDetalles(); // Mostrar detalles con el nuevo salario
            }
            else
            {
                Console.WriteLine($"Empleado con número {numeroEmpleadoAumentarSalario} no encontrado.");
            }

        }

        //Metodo para buscar un empleado por su numero de empleado
        static Empleado BuscarEmpleado(List<Empleado> empleados, int numeroEmpleado)
        {
            foreach (var empleado in empleados)
            {
                if (empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
                {
                    return empleado;
                }
            }

            return null; //Retorna null si no se encuentra ningun empleado con ese numero
        }
    }
}

