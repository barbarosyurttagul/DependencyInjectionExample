namespace DependencyInjection
{
    internal class BarService : IBarService
    {
        private readonly IFooService _fooService;

        public BarService(IFooService fooService)
        {
            _fooService = fooService;
        }
        
        public void DoSomeRealWork()
        {
            for (int i = 0; i < 5; i++)
            {
                _fooService.DoSomeWork(i);
            }
        }
    }
}
