using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builders
{
    class MobileProjectBuilder : IProjectBuilder
    {
        public Project Project { get; set; }
        public MobileProjectBuilder()
        {
            this.Project = new Project("Mobile project");
        }

        public void GetRequirements()
        {
            var requirements = new List<string>
            {
                "To work on all android phones",
                "To work on all windows phones",
                "To work on all iphones",
                "Do stuff"
            };

            requirements.ForEach(req => this.Project.Requirements.Add(req));
        }

        public void MakeDiagrams()
        {
            var diagrams = new List<string>
            {
                "UML diagram",
                "MVVM diagram",
            };

            diagrams.ForEach(diagram => this.Project.Diagrams.Add(diagram));
        }

        public void MakeProject()
        {
            var littleProjects = new List<string>
            {
                "Android Project",
                "IPhone Project",
                "Windows Phone Project",
            };

            littleProjects.ForEach(project => this.Project.Projects.Add(project));
        }

        public void MakeUnitTests()
        {
            var tests = new List<string>
            {
                "Can it be started",
                "Can it be closed",
                "Can it do stuff"
            };

            tests.ForEach(test => this.Project.Tests.Add(test));
        }
    }
}
