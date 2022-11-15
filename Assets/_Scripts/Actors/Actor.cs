namespace ClicheSurvivors.Actors
{
    using System;
    using ClicheSurvivors.Actors.Models;
    using ClicheSurvivors.Actors.Movement;
    using ClicheSurvivors.Pathfinding;
    using UnityEngine;

    [Serializable]
    [RequireComponent(typeof(Collider2D))]
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Actor<TD, TM> : MonoBehaviour, IPathfindTarget
        where TD : ActorModel
        where TM : MovementProvider
    {
        #region props

        [field: SerializeField]
        public Rigidbody2D Rigidbody { get; set; }
        public TM MovementProvider { get; set; }

        [field: SerializeField]
        public TD Data { get; set; }
        #endregion

        #region methods
        #region virtual
        /// <summary>
        /// Called in FixedUpdate.
        /// </summary>
        public virtual void Move()
        {
            this.Rigidbody.velocity = this.MovementProvider.MoveDir * this.Data.MoveSpeed;
        }
        #endregion

        #region unity
        public virtual void Awake() { }

        public virtual void FixedUpdate()
        {
            this.Move();
        }

        public virtual void OnEnable()
        {
            this.Rigidbody = this.GetComponent<Rigidbody2D>();

            (this.MovementProvider ??= Activator.CreateInstance<TM>()).Enable();
        }

        public virtual void OnDisable()
        {
            this.MovementProvider.Disable();
        }

        public virtual void Start() { }
        #endregion
        #endregion
    }
}
