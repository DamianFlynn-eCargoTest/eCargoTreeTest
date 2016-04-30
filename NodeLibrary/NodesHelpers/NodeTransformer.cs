using System;

namespace NodeLibrary
{
    public class NodeTransformer : INodeTransformer
    {
        INodesHelper nodesHelper;

        public NodeTransformer(INodesHelper nodesHelper)
        {
            this.nodesHelper = nodesHelper;
        }

        public Node Transform(Node node)
        {
            throw new NotImplementedException();
        }     
    }
}