using System;
//El Constructor libroCalificaciones se utiliza para especificar el nombre del curso cada vez que se crea un objeto LibroCalificaciones 
public class cls_PruebaLibroCalificaciones{
    //Metodo que comienza la ejecucion del programa
    public static void Main(String [] args){

        //Crea el objeto LibroCalificaciones

        LibroCalificaciones libroCalificaciones1 = new LibroCalificaciones("CS101 Introduccion a la programacion C#");//Invoca al constructor

        LibroCalificaciones libroCalificaciones2 = new LibroCalificaciones("CS102 Estructuras de datos en C#");//Invoca al constructor

        //Muestra el valor inicial del curso para cada LibroCalificaciones
        Console.WriteLine("El nombre del curso de librocalificaciones1 es: {0}", libroCalificaciones1.NombreCurso);

        Console.WriteLine("El nombre del curso de librocalificaciones2 es: {0}", libroCalificaciones2.NombreCurso);

    }//Fin del metodo
}//Fin de la Clase
