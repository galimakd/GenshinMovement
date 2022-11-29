using UnityEngine;

namespace GenshinMovement
{
    [RequireComponent(typeof(PlayerInput))]//every time player component is added, it will also add player input component with it
    public class Player : MonoBehaviour
    {
        [field: Header("References")]
        [field: SerializeField] public PlayerScriptableObjects Data { get; private set; }

        [field: Header("Collissions")]
        [field : SerializeField] public CapsuleColliderUtility ColliderUtility {get; private set;}

        public Rigidbody Rigidbody { get; private set; }//call rigid body

        public Transform MainCameraTransform { get; private set; }//for rotation of player with camera

        public PlayerInput Input { get; private set; }//call player input

        //call statemachine methods
        private PlayerMovementStateMachine movementStateMachine;

        private void Awake() 
        {
            Rigidbody = GetComponent<Rigidbody>();

            Input = GetComponent<PlayerInput>();// get input before statemachine initialization

            ColliderUtility.Initialize(gameObject);
            ColliderUtility.CalculateCapsuleColliderDimensions();

            MainCameraTransform = Camera.main.transform;

            movementStateMachine = new PlayerMovementStateMachine(this);
            //new instance of statemachine
        }

        private void OnValidate()
        {
            ColliderUtility.Initialize(gameObject);
            ColliderUtility.CalculateCapsuleColliderDimensions();
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
