using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinMovement
{
    public class PlayerMovementStateMachine : StateMachine//cache states
    {
        public PlayerIdlingState IdlingState { get; }//get; so it's only settable from constructor and read only everywhere else, if private, it can be set anywhere in this class

        public PlayerWalkingState WalkingState { get; }

        public PlayerRunningState RunningState { get; }

        public PlayerSprintingState SprintingState { get; }

        public PlayerMovementStateMachine()//instantiate
        {
            IdlingState = new PlayerIdlingState();
            WalkingState = new PlayerWalkingState();
            RunningState = new PlayerRunningState();
            SprintingState = new PlayerSprintingState();
        }
    }
}
