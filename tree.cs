using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishhook
{
    internal class treeNode<DATA>
    {
        public DATA Data {get; set;}
         public List<treeNode<DATA>> Children { get; set; }

        public treeNode(DATA data)
        {
            Data = data;
            Children = new List<treeNode<DATA>>();
        }

        public void addChild(treeNode<DATA> node)
        {
            Children.Add(node);
        }

        public void addchild(DATA stuff)
        {
            Children.Add(new treeNode<DATA>(stuff));
        }
    }

    internal class tree<T>
    {
        public treeNode<T> Root;
        
        public tree()
        {

        }

        public tree(treeNode<T> root)
        {
            this.Root = root;
        }
        public void postOrderTravel()
        {
            postOrderTravel(Root,0);
        }

        public tree(T data)
        {
            this.Root = new treeNode<T>(data);
        }

        public void postOrderTravel(treeNode<T> startNode, int depth)
        {
            foreach (var child in Root.Children)
            {
                postOrderTravel(child, depth+1);
            }

            for(int i = 0; i < depth; i++)
            {
                Console.Write("+");
            }
            Console.Write(startNode.Data);
        }
    }
}
