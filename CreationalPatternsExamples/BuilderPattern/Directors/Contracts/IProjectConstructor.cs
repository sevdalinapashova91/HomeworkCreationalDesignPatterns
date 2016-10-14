using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Directors.Contracts
{
    public interface IProjectConstructor
    {
        void Constructor(IProjectBuilder projectBuilder);
    }
}
