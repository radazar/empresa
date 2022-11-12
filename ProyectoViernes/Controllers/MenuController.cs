using ProyectoViernes.Controllers;
using ProyectoViernes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoViernes.Controllers
{
    class MenuController
    {
        #region Instancias
        AreasController area = new AreasController();
        EmpleadosController empleados = new EmpleadosController();
        NominaController nomina = new NominaController();
        #endregion Instancias

        #region menu_inicial
        public void MenuInicial()
        {
            area.LlenarLista();
            nomina.LlenarLista();
            empleados.LlenarLista();

            int opc = 0;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Clear();
                Console.WriteLine("1. Menu Areas");
                Console.WriteLine("2. Menu Empleado");
                Console.WriteLine("3. Menu Nomina");
                Console.WriteLine("4. Salir");
                Console.Write("Digite Opción: ");
                try
                {
                    opc = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ingrese un dato valido");
                    Console.ReadKey();
                }
                switch (opc)
                {
                    case 1:
                        MenuAreas();
                        break;
                    case 2:
                        MenuEmpleado();
                        break;
                    case 3:
                        MenuNomina();
                        break;
                    case 4:
                        char confirmacion = 'F';
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Realmente quieres salir ?");
                        confirmacion = Convert.ToChar(Console.ReadLine());
                        if (confirmacion == 'S' || confirmacion == 's')
                        {
                            opc = 4;
                        }
                        else
                        {
                            opc = 5;
                        }
                        break;
                    default:
                        Console.WriteLine("Opción inexistente, escoje una válida");
                        break;
                }

            } while (opc != 4);
        }
        #endregion menu_inicial

        #region menu_areas
        public void MenuAreas()
        {

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            int opc = 0;
            string nombre = string.Empty;
            int id = 0;
            do
            {
                opc = 0;
                Console.Clear();
                Console.WriteLine("1. Crear Area");
                Console.WriteLine("2. Buscar Area");
                Console.WriteLine("3. Editar Area");
                Console.WriteLine("4. Eliminar Area");
                Console.WriteLine("5. Listar Area");
                Console.WriteLine("6. Salir");
                Console.Write("Digite Opción: ");
                try 
                {
                    opc = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ingrese un dato valido");
                    Console.ReadKey();
                }
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Ingrese Nombre area");
                        nombre = Console.ReadLine();
                        area.post(nombre);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese id del dato a buscar");
                        id = Convert.ToInt32(Console.ReadLine());
                        area.getbyId(id);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese id");
                        id = Convert.ToInt32(Console.ReadLine());
                        area.ValidarEdit(id);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese id");
                        id = Convert.ToInt32(Console.ReadLine());
                        area.DeletexId(id);
                        Console.ReadKey();
                        break;
                    case 5:
                        area.get();
                        Console.ReadKey();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Opción inexistente, escoje una válida");
                        break;
                }

                } while (opc != 6);
        }
        #endregion menu_areas

        #region menu_empleado
        public void MenuEmpleado()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            int opc = 0;
            string nombre, apellido, direccion, telefono = string.Empty;
            int id, id_area = 0;
            DateTime fecha_i = DateTime.Now;
            do
            {
                opc = 0;
                Console.Clear();
                Console.WriteLine("1. Crear Empleado");
                Console.WriteLine("2. Buscar Empleado");
                Console.WriteLine("3. Editar Empleado");
                Console.WriteLine("4. Eliminar Empleado");
                Console.WriteLine("5. Listar Empleado");
                Console.WriteLine("6. Salir");
                Console.Write("Digite Opción: ");
                try
                {
                    opc = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ingrese un dato valido");
                    Console.ReadKey();
                }
                switch (opc)
                {
                    case 1:
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
                        empleados.Insertar(nombre, apellido, direccion, telefono, fecha_i, id_area);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese id del dato a buscar");
                        id = Convert.ToInt32(Console.ReadLine());
                        empleados.MostrarxId(id);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese id");
                        id = Convert.ToInt32(Console.ReadLine());
                        empleados.validarEdit(id);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese id");
                        id = Convert.ToInt32(Console.ReadLine());
                        empleados.delete(id);
                        Console.ReadKey();
                        break;
                    case 5:
                        empleados.get();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    default:
                        Console.WriteLine("Opción inexistente, escoje una válida");
                        break;
                }

            } while (opc != 6);
        }
        #endregion menu_empleado

        #region menu_nomina
        public void MenuNomina()
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            int opc = 0;
            int id, dias, id_empleado = 0;
            decimal sueldo, extras = 0;
            DateTime fecha;
            do
            {
                opc = 0;
                Console.Clear();
                Console.WriteLine("1. Crear Nomina");
                Console.WriteLine("2. Buscar Nomina");
                Console.WriteLine("3. Editar Nomina");
                Console.WriteLine("4. Eliminar Nomina");
                Console.WriteLine("5. Listar Nomina");
                Console.WriteLine("6. Salir");
                Console.Write("Digite Opción: ");
                try
                {
                    opc = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ingrese un dato valido");
                    Console.ReadKey();
                }
                switch (opc)
                {
                    case 1:
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
                        nomina.post(fecha,id_empleado,sueldo,dias,extras);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese id del dato a buscar");
                        id = int.Parse(Console.ReadLine());
                        nomina.getbyId(id);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese id");
                        id = int.Parse(Console.ReadLine());
                        nomina.validarEdit(id);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese id");
                        id = int.Parse(Console.ReadLine());
                        nomina.DeletexId(id);
                        Console.ReadKey();
                        break;
                    case 5:
                        nomina.get();
                        Console.ReadKey();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Opción inexistente, escoje una válida");
                        break;
                }

            } while (opc != 6);
        }
        #endregion menu_nomina

    }
}