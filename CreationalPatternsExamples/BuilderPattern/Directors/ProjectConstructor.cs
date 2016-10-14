namespace BuilderPattern.Directors
{
    using BuilderPattern.Directors.Contracts;

    public class ProjectConstructor : IProjectConstructor
    {
        public void Constructor(IProjectBuilder projectBuilder)
        {
            projectBuilder.GetRequirements();
            projectBuilder.MakeUnitTests();
            projectBuilder.MakeProject();
            projectBuilder.MakeDiagrams();
        }
    }
}
