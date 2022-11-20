using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinMovement
{
    public class PlayerMovementStateMachine : StateMachine
        //cache states
    {

        public Player Player { get; }

        public PlayerIdlingState IdlingState { get; }//get; so it's only settable from constructor and read only everywhere else, if private, it can be set anywhere in this class

        public PlayerWalkingState WalkingState { get; }

        public PlayerRunningState RunningState { get; }

        public PlayerSprintingState SprintingState { get; }

        public PlayerMovementStateMachine(Player player)//instantiate
        {
            Player = player;

            IdlingState = new PlayerIdlingState(this);

            WalkingState = new PlayerWalkingState(this);

            RunningState = new PlayerRunningState(this);

            SprintingState = new PlayerSprintingState(this);

        }
    }
}
