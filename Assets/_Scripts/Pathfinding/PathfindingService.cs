namespace ClicheSurvivors.Pathfinding
{
    using System;
    using ClicheSurvivors.Pathfinding.Models;
    using UnityEngine;

    [Serializable]
    public class PathfindingService
    {
        #region fields
        private readonly MapModel _pathfindingMap = new();
        #endregion

        public PathfindingService()
        {
            Debug.Log("pathfinding service started");
        }

        #region methods
        #region private
        #endregion

        #region public
        public void RegisterNode(NodeModel node)
        {
            if (!this._pathfindingMap.Nodes.Contains(node))
            {
                this._pathfindingMap.Nodes.Add(node);
            }
        }

        public void ComputePaths()
        {

        }
        #endregion
        #endregion
    }
}
