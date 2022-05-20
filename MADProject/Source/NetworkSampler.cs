using MADProject.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace MADProject
{
    class NetworSampler
    {
        private readonly Dictionary<int, List<int>> network;
        private readonly Dictionary<int, List<int>> sample;

        private Stats networkStats, sampleStats;
        private (string h1, string h2) header;

        public NetworSampler() 
        {
            network = new Dictionary<int, List<int>>();
            sample = new Dictionary<int, List<int>>();
        }

        public void ParseData(string source, char delimiter, bool withHeader = false)
        {
            foreach (string line in File.ReadLines(source))
            {
                var parts = line.Split(delimiter);

                if (withHeader)
                {
                    header.h1 = parts[0];
                    header.h2 = parts[1];
                    continue;
                }

                int.TryParse(parts[0], out int nodeA);
                int.TryParse(parts[1], out int nodeB);

                if (nodeA == nodeB) continue;

                if (!network.ContainsKey(nodeA))
                    network[nodeA] = new List<int>();

                network[nodeA].Add(nodeB);

                if (!network.ContainsKey(nodeB))
                    network[nodeB] = new List<int>();

                network[nodeB].Add(nodeA);
            }

            NetworkAnalyzer.Instance.AnalyzeNetwork(network, ref networkStats);
        }
        public void DoSampling(EMethodType method, int sampleSize, int maxIterations, int startNode, float p)
        {
            Action<int, int, int, float> methodAction = null;

            switch (method)
            {
                case EMethodType.Random_Walk:
                    methodAction = DoRandomWalk;
                    break;
                case EMethodType.Random_Walk_Restart:
                    methodAction = DoRandomWalkWithRestart;
                    break;
                case EMethodType.Random_Walk_Jump:
                    methodAction = DoRandomWalkWithJump;
                    break;
                case EMethodType.Metropolis_Hastings_RW:
                    methodAction = DoMetropolisHastingsRW;
                    break;
            }

            var timer = new Stopwatch();
            timer.Start();
            methodAction?.Invoke(sampleSize, maxIterations, startNode, p);
            timer.Stop();

            sampleStats.TimeTaken = timer.Elapsed;
            sampleStats.ElapsedAvailabile = true;

            NetworkAnalyzer.Instance.AnalyzeNetwork(sample, ref sampleStats);
        }

        public void PrintStatsToConsole()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Network stats:");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine(networkStats);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Sample stats:");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine(sampleStats);
            Console.WriteLine("-----------------------------------");
        }
        public void PrintSampleToConsole()
        {
            //Console.WriteLine("Source;Target");

            foreach (KeyValuePair<int, List<int>> kvp in sample)
            {
                foreach (var neighbour in kvp.Value)
                {
                    Console.WriteLine($"{kvp.Key};{neighbour}");
                }
            }
        }

        private void DoRandomWalk(int sampleSize, int maxIterations, int startNode, float p)
        {
            var random = new Random();
            int current = SelectCurrntNode(startNode, random);

            sample[current] = new List<int>();
            List<int> sampleKeys = new List<int>() { current };

            int iterator = 0;
            while (sample.Count < sampleSize && iterator < maxIterations)
            {
                var neighbours = network[current];
                var picked = neighbours[random.Next(neighbours.Count)];

                if (!sampleKeys.Contains(picked))
                {
                    sampleKeys.Add(picked);
                    sample[picked] = new List<int>();
                }

                current = picked;
                iterator++;
            }

            AddEdgesFromNetworkToSample(sampleKeys);
        }
        private void DoRandomWalkWithRestart(int sampleSize, int maxIterations, int startNode, float p)
        {
            var random = new Random();
            int current = SelectCurrntNode(startNode, random);
            int start = current;

            sample[current] = new List<int>();
            List<int> sampleKeys = new List<int>() { current };

            int iterator = 0;
            while (sample.Count < sampleSize && iterator < maxIterations)
            {
                if (random.NextDouble() < p)
                    current = start;
                
                var neighbours = network[current];
                var picked = neighbours[random.Next(neighbours.Count)];

                if (!sampleKeys.Contains(picked))
                {
                    sampleKeys.Add(picked);
                    sample[picked] = new List<int>();
                }

                current = picked;
                iterator++;
            }

            AddEdgesFromNetworkToSample(sampleKeys);
        }
        private void DoRandomWalkWithJump(int sampleSize, int maxIterations, int startNode, float p)
        {
            var random = new Random();
            int current = SelectCurrntNode(startNode, random);

            sample[current] = new List<int>();
            List<int> sampleKeys = new List<int>() { current };
            List<int> networkKeys = network.Keys.ToList();

            int iterator = 0;
            while (sample.Count < sampleSize && iterator < maxIterations)
            {
                if (random.NextDouble() < p)
                    current = networkKeys[random.Next(networkKeys.Count)];

                var neighbours = network[current];
                var picked = neighbours[random.Next(neighbours.Count)];

                if (!sampleKeys.Contains(picked))
                {
                    sampleKeys.Add(picked);
                    sample[picked] = new List<int>();
                }

                current = picked;
                iterator++;
            }

            AddEdgesFromNetworkToSample(sampleKeys);
        }
        private void DoMetropolisHastingsRW(int sampleSize, int maxIterations, int startNode, float p)
        {
            var random = new Random();
            int current = SelectCurrntNode(startNode, random);

            sample[current] = new List<int>();
            List<int> sampleKeys = new List<int>() { current };

            int iterator = 0;
            while (sample.Count < sampleSize && iterator < maxIterations)
            {
                var neighbours = network[current];
                var picked = neighbours[random.Next(neighbours.Count)];

                if (!sampleKeys.Contains(picked))
                {
                    var probability = random.NextDouble();

                    if (probability <= network[current].Count / network[picked].Count)
                    {
                        sampleKeys.Add(picked);
                        sample[picked] = new List<int>();
                    }
                }

                current = picked;
                iterator++;
            }

            AddEdgesFromNetworkToSample(sampleKeys);
        }

        private int SelectCurrntNode(int startNode, Random random)
        {
            int current = startNode;

            if (current == -1)
            {
                var keys = network.Keys.ToList();
                current = keys[random.Next(keys.Count)];
            }

            return current;
        }
        private void AddEdgesFromNetworkToSample(List<int> sampleKeys)
        {
            foreach (var key in sampleKeys)
            {
                foreach (var neighbour in network[key])
                {
                    if (sampleKeys.Contains(neighbour))
                        sample[key].Add(neighbour);
                }
            }
        }
    }
}