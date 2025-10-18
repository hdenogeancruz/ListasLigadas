namespace SimplementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoInicial;
        public Lista()
        {
            _nodoInicial = new Nodo();
        }

        public void Agregar(string dato)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            Nodo nuevoNodo = new Nodo(dato);
            nodoActual.Siguiente = nuevoNodo;
        }

        public string ObtenerDatos()
        {
            string datos = "";
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;

                datos += nodoActual.Dato + Environment.NewLine;
            }
            return datos;
        }

        public Nodo? Buscar(string dato)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                if (nodoActual.Dato == dato)
                {
                    return nodoActual;
                }
            }
            return null;
        }

        private Nodo? BuscarNodoAnterior(string dato)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                if (nodoActual.Siguiente.Dato == dato)
                {
                    return nodoActual;
                }
                nodoActual = nodoActual.Siguiente;
            }
            return null;
        }

        private bool ValidaVacio()
        {
            return _nodoInicial.Siguiente == null;
        }

        public void Eliminar(string dato)
        {
            if (ValidaVacio())
            {
                return;
            }
            Nodo? nodoEliminar = Buscar(dato);
            if (nodoEliminar != null)
            {
                Nodo? nodoAnterior = BuscarNodoAnterior(dato);
                if (nodoAnterior != null)
                {
                    nodoAnterior.Siguiente = nodoEliminar.Siguiente;
                    nodoEliminar.Siguiente = null;
                }
            }
        }
    }
}