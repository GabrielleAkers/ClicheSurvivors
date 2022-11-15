namespace ClicheSurvivors.Actors.Models
{
    using System;
    using UnityEngine;

    [Serializable]
    public class MonsterModel : ActorModel
    {
        [field: SerializeField]
        public int Damage { get; set; }

        [field: SerializeField]
        public float FollowRange { get; set; }
    }
}
