namespace ClicheSurvivors.Actors.Models
{
    using System;
    using UnityEngine;

    [Serializable]
    public class ActorModel
    {
        [field: SerializeField]
        public string Name { get; set; }

        [field: SerializeField]
        public int Health { get; set; }

        [field: SerializeField]
        public int MoveSpeed { get; set; }
    }
}
