using ProyectoViernes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoViernes.Controllers
{
    public class AreasController
    {
        #region crear_lista_areas
        public AreasController()
        {
            _areas = new List<Areas>();
        }
        private List<Areas> _areas;
        public List<Areas> Areas { get { return _areas; } }
        #endregion crear_lista_areas

        #region llenar_lista_areas
        public void LlenarLista()
        {
            Areas.Clear();
            Areas.Add(new Areas()
            {
                Id = 1,
                Nombre = "Administracion"
            });
            Areas.Add(new Areas()
            {
                Id = 2,
                Nombre = "Contabilidad"
            });
            Areas.Add(new Areas()
            {
                Id = 3,
                Nombre = "Sistemas"
            });
        }
        #endregion llenar_lista_areas

        #region mostrar_lista_areas
        public void get()
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas select o);
            ImprimirController.Areas(lista);
        }
        #endregion mostrar_lista_areas

        #region mostrar_lista_areas_x_id
        public void getbyId(int id)
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas where o.Id == id select o);
            if(lista.Count > 0)
            {
                ImprimirController.Areas(lista);
            }
            else
            {
                Console.WriteLine("El id {0} no existe en la base de datos", id);
            }
            
        }
        #endregion mostrar_lista_areas_x_id

        #region crear_dato_lista_areas
        public void post(string nombre)
        {
            int id = 0;
            id=Areas.Count+1;
            var element = Areas.FirstOrDefault(i => i.Id == id);
            if(element != null)
            {
                element= Areas[Areas.Count-1];
                Areas.Add(
                            new Areas()
                            {
                                Id = element.Id+1,
                                Nombre = nombre
                            }
                            );
                Console.WriteLine("Se creo el registro: {0}", element.Id + 1);
                getbyId(element.Id + 1);
            }
            else
            {
                Areas.Add(
                            new Areas()
                            {
                                Id = Areas.Count + 1,
                                Nombre = nombre
                            }
                            );
                Console.WriteLine("Se creo el registro: {0}", Areas.Count);
                getbyId(Areas.Count);
            }
        }
        #endregion crear_dato_lista_areas

        #region editar_dato_lista_areas
        #region validar_editar
        public void ValidarEdit(int id)
        {
            var element = Areas.FirstOrDefault(i => i.Id ==id);
            if (element != null)
            {
                string nombre = string.Empty;
                Console.WriteLine("Ingrese nombre");
                nombre = Console.ReadLine();
                update(id, nombre);
            }
            else
            {
                Console.WriteLine("El id {0} no existe en la base de datos", id);
            }
        }
        #endregion validar_editar
        public void update(int id, string nombre)
        {
            var ReplaceItem = new Areas
            {
                Id = id,
                Nombre = nombre
            };
            var element = Areas.FirstOrDefault(i => i.Id == ReplaceItem.Id);
                Areas.Remove(element);
                Areas.Add(ReplaceItem);
                Console.WriteLine("Se edito el registro: {0}", id);
                getbyId(id);           
        }
        #endregion editar_dato_lista_areas

        #region eliminar_dato_lista_areas
        public void DeletexId(int id)
        {
            var element = Areas.FirstOrDefault(i => i.Id == id);
            if (element != null)
            {
                Areas.Remove(element);
                Console.WriteLine("Se elimino el registro: {0}", id);
            }
            else
            {
                Console.WriteLine("El id {0} no existe en la base de datos", id);
            }
            
        }
        #endregion eliminar_dato_lista_areas
    }

}
   