namespace BuilderPattern.Directors
{
    using BuilderPattern.Directors.Contracts;

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
