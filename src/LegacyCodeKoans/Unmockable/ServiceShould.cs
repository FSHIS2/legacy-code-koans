using FluentAssertions;
using Xunit;

namespace LegacyCodeKoans.Unmockable
{
    public class ServiceShould
    {
        [Fact]
        public void DoSomething() {
            DependencyMock dependencyMock = new DependencyMock();
            var service = new Service(dependencyMock);

            service.DoSomething();

            var result = dependencyMock.HasOccurSomeSideEffect;
            result.Should().BeTrue();

            // TODO: Assert Dependency.SomeSideEffect() method was called
        }
    }
}