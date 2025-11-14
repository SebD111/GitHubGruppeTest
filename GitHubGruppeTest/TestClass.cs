using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubGruppeTest
{
    internal class TestClass : ITestClass
    {
        public TestClass(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public string ToString()
        {
            return $"TestClass {Name}";
        }
    }
}
