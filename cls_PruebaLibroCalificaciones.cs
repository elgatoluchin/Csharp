using System;

public class cls_PruebaLibroCalificaciones{

    public static void Main(String [] args){

        //el argumento CS101 Introduccion a la programacion en C#
        //Se pasa al constructor del objeto y se utiliza para inicializar nombreCurso
        //Esta instruccion requiere que la clase proporcione un contructor con un parametro string
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones("CS101 Introduccion a la programacion en C#");

        Console.WriteLine("El nombre del curso es: {0}", miLibroCalificaciones.NombreCurso);

        Console.WriteLine("Escriba el nombre del curso: ");
        string elNombre = Console.ReadLine();

        //el objeto de tipo miLibroCalificaciones
        //Hace referencia a la propiedad de objeto LibroCalificaciones
        //y envia el valor a la porpiedad NombreCurso 
        miLibroCalificaciones.NombreCurso = elNombre;

        //Mostramos los valores del metodo MostrarMensaje
        //del objeto miLibroCalificaiones que representa 
        // al objeto LibroCalificaciones que esta en memoria 
        miLibroCalificaciones.MostrarMensaje();


    }//Fin del metodo

}//Fin de la Clase
