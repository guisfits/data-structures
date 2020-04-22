using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Graphs
{
    public class MyGraph<T>
    {
        private Dictionary<T, Node> _nodes;

        public MyGraph()
        {
            _nodes = new Dictionary<T, Node>();
        }

        public void AddNode(T key)
        {
            try
            {
                var node = new Node(key);
                _nodes.Add(key, node);
            }
            catch { }
        }

        public void RemoveNode(T key)
        {
            var node = _nodes.GetValue(key);
            if (node == null) return;

            foreach (var item in _nodes.Values)
                item.RemoveEdge(node);

            _nodes.Remove(key);
        }

        public void AddEdge(T from, T to)
        {
            var nodes = GetNodes(from, to);
            if (nodes == null) return;

            nodes.Item1.AddEdge(nodes.Item2);
        }

        public void RemoveEdge(T from, T to)
        {
            var nodes = GetNodes(from, to);
            if (nodes == null) return;

            nodes.Item1.RemoveEdge(nodes.Item2);
        }

        public Dictionary<T, IEnumerable<T>> GetAll()
        {
            var result = new Dictionary<T, IEnumerable<T>>();
            foreach (var node in _nodes.Values)
                result.Add(node.Key, node.GetEdges().Select(x => x.Key));

            return result;
        }

        public IEnumerable<T> TraverseDepthFirst(T label)
        {
            var list = new HashSet<T>();

            var node = _nodes.GetValue(label);
            if (node == null) return list;

            TraverseDepthFirst(node, list);

            return list;
        }

        private void TraverseDepthFirst(Node node, ISet<T> list)
        {
            list.Add(node.Key);

            foreach (var edge in node.GetEdges())
                if (!list.Contains(edge.Key))
                    TraverseDepthFirst(node, list);
        }

        public IEnumerable<T> TraverseBreathFirst(T key)
        {
            var visited = new HashSet<T>();

            var node = _nodes.GetValue(key);
            if (node == null) return visited;

            var queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Any())
            {
                var current = queue.Dequeue();

                if (visited.Contains(current.Key))
                    continue;

                visited.Add(current.Key);

                foreach (var edge in node.GetEdges())
                    if (!visited.Contains(edge.Key))
                        queue.Enqueue(edge);
            }

            return visited;
        }

        private Tuple<Node, Node> GetNodes(T from, T to)
        {
            Node fromNode;
            _nodes.TryGetValue(from, out fromNode);

            Node toNode;
            _nodes.TryGetValue(to, out toNode);

            if (fromNode == null || toNode == null)
                return null;

            return new Tuple<Node, Node>(fromNode, toNode);
        }

        public IEnumerable<T> TopologicalSort()
        {
            var visited = new HashSet<T>();
            var stack = new Stack<Node>();

            foreach (var node in _nodes.Values)
                TopologicalSort(node, visited, stack);

            while (stack.Any())
                yield return stack.Pop().Key;
        }

        private void TopologicalSort(Node node, ISet<T> visited, Stack<Node> stack)
        {
            if (node == null || visited.Contains(node.Key))
                return;

            visited.Add(node.Key);

            foreach (var edge in node.GetEdges())
                TopologicalSort(edge, visited, stack);

            stack.Push(node);
        }

        public bool HasCycle()
        {
            var all = new HashSet<Node>(_nodes.Values);
            var visiting = new HashSet<Node>();
            var visited = new HashSet<Node>();

            while (all.Any())
            {
                var current = all.First();
                if (HasCycle(current, all, visiting, visited))
                    return true;
            }

            return false;
        }

        private bool HasCycle(Node node, ISet<Node> all, ISet<Node> visiting, ISet<Node> visited)
        {
            all.Remove(node);
            visiting.Add(node);

            foreach (var edge in node.GetEdges())
            {
                if (visited.Contains(edge))
                    continue;

                if (visiting.Contains(edge))
                    return true;

                if (HasCycle(edge, all, visiting, visiting))
                    return true;
            }

            visited.Add(node);
            visiting.Remove(node);

            return false;
        }

        class Node
        {
            private readonly T _key;
            private IList<Node> _edges;

            public Node(T key)
            {
                _key = key;
                _edges = new List<Node>();
            }

            public T Key => _key;

            public void AddEdge(Node node)
            {
                _edges.Add(node);
            }

            public void RemoveEdge(Node node)
            {
                _edges.Remove(node);
            }

            public IEnumerable<Node> GetEdges()
            {
                return _edges;
            }

            public override string ToString()
            {
                return _key.ToString();
            }
        }
    }
}
