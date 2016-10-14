namespace BuilderPattern.Directors.Contracts
{
    public interface IProjectConstructor
    {
        void Constructor(IProjectBuilder projectBuilder);
    }
}
