using Microsoft.AspNetCore.Mvc;

namespace linqExercises.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LinqController1 : ControllerBase
    {
        // EJ 1
        List<int> integers = new List<int> { 1, 15, 30, 78, 150, 10000, 9000, 7400, 3500, 20, 40, 90, 140, 14, 59, 80 };

        [HttpGet("integers")]
        public IEnumerable<int> GetIntegers()
        {
            var query =
                from i in integers
                where i > 30 && i < 100
                select i;
            return query;
        }


        // EJ2


        List<string> words = new List<string> { "silla", "mesa", "computadora", "pajaro", "desarrollador", "profesor", "entidad", "diagrama", "token", "autenticacion", "practica", "hola", "mama", "estudio", "sol", "lluvia", "si", "no", "vaca", "buscador", "beatificador", "bacilor", "babador" };


        [HttpGet("words")]
        public IEnumerable<string> GetWords()
        {
            var query =
                from w in words
                where w.Length >= 5
                select w.ToUpper();
            return query;
        }

        // EJ3

        [HttpGet("specificwords")]

        public IEnumerable<string> GetSpecificWords()
        {
            var query =
                from w in words
                where w.StartsWith("b") && w.EndsWith("r")
                select w;
            return query;
        }


        // EJ4

        [HttpGet("firstfiveintegers")]
        public IEnumerable<int> GetNumbers()
        {
            var query =
                integers.Take(5).OrderByDescending(i => i);

            return query;
        }

        // EJ5
        // pongo enumerable d tipo string ya que quiero mostrar los resultados en texto con interpolacion
        [HttpGet("squareroots")]
        public IEnumerable<string> GetSquareRoots()
        {
            var query =
                from i in integers
                let sqrt = i * i
                where sqrt > 20
                select $"Numero: {i} - cuadrado: {sqrt}";
            return query;

        }


        // EJ6

        [HttpGet("modifiedwords")]
        public IEnumerable<string> GetModifiedWords()
        {
            var query =
                from w in words
                where w.Contains("ia")
                select w.Replace("ia", "*");
                return query;
        }

     

    }

}
