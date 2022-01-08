using System;
using System.Collections.Generic;
using System.IO;
using Weighted_Randomizer;

namespace MADProject
{
    class NetworkGenerator
    {
        private readonly Dictionary<int, List<int>> network;
        public NetworkGenerator() 
        {
            network = new Dictionary<int, List<int>>();
        }

        public void Generate(int numOfNodes, int m)
        {
            Console.WriteLine("Number of Nodes: " + numOfNodes);
            Console.WriteLine("M: " + m);
            Console.WriteLine("---------------------");

            GenerateInitialSubNetwork(m);

            int length = numOfNodes - network.Count;
            for (int i = 0; i < length; i++)
            {
                AddNewNode(m);
            }
        }
        private void GenerateInitialSubNetwork(int m)
        {
            for (int i = 0; i < m; i++)
            {
                network[i] = new List<int>();

                for (int j = 0; j < m; j++)
                {
                    if (i != j)
                        network[i].Add(j);
                }
            }
        }
        private void AddNewNode(int m)
        {
            List<int> probabilities = new List<int>();
            List<int> picks = new List<int>();

            int length = network.Count;

            for (int i = 0; i < length; i++)
                probabilities.Add(CalcProbability(i));

            GetWeightedRandomPicks(m, probabilities, picks, length);

            for (int i = 0; i < m; i++)
                network[picks[i]].Add(network.Count);

            network[network.Count] = picks;
        }
        private int CalcProbability(int current)
        {
            int temp = 0;
            int length = network.Count;

            for (int i = 0; i < length; i++)
                temp += network[i].Count;

            float res = network[current].Count / (float)temp;

            return (int)(res * 100);
        }
        private void GetWeightedRandomPicks(int m, List<int> probabilities, List<int> picks, int length)
        {
            IWeightedRandomizer<int> randomizer = new DynamicWeightedRandomizer<int>();

            for (int i = 0; i < length; i++)
                randomizer.Add(i, probabilities[i]);

            for (int i = 0; i < m; i++)
                picks.Add(randomizer.NextWithRemoval());
        }

        public void PrintToConsole()
        {
            foreach (KeyValuePair<int, List<int>> kvp in network)
            {
                Console.WriteLine("Node {0} neighbours: ", kvp.Key);

                var list = kvp.Value;
                int length = list.Count;

                Console.Write("{");

                for (int i = 0; i < length; i++)
                    Console.Write("{0}, ", list[i]);

                Console.WriteLine("\b\b}");
            }
        }
        public void PrintToFile(string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (KeyValuePair<int, List<int>> kvp in network)
                {
                    var node = kvp.Key;

                    foreach(int neighbour in kvp.Value)
                    {
                        writer.WriteLine("{0};{1}", node, neighbour);
                    }
                }

                writer.Close();
            }
        }
    }
}
