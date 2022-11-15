namespace ClicheSurvivors.Pathfinding.Models
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    [Serializable]
    public class MapModel
    {
        [field: SerializeField]
        public List<NodeModel> Nodes { get; set; }
    }
}
