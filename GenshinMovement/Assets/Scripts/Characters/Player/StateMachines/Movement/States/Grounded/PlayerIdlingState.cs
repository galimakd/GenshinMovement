using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinMovement
{
    public class PlayerIdlingState : PlayerMovementState
    {
        public PlayerIdlingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {

        }

        #region InterfaceState Methods
        public override void Enter()
        {
            base.Enter();

            speedModifier = 0f;//stop moving

            ResetVelocity();
        }

        public override void Update()
        {
            base.Update();

            if(movementInput == Vector2.zero)
            {
                return;
            }

            OnMove();
        }   

        private void OnMove()
        {
            if(shouldWalk)
            {
                stateMachine.ChangeState(stateMachine.WalkingState);

                return;
            }

            stateMachine.ChangeState(stateMachine.RunningState);
        }

        #endregion
    }
}
