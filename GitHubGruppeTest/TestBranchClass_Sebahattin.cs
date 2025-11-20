using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubGruppeTest
{
    public class TestBranchClass_Sebahattin
    {
        public TestBranchClass_Sebahattin(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        { get; set; }

        public int Age { get; set; }
        public string ToString()
        {
            return $"Name: {Name} - {Age}";
        }
    }
}
