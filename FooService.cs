namespace DependencyInjection
{
    internal class FooService : IFooService
    {
        public void DoSomeWork(int i)
        {
            Console.WriteLine("Processing {0}", i);
        }
    }
}
