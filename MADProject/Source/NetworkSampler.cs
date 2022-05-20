using MADProject.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

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
        public void DoSampling(EMethodType method, int sampleSize, int maxIterations, int startNode)
        {
            Action<int, int, int> methodAction = null;

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
            methodAction?.Invoke(sampleSize, maxIterations, startNode);
            timer.Stop();

            sampleStats.TimeTaken = timer.Elapsed;
            sampleStats.ElapsedAvailabile = true;

            //NetworkAnalyzer.Instance.AnalyzeNetwork(sample, ref sampleStats);
        }

        private void DoRandomWalk(int sampleSize, int maxIterations, int startNode)
        {
        }
        private void DoRandomWalkWithRestart(int sampleSize, int maxIterations, int startNode)
        {

        }
        private void DoRandomWalkWithJump(int sampleSize, int maxIterations, int startNode)
        {

        }
        private void DoMetropolisHastingsRW(int sampleSize, int maxIterations, int startNode)
        {

        }

        //private void CalcDegreeDistribution()
        //{
        //    int networkLength = network.Count;

        //    for (int i = 0; i <= maxDegree; i++)
        //    {
        //        int count = 0;

        //        foreach (KeyValuePair<int, List<int>> kvp in network)
        //        {
        //            if (i == kvp.Value.Count)
        //                count++;
        //        }

        //        degreeDistributionsPercentage.Add(count / (float)networkLength);
        //        degreeDistributionsNodes.Add(count);
        //    }
        //}
        //private void PopulateDistanceMatrix()
        //{
        //    foreach (KeyValuePair<int, List<int>> kvp in network)
        //    {
        //        // Breadth First Search
        //        var startNode = kvp.Key;
        //        var queue = new Queue<int>();
        //        var distances = new Dictionary<int, int>();

        //        foreach (KeyValuePair<int, List<int>> kvp2 in network)
        //            distances[kvp2.Key] = int.MaxValue;

        //        distances[startNode] = 0;
        //        queue.Enqueue(startNode);

        //        while (queue.Count > 0)
        //        {
        //            var key = queue.Dequeue();
        //            network.TryGetValue(key, out List<int> neighbours);

        //            foreach (int i in neighbours)
        //            {
        //                if (distances[i] == int.MaxValue)
        //                {
        //                    distances[i] = distances[key] + 1;
        //                    queue.Enqueue(i);
        //                }
        //            }
        //        }

        //        distanceMatrix.Add(distances.Values.ToList());
        //    }
        //}
        //private void CalcAvgDistAvgAndClosenessCentrailty()
        //{
        //    int max = 0;

        //    var keys = network.Keys.ToList();
        //    int length = keys.Count;

        //    for (int i = 0; i < length; i++)
        //    {
        //        var row = distanceMatrix[i];
        //        var avgDistance = row.Sum() / (float)(row.Count - 1);
        //        nodeAndAvgDist[keys[i]] = avgDistance;
        //        nodeAndClosenessCentrality[keys[i]] = 1 / avgDistance;

        //        if (row.Max() > max)
        //            max = row.Max();
        //    }

        //    average = max;
        //}

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
            throw new NotImplementedException();
        }
    }
}