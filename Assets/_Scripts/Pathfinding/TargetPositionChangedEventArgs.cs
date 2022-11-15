namespace ClicheSurvivors.Pathfinding
{
    using System;

    public class TargetPositionChangedEventArgs : EventArgs
    {
        public int NewNodeIndex { get; set; }
    }
}
