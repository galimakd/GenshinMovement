using UnityEngine;

namespace GenshinMovement
{
    public class PlayerInput : MonoBehaviour
    {
        //call on PlayerInputActions created by Unity
        public PlayerInputActions InputActions { get; private set; }

        public PlayerInputActions.PlayerActions PlayerActions { get; private set; }

        private void Awake() 
        {//new instance of input actions

            InputActions = new PlayerInputActions();

            PlayerActions = InputActions.Player;
        }


        //enable or disable actions when player is enabled or disabled
        private void OnEnable() 
        {
            InputActions.Enable();
        }

        private void OnDisable() 
        {
            InputActions.Disable();
        }
    }
}
