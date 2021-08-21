using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;


namespace Taller_103_WPF_LINQ
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext DataContext;
        public MainWindow()
        {
            InitializeComponent();

            Console.WriteLine("____________________ Taller 103 LINQ - ORM - SQL ____________________ ");

            Console.WriteLine("");

            Console.WriteLine("Ejercicio 1 - Mapea Tabla Empresa, Inserta Registro y Despliega WPF");

            Console.WriteLine("");

            string miConexion = ConfigurationManager.ConnectionStrings["Taller_103_WPF_LINQ.Properties.Settings.CrudLinqSql"].ConnectionString;

            DataContext = new DataClasses1DataContext(miConexion);
/*
            InsertaEmpresas("General Motors");
            InsertaEmpresas("Fiat");
            InsertaEmpresas("BMW");
            InsertaEmpresas("Mercdes Benz");
            InsertaEmpresas("Renaul");
            InsertaEmpresas("Lexus");
            InsertaEmpresas("Jaguar");
            InsertaEmpresas("Audi");
            InsertaEmpresas("Opel");
            InsertaEmpresas("Ford");
*/
            Console.WriteLine("");

            Console.WriteLine("Ejercicio 2 - Mapea Tabla Empleados, Inserta Registro y Despliega WPF");

            Console.WriteLine("");

                        List<Empleado> listaEmpleados = new List<Empleado>();

                        listaEmpleados.Add(new Empleado { Nombre = "Juanito", Apellido = "Alimaña", EmpresaId = 3 });
                        listaEmpleados.Add(new Empleado { Nombre = "Pepito", Apellido = "Perez", EmpresaId = 6 });
                        listaEmpleados.Add(new Empleado { Nombre = "Zenon", Apellido = "Bustos Arteta", EmpresaId = 8 });
                        listaEmpleados.Add(new Empleado { Nombre = "Fabriccio", Apellido = "Angilleri", EmpresaId = 10 });
                        listaEmpleados.Add(new Empleado { Nombre = "Ignacio", Apellido = "Fernandez", EmpresaId = 12 });
                        listaEmpleados.Add(new Empleado { Nombre = "Jorge", Apellido = "Carrascal", EmpresaId = 14 });
                        listaEmpleados.Add(new Empleado { Nombre = "Eusebio", Apellido = "Queiroz", EmpresaId = 16 });
                        listaEmpleados.Add(new Empleado { Nombre = "Nicolas", Apellido = "De La Cruz", EmpresaId = 1 });
                        listaEmpleados.Add(new Empleado { Nombre = "Milton", Apellido = "Casco", EmpresaId = 3 });
                        listaEmpleados.Add(new Empleado { Nombre = "Jorge", Apellido = "Maidana", EmpresaId = 5 });
                        listaEmpleados.Add(new Empleado { Nombre = "Jorge", Apellido = "Pirinola", EmpresaId = 7 });
                        listaEmpleados.Add(new Empleado { Nombre = "Gonzalo", Apellido = "Montiel", EmpresaId = 9 });
                        listaEmpleados.Add(new Empleado { Nombre = "Pablo", Apellido = "Diaz", EmpresaId = 11 });
                        listaEmpleados.Add(new Empleado { Nombre = "Robert", Apellido = "Rojas", EmpresaId = 13 });
                        listaEmpleados.Add(new Empleado { Nombre = "Hector David", Apellido = "Martinez", EmpresaId = 15 });
                        listaEmpleados.Add(new Empleado { Nombre = "Enzo", Apellido = "Perez", EmpresaId = 17 });
                        listaEmpleados.Add(new Empleado { Nombre = "Enzo", Apellido = "Fernandez", EmpresaId = 1 });
                        listaEmpleados.Add(new Empleado { Nombre = "Bruno", Apellido = "Zuculinni", EmpresaId = 2 });
                        listaEmpleados.Add(new Empleado { Nombre = "Julian", Apellido = "Alvarez", EmpresaId = 3 });
                        listaEmpleados.Add(new Empleado { Nombre = "Brian", Apellido = "Romero", EmpresaId = 4 });
                        listaEmpleados.Add(new Empleado { Nombre = "Rafael", Apellido = "Santos Borre", EmpresaId = 5 });
                        listaEmpleados.Add(new Empleado { Nombre = "Matias", Apellido = "Suarez", EmpresaId = 6 });
                        listaEmpleados.Add(new Empleado { Nombre = "Franco", Apellido = "Armani", EmpresaId = 7 });
                        listaEmpleados.Add(new Empleado { Nombre = "Agustin", Apellido = "Palavecino", EmpresaId = 8 });
                        listaEmpleados.Add(new Empleado { Nombre = "Jose", Apellido = "Paradela", EmpresaId = 9 });
                        listaEmpleados.Add(new Empleado { Nombre = "Federico", Apellido = "Girotti", EmpresaId = 10 });
                        listaEmpleados.Add(new Empleado { Nombre = "Leonardo", Apellido = "Ponzio", EmpresaId = 11 });
                        listaEmpleados.Add(new Empleado { Nombre = "Alex", Apellido = "Vigo", EmpresaId = 12 });
                        listaEmpleados.Add(new Empleado { Nombre = "Flabian", Apellido = "Londoño", EmpresaId = 13 });
                        listaEmpleados.Add(new Empleado { Nombre = "Juan Fernando", Apellido = "Quintero", EmpresaId = 14 });
                        listaEmpleados.Add(new Empleado { Nombre = "German", Apellido = "Lux", EmpresaId = 15 });
                        listaEmpleados.Add(new Empleado { Nombre = "Benjamin", Apellido = "Rollheiser", EmpresaId = 16 });
                        listaEmpleados.Add(new Empleado { Nombre = "Enrique", Apellido = "Bologna", EmpresaId = 17 });

                        //InsertaEmpleados(listaEmpleados);

            Console.WriteLine("");

            Console.WriteLine("Ejercicio 3 - Mapea Tabla Cargos, Inserta Registro y Despliega WPF");

            Console.WriteLine("");

            List<Cargo> listaCargos = new List<Cargo>();

            listaCargos.Add(new Cargo { Nombre = "Vicepresidente I.T." });
            listaCargos.Add(new Cargo { Nombre = "Vicepresidente Operaciones" });
            listaCargos.Add(new Cargo { Nombre = "Vicepresidente Mantenimiento" });
            listaCargos.Add(new Cargo { Nombre = "Vicepresidente Seguridad" });
            listaCargos.Add(new Cargo { Nombre = "Vicepresidente Comercial" });
            listaCargos.Add(new Cargo { Nombre = "Gerente General" });
            listaCargos.Add(new Cargo { Nombre = "Gerente I.T." });
            listaCargos.Add(new Cargo { Nombre = "Gerente Operaciones" });
            listaCargos.Add(new Cargo { Nombre = "Gerente Mantenimiento" });
            listaCargos.Add(new Cargo { Nombre = "Gerente Seguridad" });
            listaCargos.Add(new Cargo { Nombre = "Desarrollador Full-Stack .Net" });
            listaCargos.Add(new Cargo { Nombre = "Scrum Master" });
            listaCargos.Add(new Cargo { Nombre = "Product Owner" });
            listaCargos.Add(new Cargo { Nombre = "Jefe de Recursos Humanos" });
            listaCargos.Add(new Cargo { Nombre = "Gerente Comercial" });
            listaCargos.Add(new Cargo { Nombre = "Project Manager" });

            //InsertaCargos(listaCargos);

            Console.WriteLine("");

            Console.WriteLine("Ejercicio 4 - Mapea Tabla Cargos_Empleado, Inserta Registro y Despliega WPF");

            Console.WriteLine("");

            List<Cargo_Empleado> listaCargosEmpleado = new List<Cargo_Empleado>();

            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 1, CargoId = 15 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 2, CargoId = 14 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 3, CargoId = 13 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 4, CargoId = 12 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 5, CargoId = 11 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 6, CargoId = 10 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 7, CargoId = 9 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 8, CargoId = 8 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 9, CargoId = 7 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 10, CargoId = 6 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 11, CargoId = 5 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 12, CargoId = 4 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 13, CargoId = 3 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 14, CargoId = 2 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 15, CargoId = 1 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 16, CargoId = 15 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 17, CargoId = 14 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 18, CargoId = 13 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 19, CargoId = 12 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 20, CargoId = 11 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 21, CargoId = 10 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 22, CargoId = 9 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 23, CargoId = 8 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 24, CargoId = 7 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 25, CargoId = 6 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 26, CargoId = 5 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 27, CargoId = 4 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 28, CargoId = 3 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 29, CargoId = 2 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 30, CargoId = 1 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 31, CargoId = 15 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 32, CargoId = 14 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 33, CargoId = 13 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 1, CargoId = 12 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 3, CargoId = 16 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 5, CargoId = 16 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 7, CargoId = 16 });
            listaCargosEmpleado.Add(new Cargo_Empleado { EmpleadoId = 9, CargoId = 16 });

            //InsertaCargosEmpleado(listaCargosEmpleado);

            Console.WriteLine("");

            Console.WriteLine("Ejercicio 5 - Mapea Tabla Empleado, Actualiza Registro y Despliega WPF");

            Console.WriteLine("");

            Console.WriteLine("1. ID Empleado: \n");

            int Id = 6;

            Console.WriteLine("");

            Console.WriteLine("2. Nombre Empleado: \n");

            string nom = "Jorge Humberto";

            Console.WriteLine("");

            Console.WriteLine("3. Apellido Empleado: \n");

            string ape = "Carrascal Gallardo";

            Console.WriteLine("");

            Console.WriteLine("4. Empresa ID: \n");

            int emp = 14;

            //ActualizaEmpleado(Id, nom, ape, emp);

            Console.WriteLine("");

            Console.WriteLine("Ejercicio 6 - Mapea Tabla Empleado, Elimina Registro y Despliega WPF");

            Console.WriteLine("");

            Console.WriteLine("1. ID Empleado: \n");

            int ide = 1;

            EliminaEmpleado(ide);
        }

        public void InsertaEmpresas(string nom)
        {
            Empresa ObjEmpresa = new Empresa();

            ObjEmpresa.Nombre = nom;

            DataContext.Empresa.InsertOnSubmit(ObjEmpresa);

            DataContext.SubmitChanges();

            Principal.ItemsSource = DataContext.Empresa;

        }

        public void InsertaEmpleados(List<Empleado> listaEmpleados)
        {
            //Empresa ObjEmpresa = DataContext.Empresa.First(em => em.Id.Equals(emp));

            Empleado ObjEmpleado = new Empleado();

            DataContext.Empleado.InsertAllOnSubmit(listaEmpleados);

            DataContext.SubmitChanges();

            Principal.ItemsSource = DataContext.Empleado;

        }

        public void InsertaCargos(List<Cargo> listaCargos)
        {
            Cargo ObjCargos = new Cargo();

            DataContext.Cargo.InsertAllOnSubmit(listaCargos);

            DataContext.SubmitChanges();

            Principal.ItemsSource = DataContext.Cargo;

        }

        public void InsertaCargosEmpleado(List<Cargo_Empleado> listaCargosEmpleado)
        {
            Cargo_Empleado   ObjCargosEmpleado = new Cargo_Empleado();
            
            DataContext.Cargo_Empleado.InsertAllOnSubmit(listaCargosEmpleado);

            DataContext.SubmitChanges();

            Principal.ItemsSource = DataContext.Cargo_Empleado;

        }

        public void ActualizaEmpleado(int Id, string nom, string ape, int emp)
        {
            Empleado ObjEmpleado = DataContext.Empleado.First(em => em.Id==Id);

            ObjEmpleado.Nombre = nom;

            ObjEmpleado.Apellido= ape;

            ObjEmpleado.EmpresaId = emp;

            DataContext.SubmitChanges();

            Principal.ItemsSource = DataContext.Empleado;

        }
        public void EliminaEmpleado(int ide)
        {
            Empleado ObjEmpleado = DataContext.Empleado.First(em => em.Id == ide);

            DataContext.Empleado.DeleteOnSubmit(ObjEmpleado);

            DataContext.SubmitChanges();

            Principal.ItemsSource = DataContext.Empleado;

        }

    }
}
