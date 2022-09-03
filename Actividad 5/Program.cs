using Actividad_5.Models;
using Actividad_5.Controllers;
using Actividad_5.Views.Vehicle;

Console.WriteLine("Programa de registro de buses para el SITP");
Console.WriteLine("----------------------------------------------");


BusController controller = new BusController(new CrearBus());
controller.Crear("1", "SE14", Estacion.Build("1","carrera30","SE14"));