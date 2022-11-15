namespace ClicheSurvivors.Actors
{
    using System.Collections.Generic;
    using ClicheSurvivors.Actors.Models;
    using ClicheSurvivors.Actors.Movement;
    using ClicheSurvivors.Pathfinding;

    public class Monster : Actor<MonsterModel, MonsterMovementProvider>, IPathfind
    {
        #region fields
        #endregion

        #region props
        #endregion

        #region methods
        #region private
        #endregion

        #region public
        #endregion

        #region unity
        #endregion
        #endregion
        public int CurrentNodeID { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public List<int> Path { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
