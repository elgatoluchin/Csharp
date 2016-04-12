using System;
//Clase libroCalificaciones con un constructor para inicializar el nombre del Curso
public class LibroCalificaciones{
    
    private string nombreCurso;//Nombre del curso para este LibroCalificaciones

   //El metodo constructor lleva el mismo ombre que la clase 
   //el constructor inicializa nombreCurso con el objeto string suministrado como argumento
    public LibroCalificaciones(string nombre){
        //inicializa nombreCurso usando la propiedad
        NombreCurso = nombre;
    }//fin del Constructor


    //Pripiedad para obtener get y establecer set el nombre del curso
    public string NombreCurso{
        get{ 
            return nombreCurso;
            }
        set{
            nombreCurso = value;
        }
    }//Fin de la Propiedad

  
    public void MostrarMensaje(){
        //Usa la pripiedad NombreCurso para obtener el nombre del curso que representa este LibroCalificaciones
        Console.WriteLine("Bienvenido al libro de calificaciones para: {0}",NombreCurso);
    }//Fin del metodo
}//Fin de la clase