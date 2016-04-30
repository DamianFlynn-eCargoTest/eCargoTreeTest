using System;
using System.Threading.Tasks;

namespace NodeLibrary
{
    public class NodeWriter : INodeWriter
    {
        private INodeDescriber nodeDescriber;

        public NodeWriter(INodeDescriber nodeDescriber)
        {
            this.nodeDescriber = nodeDescriber;
        }

        public Task WriteToFileAsync(Node node, string filePath)
        {
            throw new NotImplementedException();
        }
    }
}