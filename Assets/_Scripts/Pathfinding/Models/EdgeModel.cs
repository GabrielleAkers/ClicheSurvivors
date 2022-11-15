namespace ClicheSurvivors.Pathfinding.Models
{
    using System;
    using UnityEngine;

    [Serializable]
    public class EdgeModel
    {
        [field: SerializeField]
        public NodeModel DestinationNode { get; set; }

        [field: SerializeField]
        public float Weight { get; set; }
    }
}
