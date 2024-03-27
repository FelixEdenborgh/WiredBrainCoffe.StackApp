namespace WiredBrainCoffe.StackApp
{
    public class Stack<T>
    {
        private readonly T[] _items;
        private int _currentIndex = -1;

        //Konstruktor
        public Stack() => _items = new T[10]; // Initierar med en storlek på 10

        public int Count => _currentIndex + 1;

        public void Push(T item) => _items[++_currentIndex] = item;

        public T Pop() => _items[_currentIndex--];
    }
}
