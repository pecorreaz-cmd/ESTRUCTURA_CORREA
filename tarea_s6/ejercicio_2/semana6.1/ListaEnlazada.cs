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
    
    // MÉTODO PARA INVERTIR LOS DATOS DE LA LISTA
    // Este método intercambia los valores entre nodos
    public void InvertirDatos()
    {
        // Paso 1: Contar cuántos elementos tiene la lista
        int cantidad = ContarElementos();
        
        // Si la lista tiene 0 o 1 elemento, no hay nada que invertir
        if (cantidad <= 1)
        {
            return;
        }
        
        // Paso 2: Guardar todos los datos en un arreglo
        int[] valores = new int[cantidad];
        Nodo actual = Cabeza;
        int indice = 0;
        
        // Recorrer la lista y copiar los valores al arreglo
        while (actual != null)
        {
            valores[indice] = actual.Dato;  // Guardar el dato
            indice++;
            actual = actual.Siguiente;
        }
        
        // Paso 3: Recorrer la lista nuevamente y asignar los valores invertidos
        actual = Cabeza;
        indice = cantidad - 1;  // Empezamos desde el último índice del arreglo
        
        while (actual != null)
        {
            actual.Dato = valores[indice];  // Asignar el valor invertido
            indice--;  // Retrocedemos en el arreglo
            actual = actual.Siguiente;
        }
    }
    
    // MÉTODO ALTERNATIVO: Invertir usando dos punteros
    // Este método intercambia los datos sin usar un arreglo
    public void InvertirDatosConPunteros()
    {
        int cantidad = ContarElementos();
        
        // Si tiene 0 o 1 elemento, no hacer nada
        if (cantidad <= 1)
        {
            return;
        }
        
        // Calculamos cuántos intercambios necesitamos
        int intercambios = cantidad / 2;
        
        // Para cada intercambio
        for (int i = 0; i < intercambios; i++)
        {
            // Encontrar el nodo en la posición i (desde el inicio)
            Nodo nodoInicio = ObtenerNodoEnPosicion(i);
            
            // Encontrar el nodo en la posición (cantidad - 1 - i) (desde el final)
            Nodo nodoFinal = ObtenerNodoEnPosicion(cantidad - 1 - i);
            
            // Intercambiar los datos de ambos nodos
            int temporal = nodoInicio.Dato;
            nodoInicio.Dato = nodoFinal.Dato;
            nodoFinal.Dato = temporal;
        }
    }
    
    // Método auxiliar: Obtiene el nodo en una posición específica
    private Nodo ObtenerNodoEnPosicion(int posicion)
    {
        Nodo actual = Cabeza;
        int indice = 0;
        
        // Avanzar hasta la posición deseada
        while (indice < posicion && actual != null)
        {
            actual = actual.Siguiente;
            indice++;
        }
        
        return actual;
    }
    
    // Método para contar elementos de la lista
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = Cabeza;
        
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        
        return contador;
    }
    
    // Método para mostrar los elementos de la lista
    public void MostrarLista()
    {
        Nodo actual = Cabeza;
        Console.Write("Lista: ");
        
        // Si la lista está vacía
        if (actual == null)
        {
            Console.WriteLine("(vacía)");
            return;
        }
        
        // Mostrar cada elemento
        while (actual != null)
        {
            Console.Write(actual.Dato);
            if (actual.Siguiente != null)
            {
                Console.Write(" -> ");
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine(" -> null");
    }
}
