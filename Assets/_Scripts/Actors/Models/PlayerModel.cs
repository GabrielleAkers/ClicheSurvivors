namespace ClicheSurvivors.Actors.Models
{
    using System;
    using System.Collections.Generic;
    using ClicheSurvivors.Items.Models;
    using UnityEngine;

    [Serializable]
    public class PlayerModel : ActorModel
    {
        [field: SerializeField]
        public List<ItemModel> Items { get; set; }
    }
}
