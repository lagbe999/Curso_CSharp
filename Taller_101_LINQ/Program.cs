using System;
using System.Collections.Generic;
using System.Linq;


namespace Taller_101_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taller C# - 101 - Manejo de LINQ");
            Console.WriteLine();
            Console.WriteLine("Ejercicio Filtro de Cargo en Coleccion Empleados USANDO LINQ");
            Console.WriteLine();

            ControlEmpresaEmpleados ObjCtrl = new ControlEmpresaEmpleados();

            Console.WriteLine("Que Cargo desea Filtrar ?: \n");

            string filtroCargo = Console.ReadLine();

            ObjCtrl.GetCargo(filtroCargo);

            Console.WriteLine("Ejercicio Filtro de Rango de Salarios en Coleccion Empleados USANDO LINQ");
            Console.WriteLine();

            Console.WriteLine("Filtrar Salario Desde?: ");

            double filtroSalario1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Filtrar Salario Hasta?: ");

            double filtroSalario2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Ejercicio Orden Alfabetico en Coleccion Empleados USANDO LINQ");
            Console.WriteLine();

            ObjCtrl.GetSalarios(filtroSalario1, filtroSalario2);

            ObjCtrl.ListaAlfabeticaEmpleados();

            Console.WriteLine();
            Console.WriteLine("Ejercicio Lista de Empleados de Una Empresa en Coleccion Empleados USANDO LINQ");
            Console.WriteLine();


            Console.WriteLine("Empresa Id: ");

            try
            {
                int filtroEmpresa = int.Parse(Console.ReadLine());
                ObjCtrl.GetEmpleadoxEmpresa(filtroEmpresa);
            }
            catch (Exception)
            {
                Console.WriteLine("Error : Introdujo un Id de Empresa Erroneo");
            }
        }
    }

    class ControlEmpresaEmpleados
    {
        public ControlEmpresaEmpleados()
        {
            listaEmpresas = new List<Empresa>();

            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Goole" });

            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Amazon" });

            listaEmpresas.Add(new Empresa { Id = 3, Nombre = "Netflix" });

            listaEmpresas.Add(new Empresa { Id = 4, Nombre = "Indra" });

            listaEmpresas.Add(new Empresa { Id = 5, Nombre = "Oracle" });

            listaEmpresas.Add(new Empresa { Id = 6, Nombre = "Microsoft" });

            listaEmpresas.Add(new Empresa { Id = 7, Nombre = "Yahoo" });

            listaEmpresas.Add(new Empresa { Id = 8, Nombre = "Tigo" });

            listaEmpresas.Add(new Empresa { Id = 9, Nombre = "Mac Store" });

            listaEmpresas.Add(new Empresa { Id = 10, Nombre = "Dell" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Rogelio Funnes Mori", Cargo = "Manager Help Desk", Salario = 2300.12, EmpresaId = 4 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Marcelo Neftali Gallardo Lucumi", Cargo = "Asistente Operaciones", Salario = 1300.24, EmpresaId = 3 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Jorge Mario Carrascal Beltran", Cargo = "Gerente Comercial", Salario = 1700.19, EmpresaId = 2 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Benito Alberto Juarez Motoa", Cargo = "Asistente de Planilla", Salario = 1800.00, EmpresaId = 1 });
            listaEmpleados.Add(new Empleado { Id = 5, Nombre = "Javier Manuel Alvarez Renteria", Cargo = "Gerente RecurSos Humanos", Salario = 2000.90, EmpresaId = 10 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Benjamin Moreno Gonzalez", Cargo = "Gerente de T.I.", Salario = 6700.00, EmpresaId = 9 });
            listaEmpleados.Add(new Empleado { Id = 7, Nombre = "Benjamin Rholeisser Bazualdo", Cargo = "Vicepresidente Financiero", Salario = 12300.20, EmpresaId = 8 });
            listaEmpleados.Add(new Empleado { Id = 8, Nombre = "Jose Manuel Armani Caghazo", Cargo = "Gerente de Contabilidad", Salario = 8000.10, EmpresaId = 7 });
            listaEmpleados.Add(new Empleado { Id = 9, Nombre = "Carlos Jose Montiel Verdaz", Cargo = "Remolcador", Salario = 800.43, EmpresaId = 6 });
            listaEmpleados.Add(new Empleado { Id = 10, Nombre = "Jorge Ali Triana Zoe", Cargo = "Jefe de Operaciones", Salario = 7000.80, EmpresaId = 5 });
            listaEmpleados.Add(new Empleado { Id = 11, Nombre = "Mario Alberto Yepes Ortega", Cargo = "Gerente Comercial", Salario = 900.00, EmpresaId = 4 });
            listaEmpleados.Add(new Empleado { Id = 12, Nombre = "Pablo Armero Renteria", Cargo = "Jefe de Obra", Salario = 1900.00, EmpresaId = 3 });
            listaEmpleados.Add(new Empleado { Id = 13, Nombre = "Juan Camilo Angulo Reyes", Cargo = "Project Manager", Salario = 2010.67, EmpresaId = 2 });
            listaEmpleados.Add(new Empleado { Id = 14, Nombre = "Mariana Jose Pajon Lucumi", Cargo = "Scrum Master", Salario = 1200.90, EmpresaId = 1 });
            listaEmpleados.Add(new Empleado { Id = 15, Nombre = "Fabriccio Angileri Zea", Cargo = "Product Owner", Salario = 1400.00, EmpresaId = 10 });
            listaEmpleados.Add(new Empleado { Id = 16, Nombre = "Milton Albeiro Casco Roman", Cargo = "Desarrollador Full-Stack", Salario = 5500.00, EmpresaId = 9 });
            listaEmpleados.Add(new Empleado { Id = 17, Nombre = "Frank Fabra Batista", Cargo = "Operador de Servidores", Salario = 2300.00, EmpresaId = 8 });
            listaEmpleados.Add(new Empleado { Id = 18, Nombre = "Oscar Fabian Murillo Cepeda", Cargo = "Gerente Comercial", Salario = 1230.89, EmpresaId = 7 });
            listaEmpleados.Add(new Empleado { Id = 19, Nombre = "Wilmar Olegario Barrios Yepes", Cargo = "Fisioterapeuta", Salario = 1200.00, EmpresaId = 6 });
            listaEmpleados.Add(new Empleado { Id = 20, Nombre = "Johan Manuel Valencia Ocoro", Cargo = "Gerente Comercial", Salario = 3100.00, EmpresaId = 5 });
            listaEmpleados.Add(new Empleado { Id = 21, Nombre = "Radamel Falcao Garcia", Cargo = "Aseador", Salario = 800.00, EmpresaId = 4 });
            listaEmpleados.Add(new Empleado { Id = 22, Nombre = "James David Rodriguez Rubio", Cargo = "Arquitecto de Software", Salario = 8000.10, EmpresaId = 3 });
            listaEmpleados.Add(new Empleado { Id = 23, Nombre = "Juan Fernnado Quintero Paniagua", Cargo = "Vigilante", Salario = 2560.00, EmpresaId = 2 });
            listaEmpleados.Add(new Empleado { Id = 24, Nombre = "Mateus del Carmen Uribe Gonzalez", Cargo = "Oficios Varios", Salario = 2760.50, EmpresaId = 1 });


        }

        public void GetCargo(string varCargo)
        {

            IEnumerable<Empleado> filtroCargosCollection = from empleados in listaEmpleados where empleados.Cargo==varCargo select empleados;

            foreach(Empleado empl in filtroCargosCollection)
            {
                empl.GetDatosEmpleado();

            }

        }

        public void GetSalarios(double Salar1, double Salar2)
        {

            IEnumerable<Empleado> filtroCargosCollection = from empleados in listaEmpleados where empleados.Salario>=Salar1 && empleados.Salario<=Salar2 select empleados;

            foreach (Empleado empl in filtroCargosCollection)
            {
                empl.GetDatosEmpleado();

            }

        }

        public void ListaAlfabeticaEmpleados()
        {
            IEnumerable<Empleado> ordenAlfabeticoCollection = from empleados in listaEmpleados orderby empleados.Nombre ascending select empleados;

            foreach (Empleado empl in ordenAlfabeticoCollection)
            {
                empl.GetDatosEmpleado();

            }

        }

        public void GetEmpleadoxEmpresa(int Id)
        {
            IEnumerable<Empleado> ordenAlfabeticoCollection = from empleados in listaEmpleados join empresa in listaEmpresas on empleados.EmpresaId equals empresa.Id where empresa.Id==Id orderby empleados.Nombre ascending select empleados;

            foreach (Empleado empl in ordenAlfabeticoCollection)
            {
                empl.GetDatosEmpleado();

            }

        }

        public List<Empresa> listaEmpresas = new List<Empresa>();

        public List<Empleado> listaEmpleados = new List<Empleado>();

    }


    class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void GetDatosEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Nombre, Id);
        }
    }
    class Empleado 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }

        public double Salario { get; set; }

        //Clave Foranea 
        public int EmpresaId { get; set; }

        public void GetDatosEmpleado()
        {
            Console.WriteLine("Empleado {0} con Id {1}, Cargo {2} con Salario {3} y Pertence a la Empresa {4}", Nombre, Id, Cargo, Salario, EmpresaId);
        }
    }

}

