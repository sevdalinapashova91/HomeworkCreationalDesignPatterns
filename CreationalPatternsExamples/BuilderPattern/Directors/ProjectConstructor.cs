using BuilderPattern.Directors.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Directors
{
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
