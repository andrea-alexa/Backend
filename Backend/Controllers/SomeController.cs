
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Backend.Controllers
{
    [Route("api/[controller]")]

    public class SomeController : ControllerBase
    {
        [HttpGet("sync")]
        public IActionResult getSync()
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            stopWatch.Start();
            Thread.Sleep(1000);
            Console.WriteLine("Conexion finalizada");

            Thread.Sleep(1000);
            Console.WriteLine("Conexion envio finalizada");
            stopWatch.Stop();

            return Ok(stopWatch.Elapsed);
        }

        [HttpGet("async")]
        public async Task<IActionResult> GetAsync()
        {
            var tak1 = new Task(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Finalizacion de la tarea Asincrona");
            });

            tak1.Start();
            Console.WriteLine("Finalizacion de la tarea No Asincrona");
            await tak1;
            Console.WriteLine("Finalizacion de la tarea No Asincrona terminado");

            return Ok();
        }

        [HttpGet("async2")]
        public async Task<IActionResult> GetAsync2()
        {
            Stopwatch stopWatch = Stopwatch.StartNew();
            stopWatch.Start();
            var tak1 = new Task<int>(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Finalizacion de la tarea Asincrona");
                return 8;
            });

            stopWatch.Start();
            var tak2 = new Task<int>(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Finalizacion de la tarea Asincrona");
                return 1;
            });

            tak1.Start();
            tak2.Start();
            Console.WriteLine("Finalizacion de la tarea No Asincrona");
            var resultado = await tak1;
            Console.WriteLine("Finalizacion de la tarea No Asincrona terminado");
            stopWatch.Stop();

            return Ok(resultado + "Fin" + stopWatch.Elapsed);
        }
    }
}
