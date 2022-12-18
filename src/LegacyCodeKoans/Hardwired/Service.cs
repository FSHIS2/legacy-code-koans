namespace LegacyCodeKoans.Hardwired
{
    public class Service
    {
        private readonly IDependency dependency;

        public Service(IDependency dependency)
        {
            this.dependency = dependency;
        }

        public void DoSomething()
        {
            dependency.SomeSideEffect();
        }
    }
}