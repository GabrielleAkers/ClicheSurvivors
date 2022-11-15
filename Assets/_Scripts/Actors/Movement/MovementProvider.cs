namespace ClicheSurvivors.Actors.Movement
{
    using UnityEngine;

    public abstract class MovementProvider
    {
        #region fields
        private bool _enabled;
        private Vector2 _moveDir = Vector2.zero;
        #endregion

        #region props
        public Vector2 MoveDir
        {
            get
            {
                return this._enabled ? this._moveDir.normalized : Vector2.zero;
            }
            protected set { this._moveDir = value; }
        }
        #endregion

        #region methods
        #region virtual
        public virtual void Enable()
        {
            this._enabled = true;
        }

        public virtual void Disable()
        {
            this._enabled = false;
        }
        #endregion
        #endregion
    }
}
