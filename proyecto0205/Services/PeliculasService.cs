using proyecto0205.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto0205.Services
{
    public class PeliculasService
    {
        public Pelicula ObtenerPelicula() {
            return new Pelicula() {
                Titulo = "Tren en Llamas",
                Duracion = 15,
                Pais = "Bolivia",
                Publicacion = new DateTime(2013, 12, 5)
            };

        }

        public List<Pelicula> ObtenerVariasPeliculas() {
            List<Pelicula> peliculas = new List<Pelicula>();
            peliculas.Add(new Pelicula() {
                Titulo = "Armagedon",
                Duracion = 45,
                Pais="Bolivia",
                Publicacion=new DateTime(2015,12,25)
            });

            peliculas.Add(new Pelicula()
            {
                Titulo = "Transformer",
                Duracion = 65,
                Pais = "USA",
                Publicacion = new DateTime(2017, 10, 12)
            });

            peliculas.Add(new Pelicula()
            {
                Titulo = "Dios es Fiel",
                Duracion = 95,
                Pais = "Jerusalen",
                Publicacion = new DateTime(1996, 12, 24)
            });

            return peliculas;
        }
    }
}