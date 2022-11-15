namespace ClicheSurvivors.Pathfinding
{
    using System;

    public interface IPathfindTarget
    {
        public event EventHandler<TargetPositionChangedEventArgs> TargetPositionChanged;
    }
}
