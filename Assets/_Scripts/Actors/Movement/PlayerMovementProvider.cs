namespace ClicheSurvivors.Actors.Movement
{
    using UnityEngine;
    using UnityEngine.InputSystem;

    public class PlayerMovementProvider : MovementProvider, PlayerActions.IPlayerMapActions
    {
        private PlayerActions _playerActions;

        public override void Enable()
        {
            base.Enable();

            if (this._playerActions == null)
            {
                this._playerActions = new PlayerActions();

                this._playerActions.PlayerMap.SetCallbacks(this);
            }

            this._playerActions.PlayerMap.Enable();
        }

        public override void Disable()
        {
            base.Disable();

            this._playerActions.Disable();
        }

        public void OnMovement(InputAction.CallbackContext context)
        {
            this.MoveDir = context.action.ReadValue<Vector2>();
        }
    }
}
