using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_Interfaces
{
    internal class Libro:IColeccionable, IComparable<Libro>
    {
        private string autor;
        private string titulo;
        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set =>titulo = value; }

        public Libro(string autor, string titulo)
        {
            this.autor = autor;
            this.titulo = titulo;
        }

        public void Descripcion()
        {
            Console.WriteLine($"El libro: {Titulo}, es del autor: {Autor}");
        }

        //Sobreescritura del metodo compareTo personalizado la lógica de comparación para comparar dos libros basándote en
        //sus títulos, y también has manejado el caso en el que el libro pasado como parámetro sea null, devolviendo 1
        //if(other==null) return 1;: Esta línea verifica si el objeto other pasado como parámetro es null. Si es así,
        //devuelve 1. Esta es una convención común en la implementación de CompareTo. Devolver un valor positivo (en este
        //caso, 1) cuando se compara con un objeto nulo indica que el objeto actual (this) se considera mayor que el objeto
        //null

        public int CompareTo(Libro other)
        {
            //siempre existe la posibilidad de que el objeto pasado como parámetro other sea null. En ese caso, la
            //comparación no se puede realizar de manera significativa porque no hay un objeto real con el que comparar.
            //por eso null
            if (other==null) return 1;
            // Comparar por la propiedad titulo

            /*return this.titulo.CompareTo(other.titulo);: Si el objeto other no es null, entonces este código compara los
             * títulos de los libros (titulo) del objeto actual (this) y el objeto other. La comparación se realiza
             * utilizando el método CompareTo de la cadena (String.CompareTo). Este método devuelve un valor entero que
             * indica la relación de orden entre dos cadenas:
            Si this.titulo es "anterior" a other.titulo, devuelve un valor negativo.
            Si this.titulo es "posterior" a other.titulo, devuelve un valor positivo.
            Si las cadenas son "iguales" en orden, devuelve 0. 
            es decir:
            este entero tiene 3 posibilidades:

            -1 si el primer elemento, o el actual es “mayor”.
            0 si ambos son iguales
            1 si el segundo elemento, o el introducido es “mayor”
             */

            //CompareTo es un método de la clase string que compara dos cadenas. En este caso, this.titulo es una cadena
            //(el título del libro actual), y other.titulo
            return this.titulo.CompareTo(other.titulo);
        }

        public override string ToString()
        {
            return $"Titulo: {Titulo}, Autor: {Autor}";
        }
    }
}
