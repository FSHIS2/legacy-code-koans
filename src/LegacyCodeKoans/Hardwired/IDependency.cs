namespace LegacyCodeKoans.Hardwired {
    public interface IDependency {
        void SomeSideEffect();
    }

    public class DependencyMock : IDependency {

        public bool HasOccurredSomeSideEffect;
        public void SomeSideEffect() {
            HasOccurredSomeSideEffect = true;
        }
    }
}