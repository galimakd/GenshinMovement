using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinMovement
{
    public class PlayerSprintingState : PlayerMovingState
    {
        public PlayerSprintingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }
    }
}
