using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubGruppeTest
{
    public class TestBranchClass_Sebastian
    {

        public TestBranchClass_Sebastian(string name) 
        {
            Name = name;
        
        }

        public string Name 
        {get; set;}

        public string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
