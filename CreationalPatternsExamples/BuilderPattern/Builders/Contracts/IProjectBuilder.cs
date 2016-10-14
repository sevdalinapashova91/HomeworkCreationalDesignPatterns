using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
