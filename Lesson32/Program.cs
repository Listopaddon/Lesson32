namespace Lesson32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            MyCollection myCollection = new MyCollection();
            myCollection.AddCollection(numbers);

            foreach (int i in myCollection)
            {
                Console.WriteLine(i);
            }
        }
    }
}