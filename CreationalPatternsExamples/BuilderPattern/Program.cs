namespace BuilderPattern
{
    using BuilderPattern.Builders;
    using BuilderPattern.Directors;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var constructor = new ProjectConstructor();
            var mobileProject = new MobileProjectBuilder();
            constructor.Constructor(mobileProject);
            mobileProject.Project.ShowProjectReport();

            var webProject = new WebProjectBuilder();
            constructor.Constructor(webProject);
            webProject.Project.ShowProjectReport();

            Console.WriteLine();

            var anotherConstructor = new AnotherProjectConstructor();
            var anotherMobileProject = new MobileProjectBuilder();
            anotherConstructor.Constructor(anotherMobileProject);

            anotherMobileProject.Project.ShowProjectReport();
            var anotherWebProject = new WebProjectBuilder();
            anotherConstructor.Constructor(anotherWebProject);
            anotherWebProject.Project.ShowProjectReport();
        }
    }
}
