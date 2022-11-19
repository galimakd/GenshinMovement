using UnityEngine;

namespace GenshinMovement
{
    public class PlayerMovementState : InterfaceState
    {
        protected PlayerMovementStateMachine stateMachine;

        public PlayerMovementState(PlayerMovementStateMachine PlayerMovementStateMachine)
        {
            stateMachine = PlayerMovementStateMachine;
        }

        public virtual void Enter()
        {
            Debug.Log("State: " + GetType().Name);
        }

        public virtual void Exit()
        {
            
        }

        public virtual void HandleInput()
        {
            
        }

        public virtual void Update()
        {
            
        }

        public virtual void PhysicsUpdate()
        {
            
        }
    }
}
