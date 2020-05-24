using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstSearch
{
    public class Node
    {
        public string Name { get; set; }
        public List<Node> children = new List<Node>();

        public Node(string name)
        {
            this.Name = name;
        }

        public List<string> DepthFirstSearch(List<string> array)
        {
            array.Add(Name);
            for (int i = 0; i < children.Count; i++)
            {
                children[i].DepthFirstSearch(array);
            }

            return array;
            //array.Add(Name);
            //foreach (var child in children)
            //{
            //    array.Add(child.Name);
            //    if(child.children.Count != 0)
            //        DepthSearch(array, child);
            //}
            //return array;
        }

        //private void DepthSearch(List<string> array, Node node)
        //{
        //    foreach(var child in node.children)
        //    {
        //        array.Add(child.Name);
        //        if (child.children.Count != 0)
        //            DepthSearch(array, child);
        //    }
        //}

        public Node AddChild(string name)
        {
            Node child = new Node(name);
            children.Add(child);
            return this;
        }
    }
}
