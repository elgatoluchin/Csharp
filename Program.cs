using System;

public class LibroCalificaciones{
    //Variable de instancia de tipo privado
    private string nombreCurso;

    
    //Porpiedad para obtener (get) y establecer (set) el nombre del Curso
    public string NombreCurso{
        get{ 
            return nombreCurso;
            }
        set{
            nombreCurso = value;
        }
    }//Fin metodo

    //Metodo de retorno
    public void MostrarMensaje(){
        //Mostramos la Propiedad NombreCurso
        Console.WriteLine("Bienvenido al libro de calificaciones para: {0}",NombreCurso);
    }//Fin del metodo
}//Fin de la clase