namespace BuilderPattern.Builders
{
    using System.Collections.Generic;

    class WebProjectBuilder : IProjectBuilder
    {
        public IEnumerable<string> Diagrams { get; private set; }       

        public IEnumerable<string> Requirements { get; private set; }

        public IDictionary<int, string> Tests { get; private set; }
        public Project Project { get; set; }

        public WebProjectBuilder()
        {
            this.Project = new Project("Web project");
        }

        public void GetRequirements()
        {
            var requirements = new List<string>
            {
                "To work on all chrome",
                "To work on all IE",
                "To work on all Fox",
                "Do stuff"
            };

            requirements.ForEach(req => this.Project.Requirements.Add(req));
        }

        public void MakeDiagrams()
        {
            var diagrams = new List<string>
            {
                "UML diagram",
                "MVC diagram",
            };

            diagrams.ForEach(diagram => this.Project.Diagrams.Add(diagram));
        }

        public void MakeProject()
        {
            var littleProjects = new List<string>
            {
                "DoStuff Project",
                "DoMoreStuff Project",
                "DoEvenMoreStuff Project",
            };

            littleProjects.ForEach(project => this.Project.Projects.Add(project));
        }

        public void MakeUnitTests()
        {
            var tests = new List<string>
            {
                "Can user log",
                "Can user log off",
                "Can do some cool stuff"
            };

            tests.ForEach(test => this.Project.Tests.Add(test));
        }
    }
}
