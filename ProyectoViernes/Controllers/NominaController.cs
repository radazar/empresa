using ProyectoViernes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoViernes.Controllers
{
    public class NominaController
    {
        #region crear_lista_nomina
        public NominaController()
        {
            _nomina = new List<Nomina>();
        }
        private List<Nomina> _nomina;
        public List<Nomina> Nomina { get { return _nomina; } }
        #endregion crear_lista_nomina

        #region llenar_lista_nomina
        public void LlenarLista()
        {
            Nomina.Clear();
            Nomina.Add(new Nomina()
            {
                Id = 1,
                Fecha = DateTime.Now,
                id_Empleado = 1,
                Sueldo = 525265,
                Dias = 30,
                Extras = 105000,
            });
            Nomina.Add(new Nomina()
            {
                Id = 2,
                Fecha = DateTime.Now,
                id_Empleado = 2,
                Sueldo = 860000,
                Dias = 28,
                Extras = 0,
            });
            Nomina.Add(new Nomina()
            {
                Id = 3,
                Fecha = DateTime.Now,
                id_Empleado = 3,
                Sueldo = 1250000,
                Dias = 30,
                Extras = 50000,
            });
        }
        #endregion llenar_lista_nomina

        #region mostrar_lista_nomina
        public void get()
        {
            List<Nomina> lista = new List<Nomina>();
            lista.AddRange(from o in Nomina select o);
            ImprimirController.Nomina(lista);
        }
        #endregion mostrar_lista_nomina

        #region mostrar_lista_nomina_x_id
        public void getbyId(int id)
        {
            List<Nomina> lista = new List<Nomina>();
            lista.AddRange(from o in Nomina where o.Id == id select o);
            if (lista.Count > 0)
            {
                ImprimirController.Nomina(lista);
            }
            else
            {
                Console.WriteLine("El id {0} no existe en la base de datos", id);
            }
        }
        #endregion mostrar_lista_nomina_x_id

        #region crear_dato_lista_nomina
        public void post(DateTime fecha, int id_empleado, decimal sueldo,int dias, decimal extras)
        {
            int id = 0;
            id = Nomina.Count + 1;
            var element = Nomina.FirstOrDefault(i => i.Id == id);
            if (element != null)
            {
                element = Nomina[Nomina.Count - 1];
                Nomina.Add(new Nomina()
                {
                    Id = element.Id + 1,
                    Fecha = fecha,
                    id_Empleado = id_empleado,
                    Sueldo = sueldo,
                    Dias = dias,
                    Extras = extras
                }
                 );
                Console.WriteLine("Se creo el registro: {0}", element.Id + 1);
                getbyId(element.Id + 1);
            }
            else
            {
                Nomina.Add(new Nomina()
                {
                    Id = Nomina.Count + 1,
                    Fecha = fecha,
                    id_Empleado = id_empleado,
                    Sueldo = sueldo,
                    Dias = dias,
                    Extras = extras
                }
                 );
                Console.WriteLine("Se creo el registro: {0}", Nomina.Count);
                getbyId(Nomina.Count);
            }
        }
        #endregion crear_dato_lista_nomina

        #region editar_dato_lista_nomina
        #region validar_editar
        public void validarEdit(int id)
        {
            var element = Nomina.FirstOrDefault(i => i.Id == id);
            if (element != null)
            {
                DateTime fecha = DateTime.Now;
                int id_empleado,dias = 0;
                decimal sueldo,extras = 0;

                Console.WriteLine("Ingrese fecha AAAA/MM/DD: ");
                fecha = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese id empleado: ");
                id_empleado = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese sueldo: ");
                sueldo = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese dias laborados: ");
                dias = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese valor de extras: ");
                extras = decimal.Parse(Console.ReadLine());
                update(id,fecha,id_empleado,sueldo,dias,extras);
            }
            else
            {
                Console.WriteLine("El id {0} no existe", id);
            }
        }
        #endregion validar_editar
        public void update(int id, DateTime fecha, int id_empleado, decimal sueldo,int dias, decimal extras)
            {
                var ReplaceItem = new Nomina
                {
                    Id = id,
                    Fecha = fecha,
                    id_Empleado = id_empleado,
                    Sueldo = sueldo,
                    Dias = dias,
                    Extras = extras,
                };
                var element = Nomina.FirstOrDefault(i => i.Id == ReplaceItem.Id);
                Nomina.Remove(element);
                Nomina.Add(ReplaceItem);
                Console.WriteLine("Se edito el registro: {0}", id);
                getbyId(id);                
            }
        #endregion editar_dato_lista_nomina

        #region eliminar_dato_lista_nomina
        public void DeletexId(int id)
        {
            var element = Nomina.FirstOrDefault(i => i.Id == id);
            if (element != null)
            {
                Nomina.Remove(element);
                Console.WriteLine("Se elimino el registro: {0}", id);
            }
            else
            {
                Console.WriteLine("El id {0} no existe en la base de datos", id);
            }
            
        }
        #endregion eliminar_dato_lista_nomina
    }

}
   