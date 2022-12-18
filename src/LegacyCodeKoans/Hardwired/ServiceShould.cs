using FluentAssertions;
using Xunit;

namespace LegacyCodeKoans.Hardwired
{
    public class ServiceShould
    {
        [Fact]
        public void DoSomething()
        {
            var dependencyMock = new DependencyMock();
            var service = new Service(dependencyMock);

            service.DoSomething();

            var result = dependencyMock.HasOccurredSomeSideEffect;
            result.Should().BeTrue();

            // TODO: Assert Dependency.SomeSideEffect() method was called
        }
    }
}