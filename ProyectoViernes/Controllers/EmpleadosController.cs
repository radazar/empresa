using ProyectoViernes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoViernes.Controllers
{

    public class EmpleadosController
    {
        #region crear_lista_empleados
        public EmpleadosController()
        {
            _empleados = new List<Empleados>();
        }
        private List<Empleados> _empleados;
        public List<Empleados> Empleados { get { return _empleados; } }
        #endregion crear_lista_empleados

        #region llenar_lista_empleados
        public void LlenarLista()
        {
            Empleados.Clear();
            Empleados.Add(new Empleados()
            {
                Id = 1,
                Nombre = "Javier",
                Apellido = "Gomez",
                Direccion = "Cll 8 #12-45",
                Telefono = "601-5870322",
                Fecha_Ingreso = DateTime.Now,
                Id_Area = 1
            });
            Empleados.Add(new Empleados()
            {
                Id = 2,
                Nombre = "Manuel",
                Apellido = "Vargas",
                Direccion = "Cll 10 #14-45",
                Telefono = "601-5896524",
                Fecha_Ingreso = DateTime.Now,
                Id_Area = 2
            });
            Empleados.Add(new Empleados()
            {
                Id = 3,
                Nombre = "Lina",
                Apellido = "Sanchez",
                Direccion = "Cra 28 #10-49",
                Telefono = "602-5412566",
                Fecha_Ingreso = DateTime.Now,
                Id_Area = 3
            });
            Empleados.Add(new Empleados()
            {
                Id = 4,
                Nombre = "Sofia",
                Apellido = "Rojas",
                Direccion = "Cra 7 #12-44",
                Telefono = "603-8698756",
                Fecha_Ingreso = DateTime.Now,
                Id_Area = 1
            });
            Empleados.Add(new Empleados()
            {
                Id = 5,
                Nombre = "Yulieth",
                Apellido = "Mellizo",
                Direccion = "Cll 45 #22-55",
                Telefono = "601-8495788",
                Fecha_Ingreso = DateTime.Now,
                Id_Area = 2
            });
        }
        #endregion llenar_lista_empleados

        #region mostrar_lista_empleados
        public void get()
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados select o);
            ImprimirController.Empleados(lista);
        }
        #endregion mostrar_lista_empleados

        #region mostrar_lista_empleados_x_id
        public void MostrarxId(int id)
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from x in Empleados where x.Id == id select x);
            if (lista.Count > 0)
            {
                ImprimirController.Empleados(lista);
            }
            else
            {
                Console.WriteLine("El id {0} no existe en la base de datos", id);
            }
        }
        #endregion mostrar_lista_empleados_x_id

        #region crear_dato_lista_empleados
        public void Insertar(string nom, string ape, string dir, string tel, DateTime fechai, int id_area)
        {
            int id = 0;
            id = Empleados.Count + 1;
            var element = Empleados.FirstOrDefault(i => i.Id == id);
            if (element != null)
            {
                element = Empleados[Empleados.Count - 1];
                Empleados.Add(new Empleados()
                {
                    Id = element.Id + 1,
                    Nombre = nom,
                    Apellido = ape,
                    Direccion = dir,
                    Telefono = tel,
                    Fecha_Ingreso = fechai,
                    Id_Area = id_area
                });
                Console.WriteLine("Se creo el registro: {0}", element.Id + 1);
                MostrarxId(element.Id + 1);
            }
            else
            {
                Empleados.Add(new Empleados()
                {
                    Id = Empleados.Count + 1,
                    Nombre = nom,
                    Apellido = ape,
                    Direccion = dir,
                    Telefono = tel,
                    Fecha_Ingreso = fechai,
                    Id_Area = id_area
                });
                Console.WriteLine("Se creo el registro: {0}", Empleados.Count);
                MostrarxId(Empleados.Count);
            }

        }
        #endregion crear_dato_lista_empleados

        #region editar_dato_lista_empleados
        #region validar_editar
        public void validarEdit(int id)
        {
            var element = Empleados.FirstOrDefault(y => y.Id == id);
            if (element != null)
            {
                string nombre, apellido, direccion, telefono = string.Empty;
                int id_area = 0;
                DateTime fecha_i = DateTime.Now;
                Console.WriteLine("Ingrese Nombre Empleado");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apeliido Empleado");
                apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Direccion");
                direccion = Console.ReadLine();
                Console.WriteLine("Ingrese Telefono");
                telefono = Console.ReadLine();
                Console.WriteLine("Ingrese Fecha Ingreso");
                fecha_i = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Id del area");
                id_area = Convert.ToInt32(Console.ReadLine());
                Update(id,nombre,apellido,direccion,telefono,fecha_i,id_area);
            }
            else
            {
                Console.WriteLine("El id {0} no existe en la base de datos", id);
            }

        }
        #endregion validar_editar
        
        public void Update(int id, string nom, string ape, string dir, string tel, DateTime fechai, int id_area)
        {
                Empleados.Where(x => x.Id == id).ToList()
                .ForEach(x => {
                    x.Nombre = nom;
                    x.Apellido = ape;
                    x.Direccion = dir;
                    x.Telefono = tel;
                    x.Fecha_Ingreso = fechai;
                    x.Id_Area = id_area;
                });
                Console.WriteLine("Se edito el registro: {0}", id);
                MostrarxId(id);
            
        }
        #endregion editar_dato_lista_empleados

        #region eliminar_dato_lista_empleados
        public void delete(int id)
        {
            var elemento = Empleados.FirstOrDefault(x => x.Id == id);
            if (elemento != null)
            {
                Empleados.Remove(elemento);
                Console.WriteLine("Se elimino el registro: {0}", id);
            }
            else
            {
                Console.WriteLine("El id {0} no existe en la base de datos", id);
            }
            
        }
        #endregion eliminar_dato_lista_empleados
    }



}