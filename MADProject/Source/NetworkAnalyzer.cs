using MADProject.Enums;
using System;
using System.Collections.Generic;
using System.IO;

namespace MADProject
{
    class NetworkAnalyzer
    {
        private readonly Dictionary<int, List<int>> network;
        private int minDegree, maxDegree;
        private float avgDegree;

        private List<float> degreeDistributionsPercentage;
        private List<float> degreeDistributionsNodes;

        private static NetworkAnalyzer instance = null;
        public static NetworkAnalyzer Instance
        {
            get
            {
                if (instance == null)
                    instance = new NetworkAnalyzer();

                return instance;
            }
        }

        private NetworkAnalyzer() 
        {
            network = new Dictionary<int, List<int>>();
            degreeDistributionsPercentage = new List<float>();
            degreeDistributionsNodes = new List<float>();
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

        public void PrintToConsole(EDegreeDistributionType type)
        {
            Console.WriteLine("Min degree od node: " + minDegree);
            Console.WriteLine("Max degree od node: " + maxDegree);
            Console.WriteLine("Avg degree od node: " + avgDegree);

            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            if (type == EDegreeDistributionType.percentage || type == EDegreeDistributionType.both)
            {
                Console.WriteLine("Degree distributions in %: ");

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

                int length = degreeDistributionsNodes.Count;
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine("Degree {0} has {1} nodes.", i, degreeDistributionsNodes[i]);
                }

                Console.WriteLine();
            }
        }
    }
}
