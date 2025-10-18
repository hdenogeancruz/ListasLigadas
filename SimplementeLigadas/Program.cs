namespace SimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.Agregar("Primer nodo");
            lista.Agregar("Segundo nodo");
            lista.Agregar("Tercer nodo");
            Console.WriteLine("Datos en la lista:");
            Console.WriteLine(lista.ObtenerDatos());
            string datoABuscar = "Segundo nodo";
            Nodo? nodoEncontrado = lista.Buscar(datoABuscar);
            if (nodoEncontrado != null)
            {
                Console.WriteLine($"Nodo encontrado: {nodoEncontrado.Dato}");
            }
            else
            {
                Console.WriteLine($"Nodo con dato '{datoABuscar}' no encontrado.");
            }

            string datoAEliminar = "Segundo nodo";
            lista.Eliminar(datoAEliminar);
            Console.WriteLine("Datos en la lista:");
            Console.WriteLine(lista.ObtenerDatos());
        }
    }
}
