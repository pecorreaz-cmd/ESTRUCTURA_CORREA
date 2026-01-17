using System;

// Programa principal para probar la función
class Program
{
    static void Main()
    {
        // Crear una nueva lista
        ListaEnlazada miLista = new ListaEnlazada();
        
        // Agregar algunos elementos
        miLista.Agregar(10);
        miLista.Agregar(20);
        miLista.Agregar(30);
        miLista.Agregar(40);
        miLista.Agregar(50);
        
        // Mostrar la lista
        miLista.MostrarLista();
        
        // Contar y mostrar el número de elementos
        int totalElementos = miLista.ContarElementos();
        Console.WriteLine("Número de elementos: " + totalElementos);
        
        // Probar con una lista vacía
        Console.WriteLine("\nProbando con lista vacía:");
        ListaEnlazada listaVacia = new ListaEnlazada();
        listaVacia.MostrarLista();
        Console.WriteLine("Número de elementos: " + listaVacia.ContarElementos());
        
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}