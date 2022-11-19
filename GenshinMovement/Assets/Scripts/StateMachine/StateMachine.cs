using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinMovement
{
    public abstract class StateMachine
    {
       protected InterfaceState currentState;
       //hold current state

        public void ChangeState(InterfaceState newState)
        {
            currentState?.Exit();
            //if null, don't exit

            currentState = newState;

            currentState.Enter();
        }// exit current state, get new state, start new state

        public void HandleInput()
        {
            currentState?.HandleInput();
        }

        public void Update()
        {
            currentState?.Update();
        }

        public void PhysicsUpdate()
        {
            currentState?.PhysicsUpdate();
        }
    }
}
