/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDLINQPOO.Controllers
{
    public class productosController
    {
        #region controller
        public productosController()
        {
            _Productos = new List<Productos>();
        }
        private List<Productos> _Productos;
        public List<Productos> Productos { get { return _Productos; } }
        #endregion controller
        //Metodo Llenar Lista
        #region MostarLista
        public void LlenarLista()
        {
            Productos.Clear();
            Productos.Add(new Productos()
            {
                Id = 1,
                Nombre = "Tv Smart Tv LG 55'",
                Costo = 900000m,
                Existencias = 10,
                IdBodega = 1
            });
            Productos.Add(new Productos()
            {
                Id = 2,
                Nombre = "Portatil icore5 intel",
                Costo = 2300000m,
                Existencias = 0,
                IdBodega = 2
            });
            Productos.Add(new Productos()
            {
                Id = 3,
                Nombre = "Ipod",
                Costo = 100000m,
                Existencias = 5,
                IdBodega = 1
            });
            Productos.Add(new Productos()
            {
                Id = 4,
                Nombre = "Nevera no frooze Mabel",
                Costo = 1100000m,
                Existencias = 7,
                IdBodega = 1
            });
            Productos.Add(new Productos()
            {
                Id = 5,
                Nombre = "Lavadora 15 lbs mabel",
                Costo = 800000m,
                Existencias = 0,
                IdBodega = 1
            });

        }
        #endregion MostrarLista
        //get
        #region get
        public void get()
        {
            List<Productos> lista = new List<Productos>();
            lista.AddRange(from o in Productos orderby o.IdBodega ascending select o);
           if(lista.Count > 0)
            {
                ImprimirProductos.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("[]");
            }
           
        }
        #endregion get
        #region getexistencias
        public void getExistencias()
        {
            List<Productos> lista = new List<Productos>();
            lista.AddRange(from o in Productos where o.Existencias > 0  select o);
            ImprimirProductos.Imprimir(lista);
        }
        #endregion getexistencias
        //getxId
        #region getbyid
        public void getbyId(int id)
        {
            List<Productos> lista = new List<Productos>();
            lista.AddRange(from o in Productos where o.Id == id orderby o.Id descending select o);
            if (lista.Count > 0)
            {
                ImprimirProductos.Imprimir(lista);
            }
            else
            {
                Console.WriteLine("No exite el Id "+ id + " En nueestra BD");
            }
             
        }
        #endregion getbyid

        //post
        #region Post
        public void post(int id, string nombre, decimal costo,
            int existencias, int idbodega)
        {
            var verificarId = Productos.FirstOrDefault(i => i.Id == id);
      
            Productos.Add(new Productos()
            {
                Id = id,
                Nombre = nombre,
                Costo = costo,
                Existencias = existencias,
                IdBodega  = idbodega
            }) ;
            Console.WriteLine("201");
        }
        #endregion Post
        //put
        #region Update
        public void update(int id, string nombre, decimal costo,
            int existencias, int idbodega)
        {
            var ReplaceItem = new Productos
            {
                Id = id,
                Nombre = nombre,
                Costo = costo,
                Existencias = existencias,
                IdBodega = idbodega
            };
            var element = Productos.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            if (element != null)
            {
                Productos.Remove(element);
                Productos.Add(ReplaceItem);
                Console.WriteLine("Registro Actualizado con exito!");
            }
            else
            {
                Console.WriteLine("505");
            }
        }
        #endregion Update

        //delete
        #region delete
        public void DeletexId(int id)
        {
            //var EliminarItem = new Productos { Id = id };
            var element = Productos.FirstOrDefault(i => i.Id == id);
            if (element != null)
            {
                Productos.Remove(element);
                Console.WriteLine("Registro con Id: " + id + " fue eliminado");
            }
            else
            {
                Console.WriteLine("No hay elemento con ese Id");
            }
        }
        #endregion delete
    }

}

*/