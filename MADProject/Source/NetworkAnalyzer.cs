using System.Linq;
using System.Collections.Generic;
using System;

namespace MADProject
{
    class NetworkAnalyzer
    {
        private static NetworkAnalyzer instance = null;
        private NetworkAnalyzer() { }

        public static NetworkAnalyzer Instance
        {
            get
            {
                if (instance == null)
                    instance = new NetworkAnalyzer();

                return instance;
            }
        }

        public void AnalyzeNetwork(Dictionary<int, List<int>> network, ref Stats stats)
        {
            CalcBasicStats(network, ref stats);
            CalClusteringCoefficient(network, ref stats);
            CalcComponetsStats(network, ref stats);
        }

        private void CalcBasicStats(Dictionary<int, List<int>> network, ref Stats stats)
        {
            int min = int.MaxValue, max = 0, sum = 0;

            foreach (KeyValuePair<int, List<int>> kvp in network)
            {
                var numOfNeighbours = kvp.Value.Count;
                sum += numOfNeighbours;

                if (numOfNeighbours > max)
                    max = numOfNeighbours;

                if (numOfNeighbours < min)
                    min = numOfNeighbours;
            }

            stats.MinDegree = min;
            stats.MaxDegree = max;
            stats.NumOfEdges = sum / 2;
            stats.NumOfNodes = network.Count;
            stats.AverageDegree = sum / (float)network.Count;
        }
        private void CalcComponetsStats(Dictionary<int, List<int>> network, ref Stats stats)
        {
            var componentSizes = GetComponentSizes(network);
            int twoPlus = 0, isolated = 0, max = 0;

            foreach (var item in componentSizes)
            {
                if (item > 1) 
                    twoPlus++;
                else if (item == 1) 
                    isolated++;

                if (item > max)
                    max = item;
            }

            stats.NumOf2PlusComponents = twoPlus;
            stats.NumOfIsolatedNodes = isolated;
            stats.MaxComponentSize = max;
        }
        
        private List<int> GetComponentSizes(Dictionary<int, List<int>> network)
        {
            var nodes = network.Keys.ToList();
            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            List<int> results = new List<int>();

            foreach (var node in nodes)
                visited[node] = false;

            foreach (var node in nodes)
            {
                if (!visited[node])
                {
                    int size = 0;
                    var visitor = new HashSet<int> { node };
                    while (visitor.Count > 0)
                    {
                        var current = visitor.First();
                        visitor.Remove(current);
                        visited[current] = true;
                        size++;

                        var neighbours = network[current];
                        foreach (var item in neighbours)
                        {
                            if (!visited[item])
                                visitor.Add(item);
                        }
                    }

                    results.Add(size);
                }
            }

            return results;
        }
        private void CalClusteringCoefficient(Dictionary<int, List<int>> network, ref Stats stats, int trials = 10000)
        {
            int numOfTriangles = 0, length = network.Count;
            var nodes = network.Keys.ToList();
            var random = new Random();

            for (int i = 0; i < trials; i++)
            {
                var node = nodes[random.Next(nodes.Count)];
                var neighbours = network[node];

                if (neighbours.Count < 2) continue;

                var picks = neighbours.OrderBy(x => random.Next()).Take(2).ToList();

                if (network[picks[1]].Contains(picks[0]))
                    numOfTriangles++;
            }

            stats.AverageClusteringCoefficient = numOfTriangles / (float)trials; //TODO checkni
        }
    }
}
