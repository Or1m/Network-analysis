using System;

namespace MADProject
{
    public struct Stats
    {
        public int NumOfNodes;
        public int NumOfEdges;
        public int MinDegree;
        public int MaxDegree;
        public int NumOf2PlusComponents;
        public int NumOfIsolatedNodes;
        public int MaxComponentSize;

        public float AverageDegree;
        public float AverageClusteringCoefficient;
        public TimeSpan TimeTaken;

        public bool ElapsedAvailabile;

        public override string ToString()
        {
            string elapsed = ElapsedAvailabile ? "\nElapsed time:" + TimeTaken.TotalMilliseconds : "";

            return
                $"Num of nodes:                 {NumOfNodes}\n" +
                $"Num of edges:                 {NumOfEdges}\n" +
                $"Avg degree:                   {AverageDegree}\n" +
                $"Min degree:                   {MinDegree}\n" +
                $"Max degree:                   {MaxDegree}\n" +
                $"Avg clustering coefficient:   {AverageClusteringCoefficient}\n" +
                $"Num of 2+Node components:     {NumOf2PlusComponents}\n" +
                $"Num of isolated nodes:        {NumOfIsolatedNodes}\n" +
                $"Max component size:           {MaxComponentSize}" +
                $"{elapsed}";
        }
    }
}
