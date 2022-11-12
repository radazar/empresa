using ProyectoViernes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoViernes.Controllers
{
    public static class ImprimirController
    {
        #region imprimir_empleados
        public static void Empleados(List<Empleados> ListEmpleados)
    {
            if (ListEmpleados.Count > 0)
            {
                foreach (var item in ListEmpleados)
                {
                    Console.WriteLine("Id :{0} Nombre :{1} :{2} Direccion :{3} Telefono :{4} fecha ingreso :{5} Id_Area:{6}",
                    item.Id,item.Nombre, item.Apellido, item.Direccion, item.Telefono, item.Fecha_Ingreso, item.Id_Area);
                }
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
        #endregion imprimir_empleados

        #region imprimir_areas
        public static void Areas(List<Areas> ListAreas)
    {
            if (ListAreas.Count > 0) {
                foreach (var item in ListAreas)
                {
                    Console.WriteLine("Id :{0} Nombre :{1} ", item.Id, item.Nombre);
                }
            }
            else
            {
                Console.WriteLine("[]");
            }
    }
        #endregion imprimir_areas

        #region imprimir_nomina
        public static void Nomina(List<Nomina> ListNomina)
    {
            if (ListNomina.Count > 0) {
                foreach (var item in ListNomina)
                {
                    Console.WriteLine("Id :{0} Fecha :{1} id empleado :{2} sueldo:{3}  dias:{4} basico:{5} extras:{6} devengado:{7} ",
                    item.Id, item.Fecha, item.id_Empleado, item.Sueldo, item.Dias, Math.Round(item.Basico,1) , item.Extras, Math.Round(item.Devengado,1) );
                }
            }
            else
            {
                Console.WriteLine("[]");
            }
    }
        #endregion imprimir_nomina
    }
}
