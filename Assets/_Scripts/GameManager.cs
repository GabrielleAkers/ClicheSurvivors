namespace ClicheSurvivors
{
    using ClicheSurvivors.Pathfinding;

    public class GameManager : Singleton<GameManager>
    {
        public PathfindingService PathfindingService { get; private set; }

        private void OnEnable()
        {
            this.PathfindingService = new();
        }
    }
}
