
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstSearch
{
    class Program
    {
        static Node root;

        static void Main(string[] args)
        {
            List<string> array = new List<string>();
            Initialize();
            var result = root.DepthFirstSearch(array);
        }

        static void Initialize()
        {
            root = new Node("A");
            root.AddChild("B");
            root.AddChild("C");
            root.AddChild("D");

            root.children[0].AddChild("E");
            root.children[0].AddChild("F");

            root.children[0].children[1].AddChild("I");
            root.children[0].children[1].AddChild("J");

            root.children[2].AddChild("G");
            root.children[2].AddChild("H");

            root.children[2].children[0].AddChild("K");
        }
    }
}
