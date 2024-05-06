using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_2
{
    internal class Empleado
    {
        //Variable miembro de la clase empleado 
        private string Nombre;
        private int NumeroEmpleado;
        private decimal Salario;
        private bool Activo; //Estado del empleado (Activo o Inactivo)


        public Empleado(string nombre, int numeroEmpleado, decimal salario, bool activo = true)
        {
            this.Nombre = nombre;
            this.NumeroEmpleado = numeroEmpleado;
            this.Salario = salario;
            this.Activo = activo;
        }

        //Metodo para mostrar los detalles del empleado
        public void MostrarDetalles()
        {
            string estado = (Activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {Nombre}, Número de Empleado: {NumeroEmpleado}, Salario: {Salario:C}, Estado: {estado}");
        }
        //Metodo para obtener el numero de un empleado
        public int ObtenerNumeroEmpleado()
        {
            return this.NumeroEmpleado;
        
        }

        //Metodo para cambiar el estado de un empleado
        public void CambiarEstado(int nuevoEstado) 
        {
            if (nuevoEstado == 1)
            {
                Activo = true; //Activar Empleado
                Console.WriteLine("Empleado activado");
            }
            else if (nuevoEstado == 0)
            {
                Activo = false; //Desactivar Empleado
                Console.WriteLine("Empleado desactivado");
            }
            else
            {
                Console.WriteLine("Estado no valido ");

            }
        }

        //Método para aumentar el salario en un porcentaje determinado
        public void AumentarSalario(decimal porcentajeAumento)
        {
            if (porcentajeAumento <= 0)
            {
                throw new Exception("El porcentaje de aumento debe ser un valor positivo");
            }

            decimal nuevoSalario = Salario + (Salario * porcentajeAumento / 100);
            Salario = nuevoSalario;
            Console.WriteLine($"El salario de {Nombre} ha sido aumentado a {Salario:C}");
        }

    }
}