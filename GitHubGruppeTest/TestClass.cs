using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubGruppeTest
{
    internal class TestClass : ITestClass
    {
        private int _count;
        public TestClass(string name)
        {
            Name = name;
            _count++;
        }
        public string Name { get; }
        public override string ToString()
        {
            return $"TestClass: {Name}";
        }
    }
}
