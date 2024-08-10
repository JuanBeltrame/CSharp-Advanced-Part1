namespace Library_Example_11._0._01
{
    public class Lista<T>
        where T : new()
    {
        private T[] lista;

        public void Add(T item)
        {

        }

        public T GetElement(int index)
        {
            return default(T);
        }

        public void Find<T>(T u)
        {

        }

        public void Find<U,V>(U z, V x)
        {

        }
    }

    class NoGenerica
    {
        // Una Clase NO Generica tambien puede tener metodos Genericos
        public void Find<T>(T u)
        {

        }

    }

    class Equipo<T>
    {

    }
}
