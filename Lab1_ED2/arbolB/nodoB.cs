using System.Collections;

namespace Lab1_ED2.arbolB
{
    public class keyComparer : IComparer
    {
        public delegate int compare(object N1, object N2);
        compare comparararObjetos;
        public void comparararObjetosDelegate(compare comp)
        {
            comparararObjetos = comp;
        }
        public int Compare(object L, object R)
        {
            return comparararObjetos(L, R);
        }
    }
    public class nodoB<T>
    {
        private keyComparer comparadorLlave = new keyComparer();
        public T[] datos { get; set; }
        public nodoB<T> padre { get; set; }
        public nodoB<T>[] hijos { get; set; }
        public nodoB(int orden)
        {
            datos = new T[orden - 1];
            hijos = new nodoB<T>[orden];
        }
        public nodoB(int orden, nodoB<T> nodoPadre)
        {
            datos = new T[orden];
            padre = nodoPadre;
            hijos = new nodoB<T>[orden];
        }
        internal bool estaLleno => datos[datos.Length - 1] != null;
        internal bool esHoja => hijos[0] == null;
        internal int hijoCercano(T datos2)
        {
            int posicion = 0;
            for (int i = 0; i < datos.Length; i++)
            {
                if ((comparadorLlave.Compare(datos[i], datos2) < 0) || datos[i] == null)
                {
                    posicion = i;
                    i = datos.Length;
                }
                if (i == datos.Length - 1)
                {
                    posicion = i + 1;
                    i = datos.Length;
                }
            }
            return posicion;
        }
        internal void insertarDatos(T data)
        {
            if (!estaLleno)
            {
                for (int i = 0; i < datos.Length; i++)
                {
                    if (datos[i] == null)
                    {
                        datos[i] = data;
                        i = datos.Length;
                    }
                }
            }
            else
            {
                separarNodo();
            }
        }
        public int posicionNodo(T data)
        {
            int posicion = -1;
            for (int i = 0; i < datos.Length; i++)
            {
                if (comparadorLlave.Compare(data, datos[i]) == 0)
                {
                    posicion = i;
                    i = datos.Length;
                }
            }
            return posicion;
        }
        private void separarNodo()
        {

        }
    }
}
