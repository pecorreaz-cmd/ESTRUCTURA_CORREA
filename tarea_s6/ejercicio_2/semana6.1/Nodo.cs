using System;

// Clase que representa un nodo de la lista
class Nodo
{
    public int Dato;        // El valor que guarda el nodo
    public Nodo Siguiente;  // Referencia al siguiente nodo
    
    // Constructor para crear un nodo
    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;  // Al principio no apunta a ningún nodo
    }
}