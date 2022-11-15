namespace ClicheSurvivors.Pathfinding
{
    using System.Collections.Generic;

    public interface IPathfind
    {
        public int CurrentNodeID { get; set; }
        public List<int> Path { get; set; }
    }
}
