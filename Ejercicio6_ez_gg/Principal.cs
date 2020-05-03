using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio6_ez_gg
{
    class Principal
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudianteslista = new List<Estudiante>();
            Estudiante es = new Estudiante();
            List<Empleado> empleadolista = new List<Empleado>();
            Empleado em = new Empleado();
            string r = "";
            string r2 = "";
            while (r !="F") {
                try
                {
                    Console.WriteLine("\n BIENVENIDO, SELECCIONE UNA OPCION DEL MENU:");
                    Console.WriteLine("\nA)Ingresar datos" + "\nB)Buscar estudiante " + "\nC)Buscar empleados " + "\nD)Empleados Ordenados por Sueldo" + "\nE)Estudiantes Ordenados por CUM" + "\nF)Salir");
                    r = Console.ReadLine().ToUpper();
                    Console.Clear();
                    switch (r)
                    {
                        case "A":
                            Console.WriteLine(" HA ELEGIDO LA OPCION DE INGRESAR DATOS..");
                            Console.WriteLine("\n INGRESAR DATOS DE...");
                            Console.WriteLine("\nA)ESTUDIANTE \nB)EMPLEADO \n \n*Cualquier Tecla Para Salir ");
                            r2 = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (r2) {
                                case "A":
                                    //Estudiante
                                    Console.WriteLine("Asigne nombre del Estudiante");
                                    es.Nombres = Console.ReadLine();
                                    Console.WriteLine("Asigne apellido del Estudiante");
                                    es.apellidos = Console.ReadLine();
                                    Console.WriteLine("Asigne el sexo");
                                    es.sexo = Console.ReadLine();
                                    Console.WriteLine("Asigne la fecha de nacimiento: ");
                                    es.fecha_nacimiento = Console.ReadLine();
                                    Console.WriteLine("Asigne el DUI");
                                    es.dui = Convert.ToInt32( Console.ReadLine());
                                    Console.WriteLine("Asigne telefono");
                                    es.telefono = Console.ReadLine();
                                    Console.WriteLine("Asigne numero de carnet");
                                    es.Num_carnet = Console.ReadLine();
                                    Console.WriteLine("Asigne nivel de estudions");
                                    es.nivel_de_estudios = Console.ReadLine();
                                    Console.WriteLine("Asigne nombre de la Universidad");
                                    es.nombre_de_la_universidad = Console.ReadLine();
                                    Console.WriteLine("Asigne su Carrera");
                                    es.carrera = Console.ReadLine();
                                    Console.WriteLine("Asigne cantidad de materias inscritas");
                                    es.Materias_inscritas = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Asigne las nota");
                                    es.notas = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Asigne el CUM");
                                    es.CUM = Convert.ToDouble(Console.ReadLine());
                                    //Agregando partes a las listas
                                    estudianteslista.Add(new Estudiante()
                                    {
                                        Nombres = es.Nombres,
                                        apellidos = es.apellidos,
                                        sexo = es.sexo,
                                        fecha_nacimiento = es.fecha_nacimiento,
                                        dui = es.dui,
                                        telefono = es.telefono,
                                        Num_carnet = es.Num_carnet,
                                        nivel_de_estudios = es.nivel_de_estudios,
                                        nombre_de_la_universidad = es.nombre_de_la_universidad,
                                        carrera = es.carrera,
                                        Materias_inscritas = es.Materias_inscritas,
                                        notas = es.notas,
                                        CUM = es.CUM
                                    });
                                    Console.Clear();
                                    break;
                                case "B":
                                    //Empleado
                                    Console.WriteLine("Asigne nombre del Empleado");
                                    em.Nombres = Console.ReadLine();
                                    Console.WriteLine("ASigne apellido del Empleado");
                                    em.apellidos = Console.ReadLine();
                                    Console.WriteLine("Asigne el sexo");
                                    em.sexo = Console.ReadLine();
                                    Console.WriteLine("Asigne la fecha de nacimiento: ");
                                    em.fecha_nacimiento = Console.ReadLine();
                                    Console.WriteLine("Asigne el DUI");
                                    em.dui = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Asigne telefono");
                                    em.telefono = Console.ReadLine();
                                    Console.WriteLine("Asigne el cargo");
                                    em.cargo = Console.ReadLine();
                                    Console.WriteLine("Asigne la fecha de ingreso");
                                    em.fecha_De_ingreso = Console.ReadLine();
                                    Console.WriteLine("Asigne el departamento");
                                    em.departamento = Console.ReadLine();
                                    Console.WriteLine("Asigne Nº de Carnet ");
                                    em.No_carnet = Console.ReadLine();
                                    Console.WriteLine("Asigne sueldo ");
                                    em.sueldo = Convert.ToInt32(Console.ReadLine());
                                    empleadolista.Add(new Empleado()
                                    {
                                        Nombres = em.Nombres,
                                        apellidos = em.apellidos,
                                        sexo = em.sexo,
                                        fecha_nacimiento = em.fecha_nacimiento,
                                        dui = em.dui,
                                        telefono = em.telefono,
                                        cargo = em.cargo,
                                        fecha_De_ingreso = em.fecha_De_ingreso,
                                        departamento = em.departamento,
                                        No_carnet = em.No_carnet,
                                        sueldo = em.sueldo
                                    });
                                    Console.Clear();
                                    break;
                                default:
                                    throw new Exception();  
                            }
                            break;
                        case "B":
                            int searchES=1;
                            bool found=false;
                            Console.WriteLine(" HA ELEGIDO LA OPCION DE BUSCAR ESTUDIANTE..");
                            while (searchES != 0)
                            {
                                Console.WriteLine(" INGRESE SU DUI...");
                                Console.WriteLine(" INGRESE 0 Para Volver al Menu...");
                                searchES = Convert.ToInt32(Console.ReadLine());
                                if (searchES != 0)
                                {

                                    // Escribe las partes en la lista. Esto llamará al método ToString anuladoen la clase Estudiante. 
                                    foreach (Estudiante estudiante in estudianteslista)
                                    { 
                                        //Condicionando la busquedad, que solo imprima cuando el num de dui coincida con algun num de dui agregado.
                                        if (estudiante.dui == searchES) {
                                            Console.WriteLine(estudiante);
                                            found =true ;
                                        }
                                    }
                                    if (found == false) {
                                        //Si la busquedad no coincide, reiniciar busquedad.
                                        Console.Clear();
                                        Console.WriteLine("\n El Estudiante No Se Enceuntra");
                                        Console.WriteLine(" Intente de Nuevo\n");
                                    }
                                    /*for(int i = 0;i<estudianteslista.Count;i++) {
                                        Estudiante e1 = estudianteslista[i];
                                    }*/
                                }
                                if (found == true)
                                {
                                    Console.Write("Presione Enter Para Continuar"); Console.ReadKey();
                                    Console.Clear();
                                    searchES = 0;
                                }
                            }
                            Console.Clear();
                            break;
                        case "C":
                            int searchEM = 1;
                            bool foundEM = false;
                            Console.WriteLine(" HA ELEGIDO LA OPCION DE BUSCAR EMPLEADO..");
                            while (searchEM != 0)
                            {
                                Console.WriteLine(" INGRESE SU DUI...");
                                Console.WriteLine(" INGRESE 0 Para Volver al Menu...");
                                searchEM = Convert.ToInt32(Console.ReadLine());
                                if (searchEM != 0)
                                {
                                    // Escribe las partes en la lista. Esto llamará al método ToString anuladoen la clase Empleado. 
                                    foreach (Empleado empleado in empleadolista)
                                    {
                                        if (empleado.dui == searchEM)
                                        {
                                            Console.WriteLine(empleado);
                                            foundEM = true;
                                        }
                                    }
                                    if (foundEM == false)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n El Empleado No Se Enceuntra");
                                        Console.WriteLine(" Intente de Nuevo\n");
                                    }
                                }
                                if (foundEM == true)
                                {
                                    Console.Write("Presione Enter Para Continuar"); Console.ReadKey();
                                    Console.Clear();
                                    searchEM = 0;
                                }
                            }
                            Console.Clear();
                            break;
                        case "D":
                            Console.WriteLine(" ===Empleados Ordenados por Sueldo===\n");
                            //La funcion list.sort() sirve para ordenar objetos dentro de la lista. condicionado anteriormente en la clase Empleado
                            empleadolista.Sort();//Lamara el metodo CompareTo de la clase Empleado
                            foreach (Empleado i in empleadolista)
                            {    
                                    Console.WriteLine(i); 
                            }
                            Console.Write("Presione Enter Para Continuar"); Console.ReadKey();
                            Console.Clear();
                            break;
                        case "E":
                            Console.WriteLine(" ===Estudiantes Ordenados Por Cum===\n");
                            estudianteslista.Sort();
                            foreach (Estudiante i in estudianteslista)
                            { 
                                    Console.WriteLine(i);
                            }
                            Console.Write("Presione Enter Para Continuar"); Console.ReadKey();
                            Console.Clear();
                            break;
                        case "F":
                            Console.WriteLine(" Saliendo..");
                            
                            break;
                        default:
                            Console.WriteLine(" Ha Elegido Una Opcion Invalida..");
                            r = "";
                            break;
                    }
                }
                catch (Exception e)
                {
                    r = "";
                }
            }
        }
    }
}
