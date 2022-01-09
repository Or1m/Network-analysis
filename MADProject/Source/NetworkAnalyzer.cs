using MADProject.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MADProject
{
    class NetworkAnalyzer
    {
        private readonly Dictionary<int, List<int>> network;
        private int minDegree, maxDegree;
        private float avgDegree, average;

        private List<float> degreeDistributionsPercentage;
        private List<float> degreeDistributionsNodes;
        private List<List<int>> distanceMatrix;

        private Dictionary<int, float> nodeAndAvgDist;
        private Dictionary<int, float> nodeAndClosenessCentrality;

        public NetworkAnalyzer() 
        {
            network = new Dictionary<int, List<int>>();
            degreeDistributionsPercentage = new List<float>();
            degreeDistributionsNodes = new List<float>();
            distanceMatrix = new List<List<int>>();

            nodeAndAvgDist = new Dictionary<int, float>();
            nodeAndClosenessCentrality = new Dictionary<int, float>();
        }

        public void Analyze(string source)
        {
            foreach (string line in File.ReadLines(source))
            {
                var parts = line.Split(';');
                int.TryParse(parts[0], out int key);
                int.TryParse(parts[1], out int value);

                if (!network.ContainsKey(key))
                    network[key] = new List<int>();

                network[key].Add(value);
            }

            CalcMinMaxAndAvgForDegree();
            CalcDegreeDistribution();
            PopulateDistanceMatrix();
            CalcAvgDistAvgAndClosenessCentrailty();
            //CalcAverageClustering();
        }

        private void CalcMinMaxAndAvgForDegree()
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

            minDegree = min;
            maxDegree = max;
            avgDegree = sum / (float)network.Count;
        }
        private void CalcDegreeDistribution()
        {
            int networkLength = network.Count;

            for (int i = 0; i <= maxDegree; i++)
            {
                int count = 0;

                foreach (KeyValuePair<int, List<int>> kvp in network)
                {
                    if (i == kvp.Value.Count)
                        count++;
                }

                degreeDistributionsPercentage.Add(count / (float)networkLength);
                degreeDistributionsNodes.Add(count);
            }
        }
        private void PopulateDistanceMatrix()
        {
            foreach (KeyValuePair<int, List<int>> kvp in network)
            {
                // Breadth First Search
                var startNode = kvp.Key;
                var queue = new Queue<int>();
                var distances = new Dictionary<int, int>();

                foreach (KeyValuePair<int, List<int>> kvp2 in network)
                    distances[kvp2.Key] = int.MaxValue;

                distances[startNode] = 0;
                queue.Enqueue(startNode);

                while (queue.Count > 0)
                {
                    var key = queue.Dequeue();
                    network.TryGetValue(key, out List<int> neighbours);

                    foreach (int i in neighbours)
                    {
                        if (distances[i] == int.MaxValue)
                        {
                            distances[i] = distances[key] + 1;
                            queue.Enqueue(i);
                        }
                    }
                }

                distanceMatrix.Add(distances.Values.ToList());
            }
        }
        private void CalcAvgDistAvgAndClosenessCentrailty()
        {
            int max = 0;

            var keys = network.Keys.ToList();
            int length = keys.Count;

            for (int i = 0; i < length; i++)
            {
                var row = distanceMatrix[i];
                var avgDistance = row.Sum() / (float)(row.Count - 1);
                nodeAndAvgDist[keys[i]] = avgDistance;
                nodeAndClosenessCentrality[keys[i]] = 1 / avgDistance;

                if (row.Max() > max)
                    max = row.Max();
            }

            average = max;
        }

        public void PrintToConsole(EDegreeDistributionType type, bool showMatrix)
        {
            Console.WriteLine("Min degree od node: " + minDegree);
            Console.WriteLine("Max degree od node: " + maxDegree);
            Console.WriteLine("Avg degree od node: " + avgDegree);
            Console.WriteLine("Network diameter (avg): " + average);

            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            if (type == EDegreeDistributionType.percentage || type == EDegreeDistributionType.both)
            {
                Console.WriteLine("Degree distributions in %: ");
                Console.WriteLine();

                int length = degreeDistributionsPercentage.Count;
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine("Degree {0} has {1}% of nodes.", i, degreeDistributionsPercentage[i] * 100);
                }

                Console.WriteLine();
            }

            if (type == EDegreeDistributionType.nodes || type == EDegreeDistributionType.both)
            {
                Console.WriteLine("Degree distributions in nodes: ");
                Console.WriteLine();

                int length = degreeDistributionsNodes.Count;
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine("Degree {0} has {1} nodes.", i, degreeDistributionsNodes[i]);
                }

                Console.WriteLine();
            }

            if (showMatrix)
                PrintShortestPathMatrix();

            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Neighbours count:");
            Console.WriteLine();

            foreach (KeyValuePair<int, List<int>> kvp in network)
            {
                Console.WriteLine("Node {0} has {1} neighbours: ", kvp.Key, kvp.Value.Count);
            }
            Console.WriteLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Average distances:");
            Console.WriteLine();

            foreach (KeyValuePair<int, float> kvp in nodeAndAvgDist)
            {
                Console.WriteLine("Node {0} has average distance: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Closeness centralities:");
            Console.WriteLine();

            foreach (KeyValuePair<int, float> kvp in nodeAndClosenessCentrality)
            {
                Console.WriteLine("Node {0} has closeness centrality: {1}", kvp.Key, kvp.Value);
            }
        }
        public bool PrintToFile(string path, EDegreeDistributionType type, bool showMatrix)
        {
            FileStream fileStream;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;

            try
            {
                fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(fileStream);
            }
            catch
            {
                MessageBox.Show("Cannot open file", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Console.SetOut(writer);

            PrintToConsole(type, showMatrix);

            Console.SetOut(oldOut);

            writer.Close();
            fileStream.Close();

            return true;
        }
        
        private void PrintShortestPathMatrix()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Shortest path matrix:");
            Console.WriteLine();

            int rowLength = distanceMatrix.Count;
            int colLength = distanceMatrix[0].Count;

            Console.Write("{0, -10}", "");

            var legendArr = network.Keys.ToList();
            for (int i = 0; i < colLength; i++)
            {
                Console.Write("{0, -5}", legendArr[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < rowLength; i++)
            {
                Console.Write("{0, -10}", legendArr[i]);

                for (int j = 0; j < colLength; j++)
                {
                    Console.Write("{0, -5}", distanceMatrix[i][j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
