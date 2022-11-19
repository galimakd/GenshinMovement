using UnityEngine;

namespace GenshinMovement
{
    [RequireComponent(typeof(PlayerInput))]//every time player component is added, it will also add player input component with it
    public class Player : MonoBehaviour
    {
        public RigidBody RigidBody { get; private set; }//call rigid body

        public PlayerInput Input { get; private set; }//call player input

        //call statemachine methods
        private PlayerMovementStateMachine movementStateMachine;

        private void Awake() 
        {
            RigidBody = GetComponent<RigidBody>();

            Input = GetComponent<PlayerInput>();// get input before statemachine initialization

            movementStateMachine = new PlayerMovementStateMachine(this);
            //new instance of statemachine
        }

        private void Start() 
        {
            movementStateMachine.ChangeState(movementStateMachine.IdlingState);
            //define player starting state

        }

        private void Update() 
        {
            movementStateMachine.HandleInput();

            movementStateMachine.Update();
            
        }//handle inputs and non physics shiz

        private void FixedUpdate() 
        {
            movementStateMachine.PhysicsUpdate();
        }//run physics shiz
    }
}
