using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class WeightedGraph<T>
    {
        #region Fields / Constructor

        private Dictionary<T, Node> _nodes;

        public WeightedGraph()
        {
            _nodes = new Dictionary<T, Node>();
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

            fromNode.AddEdge(toNode, weight);
            toNode.AddEdge(fromNode, weight);
        }

        public Dictionary<T, IEnumerable<T>> GetAll()
        {
            var result = new Dictionary<T, IEnumerable<T>>();
            foreach (var node in _nodes.Values)
                result.Add(node.Key, node.GetEdges().Select(x => x.To.Key));

            return result;
        }

        public bool HasCycle(T Key)
        {
            var visited = new HashSet<Node>();
            foreach (var node in _nodes.Values)
            {
                if (!visited.Contains(node) && HasCycle(node, null, visited))
                    return true;
            }

            return false;
        }

        private bool HasCycle(Node node, Node parent, ISet<Node> visited)
        {
            visited.Add(node);

            foreach (var edge in node.GetEdges())
            {
                if (edge.To == parent)
                    continue;

                if (visited.Contains(edge.To) || HasCycle(edge.To, node, visited))
                    return true;
            }

            return false;
        }

        #region Classes

        class Node
        {
            List<Edge> _edges;
            public Node(T key)
            {
                Key = key;
                _edges = new List<Edge>();
            }

            public T Key { get; }

            public void AddEdge(Node to, int weight)
            {
                this._edges.Add(new Edge(to, weight));
            }

            public Edge[] GetEdges()
            {
                return _edges.ToArray();
            }
        }

        class Edge : IComparer<Edge>
        {
            public Edge(Node to, int weight)
            {
                To = to;
                Weight = weight;
            }

            public Node To { get; }
            public int Weight { get; }

            public int Compare(Edge x, Edge y)
            {
                return x.Weight - y.Weight;
            }
        }

        #endregion
    }
}
