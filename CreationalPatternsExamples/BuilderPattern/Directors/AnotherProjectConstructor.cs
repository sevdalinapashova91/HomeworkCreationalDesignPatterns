using BuilderPattern.Directors.Contracts;

namespace BuilderPattern.Directors
{
    class AnotherProjectConstructor : IProjectConstructor
    {
        public void Constructor(IProjectBuilder projectBuilder)
        {
            projectBuilder.GetRequirements();
            projectBuilder.MakeDiagrams();
            projectBuilder.MakeProject();
            projectBuilder.MakeUnitTests();
         }
    }
}
