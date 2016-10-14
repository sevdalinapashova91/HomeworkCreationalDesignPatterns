using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Project
    {
        private readonly string projectType;
        public IList<string> Diagrams { get; private set; }
        public IList<string> Requirements { get; private set; }
        public IList<string> Tests { get; private set; }
        public IList<string> Projects { get; private set; }

        private readonly Dictionary<string, string> parts = new Dictionary<string, string>();
        public Project(string projectType)
        {
            this.projectType = projectType;
            Diagrams = new List<string>();
            Requirements = new List<string>();
            Tests = new List<string>();
            Projects = new List<string>();
        }
       
        
        public void ShowProjectReport()
        {
            Console.WriteLine("Project type: {0}", this.projectType);
            Console.WriteLine(" ProjectName  : {0}", string.Join(",", Projects));
            Console.WriteLine(" Project requirements : {0}", string.Join("," , Requirements));
            Console.WriteLine(" Project diagrams: {0}",string.Join(",", Diagrams));
            Console.WriteLine(" Tests : {0}",string.Join(",", Tests));
        }
    }
}
