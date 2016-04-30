using System;

namespace NodeLibrary
{
    public class NodeDescriber : INodeDescriber
    {
        INodesHelper nodesHelper;            

        public NodeDescriber(INodesHelper nodesHelper)
        {
            this.nodesHelper = nodesHelper;
        }

        public string Describe(Node node)
        {
            throw new NotImplementedException();
        }       
    }
}