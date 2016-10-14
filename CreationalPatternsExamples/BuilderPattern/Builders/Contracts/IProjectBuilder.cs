namespace BuilderPattern
{
    public interface IProjectBuilder
    {
        Project Project { get; set; }
        void GetRequirements();
        void MakeDiagrams();
        void MakeUnitTests();
        void MakeProject();
    }
}
