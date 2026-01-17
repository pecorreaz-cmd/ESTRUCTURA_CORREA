using System;

// Programa principal para probar la función
class Program
{
    static void Main()
    {
        Console.WriteLine("=== INVERTIR DATOS DE LISTA ENLAZADA ===\n");
        
        // ===== PRUEBA 1: Método con arreglo =====
        Console.WriteLine("--- MÉTODO 1: Usando arreglo auxiliar ---\n");
        
        ListaEnlazada lista1 = new ListaEnlazada();
        lista1.Agregar(10);
        lista1.Agregar(20);
        lista1.Agregar(30);
        lista1.Agregar(40);
        lista1.Agregar(50);
        
        Console.WriteLine("Lista ORIGINAL:");
        lista1.MostrarLista();
        
        // Invertir los datos
        lista1.InvertirDatos();
        
        Console.WriteLine("\nLista con DATOS INVERTIDOS:");
        lista1.MostrarLista();
        Console.WriteLine("(Primer dato ahora es 50, último es 10)\n");
        
        
        // ===== PRUEBA 2: Método con punteros =====
        Console.WriteLine("\n--- MÉTODO 2: Usando dos punteros ---\n");
        
        ListaEnlazada lista2 = new ListaEnlazada();
        lista2.Agregar(100);
        lista2.Agregar(200);
        lista2.Agregar(300);
        lista2.Agregar(400);
        lista2.Agregar(500);
        
        Console.WriteLine("Lista ORIGINAL:");
        lista2.MostrarLista();
        
        // Invertir los datos con punteros
        lista2.InvertirDatosConPunteros();
        
        Console.WriteLine("\nLista con DATOS INVERTIDOS:");
        lista2.MostrarLista();
        Console.WriteLine("(Primer dato ahora es 500, último es 100)\n");
        
        
        // ===== PRUEBA 3: Lista impar =====
        Console.WriteLine("\n--- PRUEBA con lista impar (3 elementos) ---\n");
        
        ListaEnlazada lista3 = new ListaEnlazada();
        lista3.Agregar(1);
        lista3.Agregar(2);
        lista3.Agregar(3);
        
        Console.WriteLine("Lista ORIGINAL:");
        lista3.MostrarLista();
        
        lista3.InvertirDatos();
        
        Console.WriteLine("\nLista INVERTIDA:");
        lista3.MostrarLista();
        
        
        // ===== PRUEBA 4: Lista con 1 elemento =====
        Console.WriteLine("\n--- PRUEBA con 1 solo elemento ---\n");
        
        ListaEnlazada lista4 = new ListaEnlazada();
        lista4.Agregar(99);
        
        Console.WriteLine("Lista ORIGINAL:");
        lista4.MostrarLista();
        
        lista4.InvertirDatos();
        
        Console.WriteLine("\nLista INVERTIDA:");
        lista4.MostrarLista();
        Console.WriteLine("(No cambia porque solo tiene 1 elemento)");
        
        Console.WriteLine("\n\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}