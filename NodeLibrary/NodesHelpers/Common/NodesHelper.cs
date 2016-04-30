using System;
using System.Collections;
using System.Collections.Generic;

namespace NodeLibrary
{
    public class NodesHelper : INodesHelper
    {
        public Stack Nodes
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public void PushToStack(Node node)
        {
            throw new NotImplementedException();
        }

        public void PushChildrenToStack(Node node)
        {
            throw new NotImplementedException();
        }

        public List<Node> GetChildren(SingleChildNode node)
        {
            throw new NotImplementedException();
        }

        public List<Node> GetChildren(TwoChildrenNode node)
        {
            throw new NotImplementedException();
        }

        public List<Node> GetChildren(ManyChildrenNode manyChildrenNode)
        {
            throw new NotImplementedException();
        }
    }
}
