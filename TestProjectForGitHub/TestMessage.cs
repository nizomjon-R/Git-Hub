using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectForGitHub
{
    class TestMessage
    {
        int c = 0;
        public string Msg()
        {
            return "Hello World!!!";
        }
        public void Add(int a,int b)
        {
            c = a / b;
        }
    }
}
