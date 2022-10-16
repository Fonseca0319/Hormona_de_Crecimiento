using System;
using Hormona.App.Dominio;
using Hormona.App.Persistencia;
namespace Hormona.App.Consola
{

    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        private static IRepositorioEndocrino _repoEndocrino = new RepositorioEndocrino(new Persistencia.AppContext());
        private static IRepositorioPediatra _repoPediatra = new RepositorioPediatra(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioFamiliar _repoFamiliar = new RepositorioFamiliar(new Persistencia.AppContext());
        private static IRepositorioSugerencias _repoSugerencias = new RepositorioSugerencias(new Persistencia.AppContext());
        private static IRepositorioPatrones _repoPatrones = new RepositorioPatrones(new Persistencia.AppContext());


        static void Main(string[] args)
        {
            //AddPaciente();
            //Console.WriteLine("Hello World");
            // BuscarPaciente(2);
            //EliminarPaciente(9);
            // MostrarPaciente();
            //AddEndocrino();
           // AsignarEndocrino();
            //AddPediatra();
             AsignarPediatra();
             //AddHistoria();
            // EliminarPediatra(3);
            // AsignarHistoria();
            //AddFamiliar();
           //AsignarFamiliar();
           //AddSugerencias();
          //AddPatrones();


        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                nombre = "Messi",
                apellido = "Junior",
                telefono = "3101032",
                sexos = Sexo.Femenino,
                documento = "1011010192",
                direccion = "cr 44 #12a",
                latitud = 4.322F,
                longitud = -2.342323F,
                ciudad = "Rosario",
                fechaDeNacimineto = new DateTime(1985, 01, 19),
                




            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            ///Console.WriteLine("Nombre: "+paciente.nombre+" "+paciente.apellido);
            paciente.nombre = "Ivanna";
            paciente.apellido = "Fonseca Gomez";
            paciente.documento = "12232133";
            
            //ModificarPaciente(paciente);

        }
        private static void MostrarPaciente()
        {
            var pacientes = _repoPaciente.GetAllPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine("Nombre: " + paciente.nombre + " " + paciente.apellido);

            }
        }
        private static void ModificarPaciente(Paciente paciente)
        {
            _repoPaciente.UpdatePaciente(paciente);
        }
        private static void EliminarPaciente(int idpaciente)
        {
            _repoPaciente.DeletePaciente(idpaciente);
        }
        private static void AddEndocrino()
        {
            var endocrino = new Endocrino
            {
                nombre = "Ramon",
                apellido = "Valdez",
                telefono = "242232",
                sexos = Sexo.Femenino,
                codigo = "0013",
                registro = "5555"



            };
            _repoEndocrino.AddEndocrino(endocrino);

        }
        private static void AsignarEndocrino()
        {
            var endocrino = _repoPaciente.AsignarEndocrino(1, 3);
            Console.WriteLine(endocrino.nombre);
        }
        private static void AddPediatra()
        {
            var pediatra = new Pediatra
            {
                nombre = "Alvaro",
                apellido = "Uribe",
                telefono = "121301",
                sexos = Sexo.Masculino,
                codigo = "a10",
                registro = "a1210"



            };
            _repoPediatra.AddPediatra(pediatra);

        }
        private static void AsignarPediatra()
        {
            var pediatra = _repoPaciente.AsignarPediatra(1006, 1008);
            Console.WriteLine(pediatra.nombre);
        }
        private static void AddHistoria()
        {
            var historia = new Historia
            {
                diagnostico = "paciente delicado",
                

            };
            _repoHistoria.AddHistoria(historia);
        }
         private static void EliminarPediatra(int idpediatra)
        {
            _repoPediatra.DeletePediatra(idpediatra);
        }
        private static void AsignarHistoria()
        {
            var pediatra = _repoPaciente.AsignarHistoria(1, 1);
            //Console.WriteLine(paciente.nombre);
        }
         private static void AddFamiliar()
        {
            var familiar = new Familiar
            {
                nombre = "Pedro",
                apellido = "Fonseca",
                telefono = "13420101",
                sexos = Sexo.Masculino,
                documento = "102932",
                parentesco = "Padre",
                email="fonse@ga"



            };
            _repoFamiliar.AddFamiliar(familiar);

        }
         private static void AsignarFamiliar()
        {
            var familiar = _repoPaciente.AsignarFamiliar(1, 5);
            //Console.WriteLine(endocrino.nombre);
        }

         private static void AddSugerencias()
        {
            var sugerencias = new SugerenciasDeCiudado
            {
               descripcionCiudados = "Realizar Dieta",
               fechaHora  = new DateTime(2022,05,16)
                };
            _repoSugerencias.AddSugerencias(sugerencias);
            }
               private static void AddPatrones()
        {
            var patrones = new PatronDeCrecimineto
            {
               
               fechaHora  = new DateTime(2022,05,16),
               valor =10,
               patronesDeCrecimiento=0
               
              
            

                };
            _repoPatrones.AddPatrones(patrones);
            }
            
      
        }
       
        
        }
    

     


    












