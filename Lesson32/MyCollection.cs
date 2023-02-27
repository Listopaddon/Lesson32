//Создать собственную коллекцию реализующий IEnumerable интерфейс,
//который принимает в себя объекты и при перечислении выдает сумму со следующим элементом. 

using System.Collections;

namespace Lesson32
{
    internal class MyCollection : IEnumerable, IEnumerator
    {
        private List<int> myCollection = new List<int>();
        private int index = -1;

        public int Index { get { return index; } }

        public object Current => myCollection[index];

        public void Add(int i)
        {
            myCollection.Add(i);
        }

        public void AddCollection(List<int> numbers)
        {
            myCollection = numbers;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < myCollection.Count - 1; i++)
            {
                yield return myCollection[i] + myCollection[i + 1];
            }
        }

        public bool MoveNext()
        {
            if (index == myCollection.Count - 1)
            {
                return false;
            }
            index++;

            return true;
        }

        public void Reset()
        {
            index = -1;
        }

    }
}
