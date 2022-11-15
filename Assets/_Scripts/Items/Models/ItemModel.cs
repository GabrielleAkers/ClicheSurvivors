namespace ClicheSurvivors.Items.Models
{
    using System;
    using UnityEngine;

    [Serializable]
    public class ItemModel
    {
        [field: SerializeField]
        public string Name { get; set; }
    }
}
