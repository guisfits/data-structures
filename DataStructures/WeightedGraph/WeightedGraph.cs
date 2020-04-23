using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class WeightedGraph<T>
    {
        #region Fields / Constructor

        private Dictionary<T, Node> _nodes;
        private Dictionary<Node, List<Edge>> _adjacencyList;

        public WeightedGraph()
        {
            _nodes = new Dictionary<T, Node>();
            _adjacencyList = new Dictionary<Node, List<Edge>>();
        }

        #endregion

        public void AddNode(T key)
        {
            _nodes.Add(key, new Node(key));
        }

        public void AddEdge(T from, T to, int weight)
        {
            var fromNode = _nodes.GetValue(from);
            var toNode = _nodes.GetValue(to);

            if (fromNode == null || toNode == null)
                return;

            _adjacencyList
                .GetValueOrAdd(fromNode)
                .Add(new Edge(fromNode, toNode, weight));

            _adjacencyList
                .GetValueOrAdd(toNode)
                .Add(new Edge(toNode, fromNode, weight));
        }

        public Dictionary<T, IEnumerable<T>> GetAll()
        {
            var result = new Dictionary<T, IEnumerable<T>>();
            foreach (var node in _nodes.Values)
                result.Add(node.Key, _adjacencyList.GetValue(node)?.Select(x => x.To.Key));

            return result;
        }

        #region Classes

        class Node
        {
            public Node(T key)
            {
                Key = key;
            }

            public T Key { get; }
        }

        class Edge
        {
            public Edge(Node from, Node to, int weight)
            {
                From = from;
                To = to;
                Weight = weight;
            }

            public Node From { get; }
            public Node To { get; }
            public int Weight { get; }
        }

        #endregion
    }
}
