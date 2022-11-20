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
    }
}
