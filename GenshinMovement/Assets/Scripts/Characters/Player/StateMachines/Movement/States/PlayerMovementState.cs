using UnityEngine;

namespace GenshinMovement
{
    public class PlayerMovementState : InterfaceState
    {
        protected PlayerMovementStateMachine stateMachine;

        protected Vector2 movementInput;

        protected float baseSpeed = 5f;//base speed 

        protected float speedModifier = 1f;//speed modifier so base speed isn't edited

        public PlayerMovementState(PlayerMovementStateMachine playerMovementStateMachine)
        {
            stateMachine = playerMovementStateMachine;
        }

        #region InterfaceState Methods
        public virtual void Enter()
        {
            Debug.Log("State: " + GetType().Name);
        }

        public virtual void Exit()
        {
            
        }

        public virtual void HandleInput()
        {
            ReadMovementInput();
            
        }

        public virtual void Update()
        {
            
        }

        public virtual void PhysicsUpdate()
        {
            Move();
        }
        #endregion

        #region Main Methods 

        private void ReadMovementInput() 
        {
            movementInput = stateMachine.Player.Input.PlayerActions.Movement.ReadValue<Vector2>();
        }

        private void Move()
        {

            if (movementInput == Vector2.zero || speedModifier == 0f)
            {
                return;//return as we aren't moving
            }

            Vector3 movementDirection = GetMovementInputDirection();

            float movementSpeed = GetMovementSpeed();

            Vector3 currentPlayerHorizontalVelocity = GetPlayerHorizontalVelocity();

            stateMachine.Player.Rigidbody.AddForce(movementDirection * movementSpeed - currentPlayerHorizontalVelocity, ForceMode.VelocityChange);//add force base on movement speed and direction

        }

        #endregion

        #region Reusable Methods

        protected Vector3 GetMovementInputDirection()
        {
            return new Vector3(movementInput.x, 0f, movementInput.y);
        }

        protected float GetMovementSpeed()
        {
            return baseSpeed * speedModifier;
        }

        protected Vector3 GetPlayerHorizontalVelocity()//so horizontal velocity won't compound up
        {
            Vector3 playerHorizontalVelocity = stateMachine.Player.Rigidbody.velocity;

            playerHorizontalVelocity.y = 0f;

            return playerHorizontalVelocity;
        }
        #endregion
    }
}
