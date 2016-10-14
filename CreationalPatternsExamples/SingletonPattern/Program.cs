using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            while (counter < 6)
            {
                Parallel.For(0, 6, x => Console.WriteLine((UniqueIdGenerator.Instance.GetUniqueId())));
                counter++;
            }
        }
    }
}
