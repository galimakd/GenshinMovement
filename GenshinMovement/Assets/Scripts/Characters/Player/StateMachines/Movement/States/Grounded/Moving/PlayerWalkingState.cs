using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GenshinMovement
{
    public class PlayerWalkingState : PlayerMovingState
    {
        public PlayerWalkingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        #region InterfaceState Methods
            public override void Enter()
            {
                base.Enter();

                stateMachine.ReusableData.MovementSpeedModifier = movementData.WalkData.SpeedModifier;
            }

        #endregion
        ///////////////////////////////////////////////////////////////////////////
        
        ////////////////////////////////////////////////////////////////////////////
        #region Input Methods
        protected override void OnWalkToggleStarted(InputAction.CallbackContext context)
        {
            base.OnWalkToggleStarted(context);

            stateMachine.ChangeState(stateMachine.RunningState);
        }

        #endregion
    }
}
