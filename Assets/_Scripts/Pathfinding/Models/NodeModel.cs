namespace ClicheSurvivors.Pathfinding.Models
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    [Serializable]
    public class NodeModel
    {
        [field: SerializeField]
        public Vector3 WorldPosition { get; set; }

        [field: SerializeField]
        public int NodeID { get; set; }

        [field: SerializeField]
        public List<EdgeModel> OutgoingEdges { get; set; }
    }
}
