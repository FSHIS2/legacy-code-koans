using System;

namespace LegacyCodeKoans.Unmockable {
    public interface IDependency {
        public void SomeSideEffect();
    }

    class DependencyMock : IDependency {

        public bool HasOccurSomeSideEffect; 
        public void SomeSideEffect() {
            HasOccurSomeSideEffect = true;
        }

    }
}