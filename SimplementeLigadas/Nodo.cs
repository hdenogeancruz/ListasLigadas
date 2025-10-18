namespace SimplementeLigadas
{
    internal class Nodo
    {
        public string Dato { get; set; }
        public Nodo? Siguiente { get; set; }

        public Nodo(string dato = "")
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
