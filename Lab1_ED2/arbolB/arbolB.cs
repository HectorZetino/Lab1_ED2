
namespace Lab1_ED2.arbolB
{
    public class arbolB<T>
    {
        nodoB<T> raiz;
        int orden;
        public arbolB()
        {
            this.raiz = null;
            this.orden = 10;
        }
        public arbolB(int orden)
        {
            this.raiz = null;
            this.orden = orden;
        }
        public void agregar(T element)
        {
            insertar(this.raiz, element);
        }
        private void insertar(nodoB<T> raiz, T elemento)
        {

            if (!(raiz.posicionNodo(elemento) != -1))
            {
                if (raiz.esHoja)
                {
                    raiz.insertarDatos(elemento);
                }
                else
                {
                    insertar(raiz.hijos[raiz.hijoCercano(elemento)], elemento);
                }
            }
        }
    }
}
