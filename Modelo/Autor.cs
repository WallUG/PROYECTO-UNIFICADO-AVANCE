using System;

namespace Modelo
{
    public class Autor
    {
        public int IdAutor { get; set; }
        public string NombreAutor { get; set; }
        public string CarreraAutor { get; set; }
        public string UniversidadAutor { get; set; }
        public string ModuloAutor { get; set; }
        public string UrlImagen { get; set; }

        public Autor()
        {
        }

        public Autor(string nombreAutor, string carreraAutor, string universidadAutor, string moduloAutor, string urlImagen)
        {
            NombreAutor = nombreAutor;
            CarreraAutor = carreraAutor;
            UniversidadAutor = universidadAutor;
            ModuloAutor = moduloAutor;
            UrlImagen = urlImagen;
        }

        public override string ToString()
        {
            return $"{NombreAutor}\n{CarreraAutor}\n{UniversidadAutor}\nMódulo: {ModuloAutor}";
        }
    }
}
