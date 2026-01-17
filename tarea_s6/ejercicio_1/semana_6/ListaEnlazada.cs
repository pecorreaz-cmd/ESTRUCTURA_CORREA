using System;

// Clase que representa la lista enlazada
class ListaEnlazada
{
    public Nodo Cabeza;  // El primer nodo de la lista
    
    // Constructor de la lista vacía
    public ListaEnlazada()
    {
        Cabeza = null;  // La lista empieza vacía
    }
    
    // Método para agregar elementos al final de la lista
    public void Agregar(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato);
        
        // Si la lista está vacía, el nuevo nodo es la cabeza
        if (Cabeza == null)
        {
            Cabeza = nuevoNodo;
        }
        else
        {
            // Buscar el último nodo
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            // Conectar el nuevo nodo al final
            actual.Siguiente = nuevoNodo;
        }
    }
    
    // FUNCIÓN PRINCIPAL: Contar elementos de la lista
    public int ContarElementos()
    {
        int contador = 0;           // Variable para contar los nodos
        Nodo actual = Cabeza;       // Empezamos desde la cabeza
        
        // Recorremos la lista hasta llegar al final (null)
        while (actual != null)
        {
            contador++;             // Contamos este nodo
            actual = actual.Siguiente;  // Saltamos al siguiente nodo
        }
        
        return contador;  // Devolvemos el total de elementos
    }
    
    // Método para mostrar los elementos de la lista
    public void MostrarLista()
    {
        Nodo actual = Cabeza;
        Console.Write("Lista: ");
        
        while (actual != null)
        {
            Console.Write(actual.Dato + " - ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}