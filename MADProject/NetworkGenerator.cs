using System;
using System.Collections.Generic;

namespace MADProject
{
    class NetworkGenerator
    {
        private static NetworkGenerator instance = null;
        public static NetworkGenerator Instance
        {
            get
            {
                if (instance == null)
                    instance = new NetworkGenerator();

                return instance;
            }
        }

        private Dictionary<int, List<int>> network;

        private NetworkGenerator() 
        {
            network = new Dictionary<int, List<int>>();
        }

        public void Generate(int numOfNodes, int m)
        {
            Console.WriteLine("Number of Nodes: " + numOfNodes);
            Console.WriteLine("M: " + m);
            Console.WriteLine("---------------------");

            for (int i = 0; i < m; i++)
            {
                network[i] = new List<int>();

                for (int j = 0; j < m; j++)
                {
                    if (i != j)
                        network[i].Add(j);
                }
            }

            int length = numOfNodes - network.Count;
            for (int i = 0; i < length; i++)
            {
                AddNewNode(m);
            }
        }
        private void AddNewNode(int m)
        {
            List<float> probabilities = new List<float>();
            int length = network.Count;

            for (int i = 0; i < length; i++)
            {
                probabilities.Add(CalcProbability(i));
            }

            int a = 5;
        }
        private float CalcProbability(int current)
        {
            int temp = 0;
            int length = network.Count;

            for (int i = 0; i < length; i++)
                temp += network[i].Count;

            return network[current].Count / (float)temp;
        }

        public void PrintNetwork(EOutputType outputType = EOutputType.console)
        {
            if (outputType == EOutputType.console)
            {
                foreach (KeyValuePair<int, List<int>> kvp in network)
                {
                    Console.Write("Key {0}: ", kvp.Key);
                    kvp.Value.ForEach(x => Console.Write("{0}, ", x));
                    Console.WriteLine();
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
